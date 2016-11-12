using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int[] nums = {1, 2, 3, 4, 50, 6, 7, 18, 9, 10};

            var evenNums = 
                from  n in nums
                orderby n
                select n;



            foreach (var evenNum in evenNums)
            {
                Console.WriteLine(evenNum);
            }
            
        }
    }
    
}
