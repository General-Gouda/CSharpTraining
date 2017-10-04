using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {

            //string j = "";

            //for (int i = 0; i < 10; i++)
            //{
            //    j = i.ToString();
            //    k = i.ToString();
            //    Console.WriteLine(i);

            //    if (i == 9)
            //    {
            //        string l = i.ToString();
            //    }
            //}

            ////Console.WriteLine(i);

            //Console.WriteLine("Outside of the for: " + j);
            ////Console.WriteLine("k: " + k);
            //helperMethod();

            Car car = new Car();

            car.DoSomething("Matt");

            Console.ReadLine();
        }

        //static void helperMethod()
        //{
        //    Console.WriteLine("k from the helperMethod: " + k);
        //}
    }

    class Car
    {
        // Public methods should start with capital letter
        public void DoSomething(string name)
        {
            Console.Write(helperMethod() + ", " + name);
        }

        // Private methods should start with lower case letter
        private string helperMethod()
        {
            return "Hello world";
        }
    }
}
