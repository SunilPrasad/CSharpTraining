using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                B b = new B();

            }
            catch (Exception ex)
            {

            }

            B.Foo();
            
        }
    }

    internal class A
    {
        public A()
        {
            Console.WriteLine("Ctor A");
        }
        static A()
        {
            Console.WriteLine("A");
        }
    }

    internal class B : A
    {
        public B()
        {
            
            Console.WriteLine("Ctor B");
        }
        static B()
        {
            throw new Exception();
            Console.WriteLine("B");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
}
