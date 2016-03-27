using System;
using _02.Bank_Of_Kurtovo_Konare.Models;

class BankOfKurtovoKunare
    {
        static void Main()
        {
            DepositAccount a= new DepositAccount(new Individual("Ivan Petrov", "Sofia, Borovo 267"),4);
            a.Deposit(4000.35);
            a.CalcIntrest(5);
            Console.WriteLine(a);
            a.Withdraw(200);
            Console.WriteLine(a);
            LoanAccount b= new LoanAccount(new Company("LIDL", "Ravno pole"), 3);
            b.Deposit(1000);
            b.CalcIntrest(4);
            Console.WriteLine(b);
            MortgageAccount c=new MortgageAccount(new Individual("Plamen Bozhkov", "Plovdiv, April 344"), 1.6);
            c.Deposit(400);
            c.CalcIntrest(7);
            Console.WriteLine(c);
            MortgageAccount d = new MortgageAccount(new Company("BILLA", "Plovdiv, Narodno sabranie 23"), 6);
            d.Deposit(30000);
            d.CalcIntrest(3);
            Console.WriteLine(d);
        }
    }

