using System;

namespace _02.Bank_Of_Kurtovo_Konare.Models
{
    public abstract class Customer
    {
        private string names;
        private string address;

        protected Customer(string names, string address)
        {
            this.Names = names;
            this.Address = address;
        }

        public string Names
        {
            get { return this.names; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Names cannot be null or whitespace.");
                }
                this.names = value;
            }
        }
        public string Address
        {
            get { return this.address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address cannot be null or whitespace.");
                }
                this.address = value;
            }
        }
    }
}
