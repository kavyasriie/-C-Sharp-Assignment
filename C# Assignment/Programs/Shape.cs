using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
    public abstract class Shape
    {
        // Abstract method - Must be implemented in derived classes
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementing abstract method
        public override double CalculateArea()
        {
            return Math.PI * radius * radius; // Area = π * r²
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Implementing abstract method
        public override double CalculateArea()
        {
            return length * width; // Area = length * width
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        // Create instances of derived classes
    //        Shape circle = new Circle(5);     // Circle with radius 5
    //        Shape rectangle = new Rectangle(4, 6); // Rectangle with length 4 and width 6

    //        // Calculate and display areas
    //        Console.WriteLine($"Area of Circle: {circle.CalculateArea():F2}");
    //        Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea():F2}");
    //    }
    //}
}