using System;
using Capitalism.Interfaces;

namespace Capitalism.Models
{
    using Capitalism.Enums;
    
    public class CEO : Employee
    {
        private const Position CEOposition = Enums.Position.CEO;
        private decimal salary;


        public CEO(string firstName, string lastName, Company company, decimal salary) 
            : base(firstName, lastName, CEOposition, company)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value<0)
                {
                   throw  new ArgumentOutOfRangeException("Salary cannot be negative number.");
                }
                this.salary = value;
            }
        }
    }
}
