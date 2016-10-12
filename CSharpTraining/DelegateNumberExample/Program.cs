using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNumberExample
{
    class Program
    {
        public delegate bool Filter(int numbers);
        public static bool GreaterThanFive(int n) { return n > 5; }
        public static bool EvenNumber(int n) { if (n%2 == 0) return true; return false; }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            

            foreach (var num in FilterNumber(numbers,EvenNumber))
                Console.WriteLine(num);
        }

        static IEnumerable<int> FilterNumber(IEnumerable<int> numbers,Filter filter)
        {
            foreach(var number in numbers)
            {
                if ((filter(number)))
                    yield return number;
            }
        }
    }

    
}
