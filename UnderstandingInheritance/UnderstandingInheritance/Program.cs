using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;

            printVehicleDetails(myTruck);

            Semi mySemi = new Semi();

            mySemi.Make = "Mac";
            mySemi.Model = "Unknown";
            mySemi.Year = 2001;
            mySemi.Length = 40;

            printVehicleDetails(mySemi);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehicle's details: {0}",
                vehicle.VehicleInfo());
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string VehicleInfo();
    }

    class Car : Vehicle
    {
        public override string VehicleInfo()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year
            );
        }
    }

    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }
        public override string VehicleInfo()
        {
            return String.Format("{0} - {1} - {2} -{3} Towing units",
                this.Make,
                this.Model,
                this.Year,
                this.TowingCapacity
            );
        }
    }

    class Semi : Vehicle
    {
        public int Length { get; set; }
        public override string VehicleInfo()
        {
            return String.Format("{0} - {1} - {2} ft - {3}",
                this.Make,
                this.Model,
                this.Length,
                this.Year
            );
        }
    }
}
