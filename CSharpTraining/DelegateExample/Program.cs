using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate calulate = new Calculate(ReturnSum);
            calulate += ReturnMultiplication;

            Console.WriteLine(calulate(23, 45));

            var funcList = calulate.GetInvocationList();
            
            foreach(Delegate func in funcList)
            {
                Console.WriteLine(func.DynamicInvoke(23, 45));
            }
        }

        private static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        private static void Multiplication(int x, int y)
        {            
            Console.WriteLine(x * y);
        }

        private static int ReturnSum(int x, int y)
        {
            return x + y;
           // Console.WriteLine(x + y);
        }

        private static int ReturnMultiplication(int x, int y)
        {
            return x * y;
           // Console.WriteLine(x * y);
        }

        private void CallBackMethod(Delegate delegateexample)
        {

        }
    }

  
}
