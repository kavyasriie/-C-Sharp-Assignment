using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle2
    {
        public string brand { get; set; }
        public int speed { get; set; }

        public string DisplayInfo()
        {
            return $"Brand: {brand}, Speed: {speed}";
        }
    }
    class Car2 : Vehicle2
    {
        public string DisplayCarInfo()
        {
            Console.WriteLine("This is a car");
            return base.DisplayInfo();
           
        }
    }
    class Bike2 : Vehicle2
    {
        public string DisplayBikeInfo()
        {
            Console.WriteLine("This is a bike");
            return base.DisplayInfo();
        }
    }
}
