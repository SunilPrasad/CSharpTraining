using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBound
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the instance of an Array   
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 2011 });

            
            // Set the values to array  
            myArray.SetValue(5, 2011);
            myArray.SetValue(6, 2012);
            myArray.SetValue(7, 2013);
            myArray.SetValue(8, 2014);

            // Display the lower bound of the array  
            Console.WriteLine(myArray.GetLowerBound(0));

            // Display the upper bound of the array  
            Console.WriteLine(myArray.GetUpperBound(0));

            // Display all the items in the array  
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {

                Console.WriteLine(myArray.GetValue(i));
            }
        }
    }
}
