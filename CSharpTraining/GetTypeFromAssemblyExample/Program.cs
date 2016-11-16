using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTypeFromAssemblyExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class AnotherClass
    {
        string msg;
        public AnotherClass(string str)
        {
            msg = str;
        }
        public void Show()
        {
            Console.WriteLine(msg);
        }
    }

    class MyClass
    {
        int x;
        int y;

        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if ((x < i) && (i < y)) return true;
            else return false;
        }

        public void Set(int a, int b)
        {
            Console.Write("Inside Set(int, int). ");
            x = a;
            y = b;
            Show();
        }

        // Overload set.
        public void Set(double a, double b)
        {
            Console.Write("Inside Set(double, double). ");
            x = (int)a;
            y = (int)b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Values are x: {0}, y: {1}", x, y);
        }
    }

}
