using System;
using System.Diagnostics;
using System.Threading;
using Timers = System.Timers;

namespace ThreadPriorityExample
{
    class Test
    {
        static void Main()
        {
            using (Process p = Process.GetCurrentProcess())
                p.PriorityClass = ProcessPriorityClass.High;

            PriorityTest priorityTest = new PriorityTest();

            Thread thread1 = new Thread(priorityTest.ThreadMethod);
            thread1.Name = "ThreadOne";
            thread1.Priority=ThreadPriority.Highest;

            Thread thread2 = new Thread(priorityTest.ThreadMethod);
            thread2.Name = "ThreadTwo";
            thread2.Priority = ThreadPriority.Lowest;

            Thread thread3 = new Thread(priorityTest.ThreadMethod);
            thread3.Name = "ThreadThree";
            thread3.Priority = ThreadPriority.BelowNormal;

            thread1.Start();
            thread2.Start();
            thread3.Start();
            // Allow counting for 10 seconds.
            Thread.Sleep(10000);
            priorityTest.LoopSwitch = false;
        }
    }

    class PriorityTest
    {
        static bool loopSwitch;
        [ThreadStatic]
        static long threadCount = 0;

        public PriorityTest()
        {
            loopSwitch = true;
        }

        public bool LoopSwitch
        {
            set { loopSwitch = value; }
        }

        public void ThreadMethod()
        {
            while (loopSwitch)
            {
                threadCount++;
            }
            Console.WriteLine("{0,-11} with {1,11} priority " +
                "has a count = {2,13}", Thread.CurrentThread.Name,
                Thread.CurrentThread.Priority.ToString(),
                threadCount.ToString("N0"));
        }
    }
    
}
