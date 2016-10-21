using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://msdn.microsoft.com/en-us/library/bb545971.aspx

namespace GroupByExamples
{
    public class Program
    {
        public static void Main()
        {
            StudentClass sc = new StudentClass();
            sc.QueryHighScores(1, 90);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        
    }
}
