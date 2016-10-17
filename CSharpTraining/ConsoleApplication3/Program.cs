using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {  
             

        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12 };


            Console.WriteLine("Printing odd numbers");

            foreach (var num in FilterNumber(intArray,isNumberOdd))
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("Printing even numbers");

            foreach (var num in FilterNumber(intArray, isNumberEven))
            {
                Console.WriteLine(num);
            }

        }


        private static bool isNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        private static bool isNumberEven(int num)
        {
            return num % 2 == 0;
        }



        private static List<int> FilterNumber(int[] inputs,Func<int,bool> filter)
        {
            List<int> intList = new List<int>();

            Console.WriteLine(filter.Method.Name);

            foreach(var num in inputs)
            {
                if (filter(num))
                    intList.Add(num);
            }

            return intList;
        }
    
    }

}
