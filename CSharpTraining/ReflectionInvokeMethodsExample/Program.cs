using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionInvokeMethodsExample
{
    class InvokeMethDemo
    {
        static void Main()
        {
            Type t = typeof(MyClass);
            MyClass reflectOb = new MyClass(10, 20);

            int val;
            Console.WriteLine("Invoking methods in " + t.Name);
            Console.WriteLine();

            MethodInfo[] mi = t.GetMethods();
            // Invoke each method.
            foreach (MethodInfo m in mi)
            {
                // Get the parameters.
                ParameterInfo[] pi = m.GetParameters();
                if (m.Name.Equals("Set", StringComparison.Ordinal) &&
                    pi[0].ParameterType == typeof(int))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.Equals("Set", StringComparison.Ordinal) &&
                         pi[0].ParameterType == typeof(double))
                {
                    object[] args = new object[2];
                    args[0] = 1.12;
                    args[1] = 23.4;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.Equals("Sum", StringComparison.Ordinal))
                {
                    val = (int) m.Invoke(reflectOb, null);
                    Console.WriteLine("sum is " + val);
                }
                else if (m.Name.Equals("Show", StringComparison.Ordinal))
                {
                    m.Invoke(reflectOb, null);
                }
            }
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
            x = (int) a;
            y = (int) b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Values are x: {0}, y: {1}", x, y);
        }
    }
}

