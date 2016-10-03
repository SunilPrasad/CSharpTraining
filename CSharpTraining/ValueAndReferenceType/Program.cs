using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            string intString = "10S";
            int result;

            int.TryParse(intString, out result);


            Console.WriteLine(result);




            int a = 10;
            int b = 20;

            DoubleInt(out a, out b);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

        }

        private static void DoubleInt(out int a, out int b)
        {
            //a = 20;
            //b = 20;

            a += a;
            b += b;

            //inside method
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
