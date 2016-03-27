namespace CompanyHierarchy.Models
{
    using System;
    using CompanyHierarchy.Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;


        protected Employee(int id, string fname, string lname, decimal salary, Department department)
            : base(id, fname, lname)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
                else
                {
                    this.salary = value;
                }

            }
        }

        public Department Department { get; set; }


    }
}
