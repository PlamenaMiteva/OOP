using System;
using System.Linq;

namespace CompanyHierarchy.Models
{
    using System.Collections.Generic;
    using System.Text;
    using CompanyHierarchy.Interfaces;

    public class Manager : Employee, IManager
    {
        private List<Employee> subordinates;

        public Manager(int id, string fname, string lname, decimal salary, Department department)
            : base(id, fname, lname, salary, department)
        {
            this.subordinates = new List<Employee>();
        }

        public IEnumerable<Employee> Subordinates
        {
            get { return this.subordinates; }
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null.");
            }
            if (employee.Department!=this.Department)
            {
                throw  new ArgumentException("Department of employee and manager should be the same.");
            }
            this.subordinates.Add(employee);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Department + " Department - " + this.Id + " - " + this.FirstName + " " + this.LastName + " - " + this.Salary + " BGN" + System.Environment.NewLine);
            if (this.Subordinates.Any())
            {
                result.Append("Subordinates:" + System.Environment.NewLine + System.Environment.NewLine);
                foreach (var subordinate in this.Subordinates)
                {
                    result.Append(subordinate + System.Environment.NewLine);
                }
            }
            else
            {
                result.Append("No Subordinates");
            }
            return result.ToString();
        }
    }
}
