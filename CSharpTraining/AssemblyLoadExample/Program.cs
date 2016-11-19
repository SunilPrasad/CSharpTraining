using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyName = "WebServices";
           
            

            Assembly webServiceAsm = Assembly.Load(assemblyName);
            Console.WriteLine(webServiceAsm.FullName);

            Type [] publicType =  webServiceAsm.GetExportedTypes();




        }
    }
}
