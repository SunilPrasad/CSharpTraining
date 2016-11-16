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

            string assemblyPath = @"D:\MyWorkspace\CSharpTraining\CSharpTraining\WebServices\bin\Debug\WebServices.dll";
            Assembly webServiceAssembly =  Assembly.LoadFrom(assemblyPath);
            Console.WriteLine(webServiceAssembly.FullName);
        }
    }
}
