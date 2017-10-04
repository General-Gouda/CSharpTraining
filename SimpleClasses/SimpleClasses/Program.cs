using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses {

    class Car {
        public string Make {
            get; set;
        }
        public string Model {
            get; set;
        }
        public int Year {
            get; set;
        }
        public string Color {
            get; set;
        }

        public double DetermineMarketValue () {
            double carValue = 100.0;

            if (this.Year > 1990) {
                carValue = 10000.0;
            } else {
                carValue = 2000.0;
            }

            return carValue;
        }
    }

    class Program {
        static void Main (string[] args) {
            Car myNewCar = new Car();

            myNewCar.Color = "Blue";
            myNewCar.Make = "Ford";
            myNewCar.Year = 2005;
            myNewCar.Model = "Freestyle";

            Console.WriteLine("Make: {0}\nModel: {1}\nColor: {2}\nYear: {3}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color,
                myNewCar.Year
            );

            //double marketValueOfCar = determineMarketValue(myNewCar);
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static double determineMarketValue (Car car) {
            double carValue = 100.0;

            return carValue;
        }

    }
}
