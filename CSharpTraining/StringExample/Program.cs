using System;
using System.Collections.Generic;
using System.Text;



[assembly: System.Runtime.CompilerServices.CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations.NoStringInterning)]
namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "Hello";
            String s2 = "Hello";
            Console.WriteLine(Object.ReferenceEquals(s1, s2));
            s1 = String.Intern(s1);
            s2 = String.Intern(s2);
            Console.WriteLine(Object.ReferenceEquals(s1, s2));

        }

        private static Int32 NumTimesWordAppearsEquals(String word, String[] wordlist)
        {
            Int32 count = 0;
            for (Int32 wordnum = 0; wordnum < wordlist.Length; wordnum++)
            {
                if (word.Equals(wordlist[wordnum], StringComparison.Ordinal))
                    count++;
            }
            return count;
        }

        private static Int32 NumTimesWordAppearsIntern(String word, String[] wordlist)
        {
            // This method assumes that all entries in wordlist refer to interned strings.
            word = String.Intern(word);
            Int32 count = 0;
            for (Int32 wordnum = 0; wordnum < wordlist.Length; wordnum++)
            {
                if (Object.ReferenceEquals(word, wordlist[wordnum]))
                    count++;
            }
            return count;
        }

       
    }
}
