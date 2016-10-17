using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 8, 4, 5, 1, 7, 0, 9, 3 };

            var resultNums = from int n in nums where n > 5 select n;

            var posNums = from n in nums
                          orderby n descending
                          where n > 5
                          select n;

            foreach (var resultNum in posNums)
            {
                Console.WriteLine(resultNum);
            }


           
          
        }
    }
}
