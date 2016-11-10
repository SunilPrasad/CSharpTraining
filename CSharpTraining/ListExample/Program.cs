using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listofInt = new List<int>(10);

            Console.WriteLine(listofInt.Capacity);

            listofInt.Add(12);

            Console.WriteLine(listofInt.Capacity);


            for (int i = 0; i < 10; i++)
            {
                listofInt.Add(10);

                Console.WriteLine(listofInt.Capacity);
            }
        }
    }
}
