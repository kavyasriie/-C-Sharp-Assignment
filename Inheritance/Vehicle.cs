using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string Brand { get; set; } = string.Empty;
        public int Speed { get; set; }
        public string DisplayInfo()
        {
            return $"Brand: {Brand}, Speed: {Speed}";
        }
    }
    class Car : Vehicle
    {
        public string DisplayCarInfo()
        {
            return DisplayInfo();
        }
    }
    class Bike : Vehicle
    {
        public string DisplayBikeInfo()
        {
            return DisplayInfo();
        }
    }

}
