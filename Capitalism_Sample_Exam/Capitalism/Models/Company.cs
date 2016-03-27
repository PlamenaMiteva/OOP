using Capitalism.Interfaces;

namespace Capitalism.Models
{
    using System;
    using System.Collections.Generic;

    public class Company 
    {
        private string companyName;
        private List<Department> departments;
        private List<IEmployee> employees;
        private decimal initialSalary;
       
        public Company(string companyName)
        {
            this.CompanyName = companyName;
            this.departments = new List<Department>();
            this.employees = new List<IEmployee>();
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Company Name cannot be null or whitespace.");
                }
                this.companyName = value;
            }
        }

        public CEO Ceo { get; set; }

        public IEnumerable<Department> Departments
        {
            get { return this.departments; }
        }

        public void AddDepartment(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException("Department cannot be null.");
            }
            this.departments.Add(department);
        }

        public IEnumerable<IEmployee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(IEmployee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null.");
            }
            this.employees.Add(employee);
        }

        public decimal InitialSalary
        {
            get
            {
                return this.initialSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The initial salary should be non-negative.");
                }

                this.initialSalary = value;
            }
        }
    }
}
