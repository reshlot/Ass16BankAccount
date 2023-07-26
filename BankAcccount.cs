using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass16BankAccount
{
    public class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private decimal Balance { get; set; }

        // Constructor
        public  BankAccount (string accountHolderName)
        {
            AccountNumber = 723456;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance -> :(\n");
            }
            else
            {
                Balance -= amount;
            }
        }

        
        public void PrintAccountDetails()
        {
            Console.WriteLine("****Current Account Details****\n");
           // Console.WriteLine("=================================");
            Console.WriteLine("Account Number: "+AccountNumber);
            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine(" Current Balance: " + Balance);
            Console.WriteLine();
        }
    }
}

