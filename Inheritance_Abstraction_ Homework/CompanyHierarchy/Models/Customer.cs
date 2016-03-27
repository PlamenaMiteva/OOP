namespace CompanyHierarchy.Models
{
    using System;
    using CompanyHierarchy.Interfaces;

    public class Customer : Person, ICustomer
    {
        private decimal amount;

        public Customer(int id, string fname, string lname, decimal amount)
            : base(id, fname, lname)
        {
            this.NetPurchaseAmount = amount;
        }


        public decimal NetPurchaseAmount
        {
            get { return this.amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net Purchase Amount cannot be negative.");
                }
                else
                {
                    this.amount = value;
                }

            }
        }
    }
}
