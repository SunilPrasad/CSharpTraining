using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                    "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                    "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };

            // Create a query that groups websites by top-level domain name,
            // but select only those groups that have more than two members.
            // Here, ws is the range variable over the set of groups
            // returned when the first half of the query is executed.
            var webAddrs = from addr in websites
                           where addr.LastIndexOf('.') != -1
                           group addr by addr.Substring(addr.LastIndexOf('.'))
                           into ws
                           where ws.Count() > 2
                           select ws;
           

            // Execute the query and display the results.
            Console.WriteLine("Top-level domains with more than 2 members.\n");
            foreach (var sites in webAddrs)
            {
                Console.WriteLine("Contents of " + sites.Key + " domain:");
                foreach (var site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}
