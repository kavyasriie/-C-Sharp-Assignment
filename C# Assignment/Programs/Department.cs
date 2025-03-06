using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    public class Department
    {
        public string DeptName { get; set; }
        public Manager Manager { get; set; }

        public Department(string deptName, Manager manager)
        {
            DeptName = deptName;
            Manager = manager;
        }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        public Department DeepCopy()
        {
            return new Department(DeptName, new Manager(Manager.Name));
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DeptName}, Manager: {Manager.Name}");
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Department original = new Department("IT", new Manager("Alice"));

    //        Department shallowCopy = original.ShallowCopy();
    //        Department deepCopy = original.DeepCopy();

    //        original.Manager.Name = "Bob";

    //        Console.WriteLine("After modifying original manager:");
    //        Console.WriteLine("Original:");
    //        original.Display();

    //        Console.WriteLine("Shallow Copy:");
    //        shallowCopy.Display();

    //        Console.WriteLine("Deep Copy:");
    //        deepCopy.Display();
    //    }
    //}
}