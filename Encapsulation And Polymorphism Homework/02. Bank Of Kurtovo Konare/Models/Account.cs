namespace _02.Bank_Of_Kurtovo_Konare.Models
{
    using System;
    using Interfaces;

    public abstract class Account : IDeposit
    {
        private Customer client;
        private double intrestRate;

        protected Account(Customer client, double intrestRate)
        {
            this.Client = client;
            this.IntrestRate = intrestRate;
            this.Balance = 0;
        }

        public Customer Client { get; set; }

        public double Balance { get; protected set; }

        public double IntrestRate
        {
            get { return this.intrestRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Intrest rate cannot be null.");
                }
                this.intrestRate = value;
            }
        }

        public double Deposit(double deposittedMoney)
        {
            return this.Balance += deposittedMoney;
        }

        public abstract double CalcIntrest(int months);

        public override string ToString()
        {
            return string.Format("Name: {0}, Address: {1}, Account balance: {2:0.00} BGN",
                this.Client.Names, this.Client.Address, this.Balance);
        }

    }
}
