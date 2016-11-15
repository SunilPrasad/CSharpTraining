using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExceptionExample
{
    using System;
    using System.Threading.Tasks;

    public class Example
    {
        public static void Main()
        {
            var task1 = Task.Run(() => { throw new CustomException("This exception is expected!"); });

            while (!task1.IsCompleted) { }

            if (task1.Status == TaskStatus.Faulted)
            {
                if (task1.Exception != null)
                    foreach (var e in task1.Exception.InnerExceptions)
                    {
                        // Handle the custom exception.
                        if (e is CustomException)
                        {
                            Console.WriteLine(e.Message);
                        }
                        // Rethrow any other exception.
                        else
                        {
                            throw e;
                        }
                    }
            }
        }
    }

    public class CustomException : Exception
    {
        public CustomException(String message) : base(message)
        { }
    }
}
