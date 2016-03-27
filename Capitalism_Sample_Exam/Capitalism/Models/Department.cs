namespace Capitalism.Models
{
    using System;
    using System.Collections.Generic;
    using Capitalism.Interfaces;

    public class Department
    {
        private string departmentName;
        private IEmployee manager;
        private List<IEmployee> employees;
        private List<Department> subDepartments;

        public Department(string departmentName, IEmployee manager)
        {
            this.DepartmentName = departmentName;
            this.Manager = manager;
            this.employees = new List<IEmployee>();
            this.subDepartments = new List<Department>();
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Department Name cannot be null or whitespace.");
                }
                this.departmentName = value;
            }
        }

        public IEmployee Manager { get; set; }

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

        public IEnumerable<Department> SubDepartments
        {
            get { return this.subDepartments; }
        }

        public void AddSubDepartment(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException("Department cannot be null.");
            }
            this.subDepartments.Add(department);
        }
    }
}
