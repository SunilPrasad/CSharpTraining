using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPerformance
{
    class Program
    {
        public static double sum(double[] d, int l1)
        {
            // assuming the array is rectangular
            double sum = 0;
            int l2 = d.Length / l1;
            for (int i = 0; i < l1; ++i)
                for (int j = 0; j < l2; ++j)
                    sum += d[i * l2 + j];
            return sum;
        }

        public static double sum(double[,] d)
        {
            double sum = 0;
            int l1 = d.GetLength(0);
            int l2 = d.GetLength(1);
            for (int i = 0; i < l1; ++i)
                for (int j = 0; j < l2; ++j)
                    sum += d[i, j];
            return sum;
        }

        public static double sum(double[][] d)
        {
            double sum = 0;
            for (int i = 0; i < d.Length; ++i)
                for (int j = 0; j < d[i].Length; ++j)
                    sum += d[i][j];
            return sum;
        }

        public static void Main()
        {
            Random random = new Random();
            const int l1 = 1024, l2 = 1024;

            double[] d1 = new double[l1 * l2];
            double[,] d2 = new double[l1, l2];
            double[][] d3 = new double[l1][];

            

            for (int i = 0; i < l1; ++i)
            {
                d3[i] = new double[l2];
                for (int j = 0; j < l2; ++j)
                    d3[i][j] = d2[i, j] = d1[i * l2 + j] = random.NextDouble();
            }
            //
            const int iterations = 1000;
            TestTime(sum, d1, l1, iterations);
            TestTime(sum, d2, iterations);
            TestTime(sum, d3, iterations);


            TestTime(sum, d1, l1, iterations);
            TestTime(sum, d2, iterations);
            TestTime(sum, d3, iterations);
        }

        public static void TestTime<T, TR>(Func<T, TR> action, T obj,
                                   int iterations)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; ++i)
                action(obj);
            Console.WriteLine(action.Method.Name + " took " + stopwatch.Elapsed);
        }

        public static void TestTime<T1, T2, TR>(Func<T1, T2, TR> action, T1 obj1,
                                                T2 obj2, int iterations)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; ++i)
                action(obj1, obj2);
            Console.WriteLine(action.Method.Name + " took " + stopwatch.Elapsed);
        }
    }
}
