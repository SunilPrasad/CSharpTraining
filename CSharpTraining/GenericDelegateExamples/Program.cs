using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateExamples
{
    class Program
    {
        public delegate void Notify<T>(T data);

        static void Main(string[] args)
        {
            Notify<int> not = NotifyInt;
            not(12);

            Notify<string> notStr = NotifyStr;
            notStr("stringValue");
        }

        public static void NotifyInt(int i)
        {
            Console.WriteLine(i);
        }

        public static void NotifyStr(string str)
        {
            Console.WriteLine(str);
        }
    }
}
