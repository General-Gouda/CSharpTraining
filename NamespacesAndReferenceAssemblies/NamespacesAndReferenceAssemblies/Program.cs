using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;
//using System.IO;

namespace NamespacesAndReferenceAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader myStreamReader = new StreamReader();

            Tabor.Bob bob = new Bob();

            Console.WriteLine(bob.Lookup("http://www.google.com"));
            Console.ReadLine();
        }
    }
}
