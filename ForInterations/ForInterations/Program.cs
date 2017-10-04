using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInterations {
    class Program {
        static void Main (string[] args) {
            int i;
            for (i = 0; i <= 10; i++) {
                //Console.WriteLine(i.ToString());

                if (i == 7) {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }

            i = 1;
            for (int myValue = 1; myValue < 12; myValue++) {
                Console.WriteLine(i + "!");
                i++;
            }


            Console.ReadLine();
        }
    }
}
