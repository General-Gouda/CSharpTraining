using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings {
    class Program {
        static void Main (string[] args) {

            // Escape sequences
            //string myString = "Go to your C:\\ drive";
            //string myString = "My \"So called\" life";
            //string myString = "What if I need \n a new line?";

            // Replacement and substitution sequences
            //string myString = string.Format("{0}!","Bonzai");
            //string myString = string.Format("Make: {0} (Model: {1})","BMW","760li");

            //string myString = string.Format("{0:C}",123.45); // Currency
            //string myString = string.Format("{0:N}",123456789); // Numbers with , and decimals
            //string myString = string.Format("{0:P}",.123); // Percentages
            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890); // Placing characters in a sequence

            //string myString = "0";

            //for (int i = 1; i <= 100; i++) {
            //    string a = i.ToString();
            //    if (a.Length < 2) {
            //        a = "0" + a;
            //    } else {
            //        a = i.ToString();
            //    }

            //    myString = myString + "--" + a;
            //}

            //StringBuilder myString = new StringBuilder();

            //for (int i = 0; i < 100; i++) {
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            string myString = "  That summer we took threes across the board  ";

            //myString = myString.Substring(5,14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ","--");
            myString = String.Format("Length before: {0} -- After: {1}", 
                myString.Length,
                myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
