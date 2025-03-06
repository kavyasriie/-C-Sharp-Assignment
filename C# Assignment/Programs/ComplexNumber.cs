using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

//    class Program
//    {
//        static void Main()
//        {
//            ComplexNumber num1 = new ComplexNumber(3, 4);
//            ComplexNumber num2 = new ComplexNumber(2, 5);

//            ComplexNumber result = num1 + num2;

//            Console.WriteLine($"Sum: {result}");
//        }
//    }
}