using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
    public class Student
    {
        private string name;
        private int rollNo;

        // Property for Name with validation
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty or null.");
            }
        }

        // Property for RollNo with validation
        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                    rollNo = value;
                else
                    Console.WriteLine("Roll Number cannot be negative or zero.");
            }
        }

        // Constructor to initialize Student
        public Student(string name, int rollNo)
        {
            Name = name;   // Calls the property (validates input)
            RollNo = rollNo;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}, Roll No: {RollNo}");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        Student student1 = new Student("Alice", 101);
    //        student1.Display();  // Output: Student Name: Alice, Roll No: 101

    //        Student student2 = new Student("", -5); // Invalid input
    //        student2.Display(); // Output: Name cannot be empty. Roll Number cannot be negative or zero.
    //    }
    //}
}