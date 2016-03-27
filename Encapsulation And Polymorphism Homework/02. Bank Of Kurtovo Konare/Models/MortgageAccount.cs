namespace _02.Bank_Of_Kurtovo_Konare.Models
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer client, double intrestRate)
            : base(client, intrestRate)
        {
        }
        
        public  override double CalcIntrest (int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative.");
            }
            if (this.Client.GetType().ToString() == "Individual")
            {
                months -= 6;
            }
            if (this.Client.GetType().ToString() == "Company")
            {
                int m = 0;
                if (months <= 12)
                {
                    m = months;
                }
                else
                {
                    m = 12;
                }
                this.Balance += (this.Balance * m * this.IntrestRate / 2) / 100;
                months -= m;
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
