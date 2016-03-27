using System;
using System.Linq;
using System.Text;
using Capitalism.Enums;
using Capitalism.Interfaces;

namespace Capitalism.Models
{
    public class Engine : IRunnable
    {

        private readonly ICompanyFactory companyFactory;
        private readonly IDepartmentFactory departmentFactory;
        private readonly ICeoFactory ceoFactory;
        private readonly IEmployeeFactory employeeFactory;
        private readonly IData data;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        public Engine(
            ICompanyFactory companyFactory,
            IDepartmentFactory departmentFactory,
            ICeoFactory ceoFactory,
            IEmployeeFactory employeeFactory,
            IData data,
            IInputReader reader,
            IOutputWriter writer)
        {
            this.companyFactory = companyFactory;
            this.departmentFactory = departmentFactory;
            this.ceoFactory = ceoFactory;
            this.employeeFactory = employeeFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public virtual void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
            }
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            string param = null;
            if (inputParams.Length==6)
            {
                param = inputParams[5];
            }
            switch (inputParams[0])
            {
                case "show-employees":
                    this.ExecuteShowEmployeesCommand();
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
                case "pay-salaries":
                    this.ExecutePaySalariesCommand(inputParams[1]);
                    break;
                case "create-company":
                    this.ExecuteCreateComapanyCommand(inputParams[1], inputParams[2], inputParams[3], inputParams[4]);
                    break;
                case "create-department":
                    this.ExecuteCreateDepartmentCommand(inputParams[1], inputParams[2], inputParams[3], inputParams[4], param);
                    break;
                case "create-employee":
                    this.ExecuteCreateEmployeeCommand(inputParams[1], inputParams[2], inputParams[3], inputParams[4], param);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");

            }
        }

        private void ExecutePaySalariesCommand(string companyName)
        {
            Company company = this.data.Companies.FirstOrDefault(c => c.CompanyName == companyName);
            company.Ceo.Salary += company.InitialSalary;
            foreach (var employee in company.Employees)
            {
                employee.Salary += (company.InitialSalary * (decimal)0.15);
            }
            foreach (var department in company.Departments)
            {
                foreach (var emp in department.Employees)
                {
                    emp.Salary += (company.InitialSalary*(decimal) 1.14);
                }
                foreach (var dept in department.SubDepartments)
                {
                    foreach (var subordinate in dept.Employees)
                    {
                        subordinate.Salary += (company.InitialSalary * (decimal)1.13);
                    }
                }
            }
        }

        private void ExecuteShowEmployeesCommand()
        {
            StringBuilder result = new StringBuilder();
            foreach (var company in this.data.Companies)
            {
                result.AppendFormat(string.Format("({0})", company.CompanyName));
                result.AppendFormat(string.Format("{0} {1} ({2})", company.Ceo.FirstName, company.Ceo.LastName, company.Ceo.Salary));
                foreach (var employee in company.Employees)
                {
                    result.AppendFormat(string.Format("{0} {1} ({2})", employee.FirstName, employee.LastName, employee.Salary)); 
                }
                foreach (var department in company.Departments)
                {
                    result.AppendFormat(string.Format("  ({0})", department.DepartmentName));
                    foreach (var employee in department.Employees)
                    {
                        result.AppendFormat(string.Format("{0} {1} ({2})", employee.FirstName, employee.LastName, employee.Salary));
                    }
                    foreach (var subDepartment in department.SubDepartments)
                    {
                        result.AppendFormat(string.Format("  ({0})", subDepartment.DepartmentName));
                        foreach (var employee in subDepartment.Employees)
                        {
                            result.AppendFormat(string.Format("{0} {1} ({2})", employee.FirstName, employee.LastName, employee.Salary));
                        }
                    }
                }
            }
            this.writer.Print(result.ToString());
        }

        private void ExecuteCreateEmployeeCommand(string firstName, string lastName, string position, string companyName, string departmentName)
        {
            if (!this.data.Companies.Any(c => c.CompanyName == companyName))
            {
                this.writer.Print(string.Format("Company {0} does not exists", companyName));
            }
            var company = this.data.Companies.FirstOrDefault(c => c.CompanyName == companyName);
            if (company.Employees.Any(e => e.FirstName == firstName && e.LastName == lastName))
            {
                var existingEmployee = (RegularEmployee)company.Employees.FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
                if (existingEmployee.Department==null)
                {
                    this.writer.Print(string.Format("Employee {0} {1} already exists in {2} (no department)", firstName, lastName, companyName));
                }
                this.writer.Print(string.Format("Employee {0} {1} already exists in {2} in department {3}", firstName, lastName, companyName, existingEmployee.Department.DepartmentName));
            }
            var pos = (Position)Enum.Parse(typeof(Position), position);
            var employee = new RegularEmployee(firstName, lastName, pos, company, null);
            if (departmentName!=null)
            {
                var department = company.Departments.FirstOrDefault(d => d.DepartmentName == departmentName);
                employee.Department = department;
            }
            company.AddEmployee(employee);
        }

        private void ExecuteCreateDepartmentCommand(string companyName, string departmentName, string firstName, string lastName, string mainDepartmentName)
        {
            if (!this.data.Companies.Any(c => c.CompanyName == companyName))
            {
                this.writer.Print(string.Format("Company {0} does not exists", companyName));
            }
            var company = this.data.Companies.FirstOrDefault(c => c.CompanyName == companyName);
            
            if (!company.Employees.Any(e => e.FirstName == firstName && e.LastName== lastName))
            {
                this.writer.Print(string.Format("There is no employee called {0} {1} in company {2}", firstName, lastName, companyName));
            }
            var manager = (RegularEmployee)company.Employees.FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
            if (mainDepartmentName == null)
            {
                if (company.Departments.Any(d => d.DepartmentName == departmentName))
                {
                    this.writer.Print(string.Format("Department {0} already exists in {1}", departmentName, companyName));
                }
                var department = new Department(departmentName, manager);
                manager.Department = department;
                company.AddDepartment(department);
            }
            else
            {
                if (!company.Departments.Any(d => d.DepartmentName == mainDepartmentName))
                {
                    this.writer.Print(string.Format("There is no department {0} in {1}", mainDepartmentName, companyName));
                }
                var department = company.Departments.FirstOrDefault(d => d.DepartmentName == mainDepartmentName);
                var subDepartment = new Department(departmentName, manager);
                manager.Department = subDepartment;
                department.AddSubDepartment(subDepartment);
            }
        }

        private void ExecuteCreateComapanyCommand(string companyName, string firstName, string lastName, string salary)
        {
            if (this.data.Companies.Any(c => c.CompanyName == companyName))
            {
                this.writer.Print(string.Format("Company {0} already exists", companyName));
            }
            Company company = this.companyFactory.CreateCompany(companyName);
            if (company.Employees.Any(e=>e.FirstName==firstName && e.LastName== lastName))
            {
                var employee = (Employee)company.Employees.FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
                employee.Position = Position.CEO;
                company.Ceo = (CEO)employee;
                company.InitialSalary = company.Ceo.Salary;
                this.data.Companies.Add(company);
            }
            IEmployee ceo = this.ceoFactory.CreateCeo(firstName, lastName, company, 0);
            company.Ceo = (CEO)ceo;
            company.InitialSalary = decimal.Parse(salary);
            this.data.Companies.Add(company);
        }
    }
}