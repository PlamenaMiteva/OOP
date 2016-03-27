namespace Capitalism.Models
{
    using System;
    using Capitalism.Enums;
    using Capitalism.Interfaces;

    public abstract class Employee : IEmployee
    {
        private string fullName;
        private string firstName;
        private string lastName;
        private Position position;
        private Company company;
        private decimal salary = 0;

        protected Employee(string firstName, string lastName, Position position, Company company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = firstName + " " + lastName;
            this.Position = position;
            this.Company = company;
        }


        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Full Name cannot be null or whitespace.");
                }
                this.fullName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First Name cannot be null or whitespace.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last Name cannot be null or whitespace.");
                }
                this.lastName = value;
            }
        }

        public Position Position { get; set; }

        public Company Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "The salary should be non-negative.");
                }

                this.salary = value;
            }
        }
    }
}
