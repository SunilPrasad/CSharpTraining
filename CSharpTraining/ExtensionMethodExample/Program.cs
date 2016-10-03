using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";

            string reversedCaseString = str.RevCase();

            Console.WriteLine(reversedCaseString);

        }
    }


    public static class StringUtil
    {
        // Reverse the case of letters within a string and
        // return the result.
        public static string RevCase(this string str)
        {
            string temp = "";
            foreach (char ch in str)
            {
                if (Char.IsLower(ch)) temp += Char.ToUpper(ch);
                else temp += Char.ToLower(ch);
            }
            return temp;
        }

    }
}

