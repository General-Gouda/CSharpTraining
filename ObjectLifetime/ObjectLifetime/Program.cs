using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime {

    class Car 
    {
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public string Color {get; set;}
        public double OriginalPrice { get; set; }

        public Car() {
            // Hard coding example
            this.Make = "Nissan";
        }

        // Overload constructor example
        public Car (string make, string model, int year, string color) {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Incorrect overload because it uses already used parameters
        //public Car(string someOtherInputParameter,string model,int year,string color) {
        //    Make = someOtherInputParameter;
        //    Model = model;
        //    Year = year;
        //    Color = color;
        //}

        public static void myMethod() {

        }
    }
    class Program 
    {
        static void Main (string[] args) 
        {
            Car myCar = new Car();

            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Ford","Escape",2005,"Red");

            myOtherCar = null;
            myCar = null;
        }
    }
}
