namespace _02.Bank_Of_Kurtovo_Konare.Models
{
    using System;
    using Interfaces;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer client, double intrestRate)
            : base(client, intrestRate)
        {
        }

        public double Withdraw(double withdrawnMoney)
        {
            if ((this.Balance - withdrawnMoney) < 0)
            {
                throw new ArgumentOutOfRangeException("The amount you wish to withdraw exceeds your account balance.");
            }
            return this.Balance -= withdrawnMoney;
        }

        public override double CalcIntrest(int months)
        {
            if (months<0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative.");
            }
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.IntrestRate = 0;
            }
            return this.Balance += (this.Balance * months * this.IntrestRate) / 100;
        }

        
    }
}
