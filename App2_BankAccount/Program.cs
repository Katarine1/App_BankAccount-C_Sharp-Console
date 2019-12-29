using System;
using App2_BankAccount.Model;

namespace App2_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Console.WriteLine();
            Console.Write("\t\tQuantity : ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("\t\tNumber " + (i + 1) + " :\n");
                Console.Write("\t\tEnter your Name : ");
                string name = Console.ReadLine();

                Console.Write("\t\tEnter Account Number : ");
                string numberAccount = Console.ReadLine();
                                
                Console.Write("\t\tDo you want to deposit (D) or withdraw (W)? Enter the letter : ");
                char letter = char.Parse(Console.ReadLine());

                if (letter == 'D' || letter == 'd')
                {
                    Console.Write("\n\t\tEnter the amount for deposit : ");
                    double value = double.Parse(Console.ReadLine());
                    double vl = acc.deposit(double.Parse(value.ToString("F")));
                    acc = new Account(name, numberAccount, vl);
                    Console.WriteLine("\n\t\t" + acc);
                }
                else if (letter == 'W' || letter == 'w')
                {
                    Console.Write("\n\t\tEnter the amount for withdrawal : ");
                    double value = double.Parse(Console.ReadLine());
                    double vl = acc.withdraw(double.Parse(value.ToString("F")));
                    acc = new Account(name, numberAccount, vl);
                    Console.WriteLine("\n\t\t" + acc);
                }
                else
                {
                    Console.WriteLine("\t\tError typing letter");
                }
            }
        }
    }
}
