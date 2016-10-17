using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWhereExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { ".com", ".net", "hsNameA.com", "hsNameB.net","test", ".network", "hsNameC.net", "hsNameD.com" };
            // Create a query that obtains Internet addresses that
            // end with .net.
            var netAddrs = from addr in strs
                           where addr.Length > 4 && addr.EndsWith(".net",
                           StringComparison.Ordinal)
                           select addr;
            // Execute the query and display the results.
            foreach (var str in netAddrs) Console.WriteLine(str);
        }

        private static bool Filter(string addr)
        {
            return addr.Length > 4 && addr.EndsWith(".net",
                           StringComparison.Ordinal);
        }
    }
}
