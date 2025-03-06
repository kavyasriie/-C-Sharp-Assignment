using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
    class BankAccount
    {

        private decimal balance; // Private field to store the balance

        // Constructor to initialize the account with an optional starting balance
        public BankAccount(decimal initialBalance = 0)
        {
            if (initialBalance >= 0)
                balance = initialBalance;
            else
                Console.WriteLine("Initial balance cannot be negative.");
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // Method to withdraw money from the account (only if balance is sufficient)
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return false;
            }
            else if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. New balance: ${balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
        }

        // Method to check the current balance (read-only)
        public decimal GetBalance()
        {
            return balance;
        }
    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount(100); // Initial balance of $100

//            account.Deposit(50);     // Deposited: $50. New balance: $150
//            account.Withdraw(30);    // Withdrew: $30. New balance: $120
//            account.Withdraw(200);   // Insufficient balance.

//            Console.WriteLine($"Final balance: ${account.GetBalance()}");
//        }
//    }
}