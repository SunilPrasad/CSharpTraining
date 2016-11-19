using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace ThreadLockExample
{
    class Program
    {
        private static int total;
        private static int[] inputs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static void Main()
        {
            Thread[] threadArray = new Thread[10];

            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i] = new Thread(ThreadUnsafe.Go);
                threadArray[i].Start();
               // threadArray[i].Join();
            }

            Console.WriteLine(total);

        }

        public static void Sum()
        {
            Console.WriteLine("Runnning thread {0}",Thread.CurrentThread.ManagedThreadId);

            foreach (var input in inputs)
            {
                total = total + input;
                Thread.Sleep(10);
            }
        }

    }

    public class ThreadUnsafe
    {
        static int val1, val2;

        public static void Go()
        {
            Console.WriteLine("Runnning thread {0}", Thread.CurrentThread.ManagedThreadId);

            if (val2 != 0) Console.WriteLine(val1 / val2);
            val2 = 0;
        }
    }

}

    
