using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public class Bank
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public static double InterestRate { get; private set; } = 5.0;

        public Bank(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Bank acc1 = new Bank("Alice", 5000);
    //        Bank acc2 = new Bank("Bob", 8000);

    //        Console.WriteLine("Before changing interest rate:");
    //        acc1.DisplayAccountInfo();
    //        acc2.DisplayAccountInfo();

    //        Bank.SetInterestRate(6.5);

    //        Console.WriteLine("\nAfter changing interest rate:");
    //        acc1.DisplayAccountInfo();
    //        acc2.DisplayAccountInfo();
    //    }
    //}

}