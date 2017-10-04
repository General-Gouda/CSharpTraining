using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables {
    class Program {
        static void Main (string[] args) {

            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine (y);
            

            //string myFirstName;
            //myFirstName = "Matt";

            //string myFirstName = "Matt";

            var myFirstName = "Matt";

            var x = 34;
            var myLastName = "Marchese";

            Console.WriteLine (myFirstName + " " + myLastName + " is " + x + " years old");

            */

            int x = 7;
            //string y = "Matt";
            string y = "5";

            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);

            Console.WriteLine (myFirstTry);
            //Console.WriteLine(mySecondTry);

            Console.ReadLine ();
        }
    }
}
