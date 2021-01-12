using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Bank_Account
{
    class Account
    {
        private string name;
        private double balance;

        public Account(string nm, double bal)
        {
            name = nm;
            balance = bal;
        }

        public double CheckBalance()
        {
            return balance;
        }

        public double WithdrawMoney(double MoneyOut)
        {
            if (MoneyOut > balance)
            {
                Console.WriteLine("You do not have enough money");
            }
            else if (MoneyOut > 0)
            {
                Console.WriteLine("Withdraw successful!");
                balance = balance - MoneyOut;
            }
            else
            {
                Console.WriteLine("No Scam!");
            }
            return balance;
        }
        public double DepositMoney(double MoneyIn)
        {
            if (MoneyIn > 0)
            {
                Console.WriteLine("Money added");
                balance = balance + MoneyIn;
            }
            else
            {
                Console.WriteLine("Deposit failed!");
            }
            return balance;
        }
        //Interest rate is in the format 1.05%
        //This means 5%
        public double AddInterest(double InterestRate) 
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
            if(date == "01/01/2021")
            {
                balance = balance * InterestRate;
            }
            return balance;
        }
    }
}



          
