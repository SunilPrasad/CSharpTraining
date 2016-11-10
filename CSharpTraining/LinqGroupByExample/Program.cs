using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupByExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                  "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                   "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };

            // Create a query that groups websites by top-level domain name.
            var webAddrs = from addr in websites
                           where addr.LastIndexOf('.') != -1
                           group addr by addr.Substring(addr.LastIndexOf('.'));

            // Execute the query and display the results.
            foreach (var sites in webAddrs)
            {
                Console.WriteLine("Web sites grouped by " + sites.Key);

                foreach (var site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }

            
        }
    }
}
