using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadPerformanceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("Number.txt");

            var text = sr.ReadToEnd();

            sr.Close();

            var numbers = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

          

            //Thread thread = new Thread((() => AddNumbers(numbers)));
            //thread.Start();

            //Thread threadOne = new Thread((() => AddNumberOne(numbers)));
            //threadOne.Start();

            //thread.Join();
            //thread.Join();

            AddNumbers(numbers);

        }

       

        private static void AddNumbers(string[] numbers)
        {

            Stopwatch stopwat = new Stopwatch();

            BigInteger bigInteger = 0;

            stopwat.Start();

            for (int i = 0; i < 10000000; i++)
            {
                bigInteger += Convert.ToInt32(numbers[0]);
            }

            stopwat.Stop();

            Console.WriteLine(stopwat.ElapsedMilliseconds);
            Console.WriteLine(bigInteger);
        }

        private static void AddNumberOne(string[] numbers)
        {
            Stopwatch stopwat = new Stopwatch();

            BigInteger bigInteger = 0;

            stopwat.Start();

            for (int i = 5000000; i < 10000000; i++)
            {
                bigInteger += Convert.ToInt32(numbers[i]);
            }

            stopwat.Stop();

            Console.WriteLine(stopwat.ElapsedMilliseconds);
            Console.WriteLine(bigInteger);
        }

        private static void CreatNumberFile()
        {
            StringBuilder stringBuilder = new StringBuilder(10000000);
            Random randomNumber = new Random();

            for (int i = 0; i < 10000000; i++)
            {
                stringBuilder.Append(randomNumber.Next());
                stringBuilder.Append(",");
            }

            StreamWriter streamWriter = new StreamWriter("Number.txt");

            streamWriter.Write(stringBuilder.ToString());

            streamWriter.Close();
        }
    }
}
