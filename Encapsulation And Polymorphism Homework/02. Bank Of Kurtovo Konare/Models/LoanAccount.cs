namespace _02.Bank_Of_Kurtovo_Konare.Models
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer client, double intrestRate)
            : base(client, intrestRate)
        {
        }

        public override double CalcIntrest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative.");
            }
            if (this.Client.GetType().ToString() == "Individual")
            {
                months -= 3;
            }
            else if (this.Client.GetType().ToString() == "Company")
            {
                months -= 2;
            }
            if (months > 0)
            {
                return this.Balance += (this.Balance * months * this.IntrestRate) / 100;
            }
            else
            {
                return this.Balance;
            }
        }
        
    }
}
