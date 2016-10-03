using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBindingExample
{
    class Program
    {
        static dynamic Mean(dynamic x, dynamic y) => (x + y) / 2;

        static void Main()
        {
            //Example 1
            int x = 3, y = 4;
            Console.WriteLine(Mean(x, y));

            //Example 2
            dynamic z = "hello";
            Console.WriteLine(z.GetType().Name); // String
            z = 123; // No error (despite same variable)
            Console.WriteLine(z.GetType().Name); // Int32
        }
    }
}
