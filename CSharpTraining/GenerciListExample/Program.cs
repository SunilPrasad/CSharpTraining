using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerciListExample
{
    class Program
    {
        static void Main(string[] args)
        {


            int minValue = Min<int>(10, 20);

        }

        private static Boolean MethodTakingAnyType<T>(T o)
        {
            T temp = o;

            Console.WriteLine(o.ToString());

            Boolean b = temp.Equals(o);

            return b;
        }

        private static T Min<T>(T o1, T o2) where T : IComparable<T>
        {
            if (o1.CompareTo(o2) < 0) return o1;
            return o2;
        }
    }
   
}
