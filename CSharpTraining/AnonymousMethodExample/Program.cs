﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodExample
{
    class Test
    {
        delegate void TestDelegate(string s);
        delegate void DelegateWithouParameter();

        static void M(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            // Original delegate syntax required 
            // initialization with a named method.
            TestDelegate testDelA = new TestDelegate(M);

            
            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };            

            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };

            // Invoke the delegates.
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");

            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            DelegateWithouParameter delegateWithouParameter = delegate { Console.WriteLine("Hello"); };
        }

        static void AnotherExample()
        {
            List<int> values = new List<int>() { 1, 1, 1, 2, 3 };

            // This syntax enables you to embed multiple statements in an anonymous function.
            List<int> res = values.FindAll(delegate (int element)
            {
                if (element > 10)
                {
                    throw new ArgumentException("element");
                }
                if (element == 8)
                {
                    throw new ArgumentException("element");
                }
                return element > 1;
            });

            // Display results.
            foreach (int val in res)
            {
                Console.WriteLine(val);
            }
        }

        static void ExampleOne()
        {
            Func<int, bool> myFunc = x => x == 5;

            Action<int> myAction = x => { bool a = x == 5; };

            Func<int, bool> myFuncOne = delegate(int x) { return x==5; };

            bool result = myFunc(4);

        }
    }
}
