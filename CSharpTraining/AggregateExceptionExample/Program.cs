using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task taskOne = new Task(() =>
            {
                try
                {
                    DoSomeWork();
                }
                catch (AggregateException aggregateException)
                {
                    aggregateException.Handle(ex => {
                        if (ex is ArgumentOutOfRangeException)
                            Console.WriteLine(ex.Message);
                        return false;
                    });
                }

            });


            Task taskTwo = new Task(() => { throw new InvalidCastException(); });

            try
            {
                taskOne.Start();
                taskTwo.Start();

                Task.WaitAll(new Task[] { taskOne, taskTwo });
            }
            catch (AggregateException exception)
            {
                var flatEx = exception.Flatten();

                foreach (var exceptionInnerException in flatEx.InnerExceptions)
                {
                    Console.WriteLine(exceptionInnerException.GetType());
                }

            }
        }

        private static void DoSomeWork()
        {
            Task taskThree = new Task(() => { throw new ArgumentOutOfRangeException(); });
            Task taskFour = new Task(() => { throw new AccessViolationException(); });

            taskThree.Start();
            taskFour.Start();

            Task.WaitAll(new Task[] {taskThree, taskFour});
        }
    }
}
