using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Base Account: Calculating interest...");
        }
    }

    class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Savings Account: Interest calculated at 4% per annum.");
        }
    }

    // ❌ This will cause an error because CalculateInterest() is sealed
    // class HighInterestSavings : SavingsAccount
    // {
    //     public override void CalculateInterest() { Console.WriteLine("High Interest Rate"); }
    // }

}
