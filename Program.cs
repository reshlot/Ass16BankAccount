using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass16BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of BankAccount
            BankAccount account = new BankAccount("Michael Jackson");

            //BankAccount Details
            Console.WriteLine("****Account Details****\n");
            Console.WriteLine("Account Number:723456");
            Console.WriteLine("Account Holder Name:Michael Jackson");
            Console.WriteLine("Balance:0\n");





            // Deposit some amount
            Console.WriteLine("=================================");
            Console.WriteLine("Deposit Rs.12000/-!!!");
            Console.WriteLine("=================================");
            account.Deposit(12000);
            account.PrintAccountDetails();

            // Withdraw some amount
            Console.WriteLine("=================================");
            Console.WriteLine("Withdraw Rs.5000/-!!!");
            Console.WriteLine("=================================");
            account.Withdraw(5000);
            account.PrintAccountDetails();

            
            Console.ReadKey();
        }
    }
}

