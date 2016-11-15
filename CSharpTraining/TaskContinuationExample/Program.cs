using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskContinuationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and start a Task, continue with another task
            Task<Int32> t = Task.Run(() => Sum(1000));
            // ContinueWith returns a Task but you usually don't care
            Task cwt = t.ContinueWith(AnotherTask);
        }

        private static void AnotherTask(Task<int> task)
        {
            Console.WriteLine(task.Result);
        }

        private static Int32 Sum(Int32 n)
        {
            Int32 sum = 0;
            for (; n > 0; n--)
                checked { sum += n; } // if n is large, this will throw System.OverflowException
            return sum;
        }
    }
}
