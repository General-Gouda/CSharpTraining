using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods {
    class Program {
        static void Main (string[] args) {
            string myValue = superSecretFormula("Matt",2);
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula() {
            // some cool stuff here
            return "Hello, World!";
        }

        private static string superSecretFormula (
            string name,
            int number
        ) {
            return String.Format("Hello, {0}! You are number {1}!", name, number);
        }
    }
}
