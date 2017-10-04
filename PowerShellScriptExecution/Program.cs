using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Threading;

namespace PowerShellScriptExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                // use "AddScript" to add the contents of a script file to the end of the execution pipeline.
                // use "AddCommand" to add individual commands/cmdlets to the end of the execution pipeline.
                PowerShellInstance.AddScript("Get-Process");
                var Output = PowerShellInstance.Invoke();

                foreach (var psobject in Output)
                {
                    Console.WriteLine(psobject.BaseObject.ToString());
                }

                Console.ReadLine();
            }
        }
    }
}
