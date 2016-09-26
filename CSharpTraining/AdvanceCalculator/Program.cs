using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter secret password : ");
            if (Console.ReadLine() == "secret")
            {
                Console.WriteLine("You got the secret message");
            }
            else
            {
                Console.WriteLine("No Access");
            }
            Console.ReadLine();
        }
    }
}
