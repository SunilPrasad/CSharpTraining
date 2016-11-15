using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task<Int32> t = new Task<Int32>(n => Sum((Int32)n), 10000);
            
            t.Start();
            
            t.Wait(); 

            Console.WriteLine("The Sum is: " + t.Result); // An Int32 value

        }

        private static Int32 Sum(Int32 n)
        {
            Int32 sum = 0;
            for (; n > 0; n--)
                checked { sum += n; } // if n is large, this will throw System.OverflowException
            return sum;
        }
    }
}
