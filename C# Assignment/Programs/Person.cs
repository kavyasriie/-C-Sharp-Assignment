using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Virtual method that can be overridden by derived classes
        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Student : Person
    {
        public int RollNo { get; set; }

        // Overriding the virtual method
        public override void GetDetails()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, Roll No: {RollNo}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        // Overriding the virtual method
        public override void GetDetails()
        {
            Console.WriteLine($"Teacher: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Base class reference pointing to a Student object
    //        Person person1 = new Student { Name = "Alice", Age = 20, RollNo = 101 };
    //        person1.GetDetails(); 
    //        Person person2 = new Teacher { Name = "Mr. John", Age = 40, Subject = "Mathematics" };
    //        person2.GetDetails(); 
    //        Person person3 = new Person { Name = "Generic Person", Age = 35 };
    //        person3.GetDetails(); // Output: Name: Generic Person, Age: 35
    //    }
    //}
}