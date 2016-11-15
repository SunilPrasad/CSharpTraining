using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolThreadMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             GetMaxThreads, SetMaxThreads,
GetMinThreads, SetMinThreads, and GetAvailableThreads
             */

            int maxWorkerThread;
            int asynIOThread;
            ThreadPool.GetMaxThreads(out maxWorkerThread, out asynIOThread);

            Console.WriteLine($"{maxWorkerThread},{asynIOThread}");

            Task.Run(() => Thread.Sleep(10000));
            Task.Run(() => Thread.Sleep(10000));
            Task.Run(() => Thread.Sleep(10000));
            Task.Run(() => Thread.Sleep(10000));
            Task.Run(() => Thread.Sleep(10000));

            ThreadPool.GetAvailableThreads(out maxWorkerThread, out asynIOThread);

            Console.WriteLine($"{maxWorkerThread},{asynIOThread}");
        }
    }
}
