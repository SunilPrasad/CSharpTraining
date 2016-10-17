using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // i is compiled as an int
            var i = 5;

            // s is compiled as a string
            var s = "Hello";

            // a is compiled as int[]
            var a = new[] { 0, 1, 2 };

            // anon is compiled as an anonymous type
            var anon = new { Name = "Terry", Age = 34 };

            

            // list is compiled as List<int>                             
            var list = new List<int>();
        }

        public static void VarWithAnonymousypes()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            // If a query produces a sequence of anonymous types, 
            // then use var in the foreach statement to access the properties.
            var upperLowerWords =
                 from w in words
                 select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            // Execute the query
            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }
        }
       
    }
}
