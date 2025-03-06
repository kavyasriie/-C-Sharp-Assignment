using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    namespace Inheritance
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        class Student : Person
        {
            public int StudentId { get; set; }

            public Student(string name, int age, int studentId) : base(name, age)
            {
                StudentId = studentId;
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
            }
        }

       
    }
    }

