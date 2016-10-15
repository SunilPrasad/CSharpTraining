using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateSyntax
{
    class Program
    {
        public delegate void Test(int i);

        static void Main(string[] args)
        {
            AClass.CallbackWithoutNewingADelegateObject();
            Console.ReadLine();

            Test t = new Test(TestDelegateMethod);

            MyMethod(TestDelegateMethod,5);

            MyMethod(x => Console.WriteLine(x), 5);
        }


        static void MyMethod(Test test,int i)
        {
            test(i);
        }

        static void TestDelegateMethod(int  i)
        {

        }
    }

    internal sealed class AClass
    {
        public static void CallbackWithoutNewingADelegateObject()
        {            
            ThreadPool.QueueUserWorkItem(SomeAsyncTask, 5);
        }
        private static void SomeAsyncTask(object o)
        {
            Console.WriteLine(o);
        }
    }
}
