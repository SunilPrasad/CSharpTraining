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
            List<int> listofInt = new List<int>();

            for(int i=0;i<10;i++)
            {
                listofInt.Add(10);
                listofInt.Add(10);
                listofInt.Add(10);
                listofInt.Add(10);

                Console.WriteLine(listofInt.Capacity);
            }          
        }
    }
}
