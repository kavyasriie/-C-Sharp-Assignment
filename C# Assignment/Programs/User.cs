using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username} has basic access.");
        }
    }

    public class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Admin) has full access to the system.");
        }
    }

    public class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Customer) has limited access to features.");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        User admin = new Admin("Alice");
    //        User customer = new Customer("Bob");

    //        admin.AccessControl();
    //        customer.AccessControl();
    //    }
    //}
}