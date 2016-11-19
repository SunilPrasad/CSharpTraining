using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterlockAddExample
{
    class Program
    {
        static int _value;

        static void Main()
        {
            var currentProcess = Process.GetCurrentProcess();
            foreach (ProcessThread pt in currentProcess.Threads)
            {
                pt.IdealProcessor = 0;
                pt.ProcessorAffinity = (IntPtr)1;
            }

            Thread thread1 = new Thread(new ThreadStart(A));
            Thread thread2 = new Thread(new ThreadStart(A));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine(Program._value);


            Thread[] threadArray = new Thread[1000];

            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i] = new Thread(A);
                threadArray[i].Start();
                threadArray[i].Join();
            }

            Console.WriteLine(Program._value);
        }

        static void A()
        {
            // Add one.

            Program._value = Program._value + 1;
           

            //   Interlocked.Add(ref Program._value, 1);
        }
    }
}

