using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VisualStudioSdk;

namespace AddInApplicationExample
{
    public static class Program
    {
        public static void Main()
        {
            // Find the directory that contains the Host exe
            String AddInDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            // Assume AddIn assemblies are in same directory as host's EXE file
            var AddInAssemblies = Directory.EnumerateFiles(AddInDir, "*.dll");
            // Create a collection of Add-In Types usable by the host

            //typeof(IMyInterface).IsAssignableFrom(typeof(MyType))

            List<Type> AddInTypes = new List<Type>();

            foreach (var addInAssembly in AddInAssemblies)
            {
                Assembly assembly = Assembly.LoadFrom(addInAssembly);

                Type[] types = assembly.GetExportedTypes();

                foreach (var type in types)
                {
                    if ((type.IsClass && typeof(IAddIn).IsAssignableFrom(type)))
                    {
                        AddInTypes.Add(type);
                    }
                }
            }

            // Initialization complete: the host has discovered the usable Add-Ins
            // Here's how the host can construct Add-In objects and use them
            foreach (Type t in AddInTypes)
            {
                IAddIn ai = (IAddIn)Activator.CreateInstance(t);
                Console.WriteLine(ai.DoSomething(5));
            }
        }
    }
}
