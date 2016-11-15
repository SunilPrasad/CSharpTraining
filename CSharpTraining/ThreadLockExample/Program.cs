using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLockExample
{
    class Program
    {
        public static int sum = 0;
        static void Main(string[] args)
        {
            Thread threadOne = new Thread(Add);
            Thread threadTwo = new Thread(Subtract);
            Thread threadTThree = new Thread(Add);
            Thread threadTThree1 = new Thread(Add);


            threadOne.Start();
            threadTwo.Start();
            //threadTThree.Start();
            //threadTThree1.Start();

            Console.ReadLine();

            Console.WriteLine(sum);
        }

        private static void  Add()
        {
            for (int i = 0; i < 500; i++)
            {
                sum = sum + 1;
                sum = sum + 1;
            }
        }

        private static void Subtract()
        {
            for (int i = 0; i < 500; i++)
            {
                sum = sum - 1;
                sum = sum - 1;
            }
        }
    }
}
