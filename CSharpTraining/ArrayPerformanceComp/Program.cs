using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPerformanceComp
{
    class Program
    {
        static int NumRows = 2736;
        static int NumCols = 10944;

        private static int SimpleSum;

        static byte[,] rectArray = new byte[NumRows, NumCols];
        static byte[][] jaggedArray = new byte[NumRows][];

        static void Main(string[] args)
        {
            InitSumRect(rectArray, NumRows, NumCols);
            InitSumJagged(jaggedArray, NumRows, NumCols);

            Test(() => SimpleSumRect(rectArray, NumRows, NumCols), "Simple Sum rect", 10);
            Test(() => SimpleSumJagged(jaggedArray, NumRows, NumCols), "Simple Sum jagged", 10);

        }

        private static void InitSumRect(byte[,] array, int rows, int cols)
        {
            for (var i = 0; i < rows; ++i)
            {
                for (var j = 0; j < cols; ++j)
                {
                    array[i, j] = 1;
                }
            }
        }

        private static void InitSumJagged(byte[][] array, int rows, int cols)
        {
            for (var i = 0; i < rows; ++i)
            {
                array[i] = new byte[cols];

                for (var j = 0; j < cols; ++j)
                {
                    jaggedArray[i][j] = 1;
                }
            }
        }

        private static void SimpleSumRect(byte[,] array, int rows, int cols)
        {
            SimpleSum = 0;
            for (var i = 0; i < rows; ++i)
            {
                for (var j = 0; j < cols; ++j)
                {
                    SimpleSum += array[i, j];
                }
            }
        }

        private static void SimpleSumJagged(byte[][] array, int rows, int cols)
        {
            SimpleSum = 0;
            for (var i = 0; i < rows; ++i)
            {
                for (var j = 0; j < cols; ++j)
                {
                    SimpleSum += array[i][j];
                }
            }
        }


        private static void OptimizedTraversalRect(byte[,] array, int rows, int cols)
        {
            long count = (((long)rows) * cols) / 3;
            unsafe
            {
                fixed (byte* pArray = array)
                {
                    byte* p = pArray;
                    while (count-- > 0)
                    {
                        *p++ = (byte)(255 - *p);
                        *p++ = (byte)(255 - *p);
                        *p++ = (byte)(255 - *p);
                    }
                }
            }
        }

        private static void OptimizedTraversalJagged(byte[][] array, int rows, int cols)
        {
            for (var i = 0; i < rows; ++i)
            {
                unsafe
                {
                    int count = cols / 3;
                    fixed (byte* pArray = array[i])
                    {
                        byte* p = pArray;
                        while (count-- > 0)
                        {
                            *p++ = (byte)(255 - *p);
                            *p++ = (byte)(255 - *p);
                            *p++ = (byte)(255 - *p);
                        }
                    }
                }
            }
        }
        private static void Test(Action a, string text, int numIterations)
        {
            Console.Write("{0} ... ", text);
            // do it once to eliminate JIT effects
            a();

            // Now time the iterations.
            var sw = Stopwatch.StartNew();
            for (var i = 0; i < numIterations; ++i)
            {
                a();
            }
            sw.Stop();
            Console.WriteLine("{0:N0} ms", sw.ElapsedMilliseconds / numIterations);
        }
    }
}
