using System;
using System.Collections.Generic;
using System.Text;

namespace App2_BankAccount.Model
{
    public class Account
    {
        private string Name { get; set; }
        private string NumberAccout { get; set; }
        private double Balance { get; set; }

        public Account() { }

        public Account(string name, string numberAccout, double balance)
        {
            Name = name;
            NumberAccout = numberAccout;
            Balance = balance;
        }

        public double deposit(double value)
        {
            return Balance += value;
        }

        public double withdraw(double value)
        {
            return Balance -= value + 0.2; //Plus 2% Rate
        }

        public override string ToString()
        {
            return "Name: " + Name + ", " + "Accout: " + NumberAccout + ", Balance : " + Balance + "\n";
        }
    }
}
