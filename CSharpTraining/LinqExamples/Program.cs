using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            FilterValuesWithWhere();
        }


        //Filter Values with where
        public static void FilterValuesWithWhere()
        {
            int[] nums = { 1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10 };
            // Create a query that obtains positive values less than 10.
            

            var posNums = from n in nums
                          where n > 0 && n < 10
                          select n;

            Console.Write("The positive values less than 10: ");
            // Execute the query and display the results.
            foreach (int i in posNums) Console.Write(i + " ");
            Console.WriteLine();
        }

        //Sort Results with orderby
        public static void SortResultswithorderby()
        {
            int[] nums = { 10, -19, 4, 7, 2, -5, 0 };
            // Create a query that obtains the values in sorted order.
            var posNums = from n in nums
                          orderby n
                          select n;
            Console.Write("Values in ascending order: ");
            // Execute the query and display the results.
            foreach (int i in posNums) Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void OrderByOnMutipleCriteria()
        {
            //var accInfo = from acc in accounts
            //              orderby acc.LastName, acc.FirstName, acc.Balance
            //              select acc;
        }

    }


}
