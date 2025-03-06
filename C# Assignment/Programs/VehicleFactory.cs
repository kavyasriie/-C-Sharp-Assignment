using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public interface IVehicle
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is riding...");
        }
    }

    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                _ => throw new ArgumentException("Invalid vehicle type")
            };
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        IVehicle car = VehicleFactory.GetVehicle("Car");
    //        car.Drive();

    //        IVehicle bike = VehicleFactory.GetVehicle("Bike");
    //        bike.Drive();
    //    }
    //}

}