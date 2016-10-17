using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chrs = { 'A', 'B', 'C' };
            char[] chrs2 = { 'X', 'Y', 'Z' };

            var pairs = from ch1 in chrs
                        from ch2 in chrs2
                        select new { First = ch1, Second = ch2 };

            foreach(var p in pairs)
            {
                Console.WriteLine($"{p.First } { p.Second}");
            }
        }
    }
}
