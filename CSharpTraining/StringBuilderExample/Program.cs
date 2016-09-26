using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            
            Console.WriteLine(sb.Capacity);
            sb.Append("121212121212121212");
            Console.WriteLine(sb.Capacity);
            sb.Append("121212121212121212121212121212121212121212121212121212");
            Console.WriteLine(sb.Capacity);

            Console.WriteLine(sb.MaxCapacity);

            

            Console.WriteLine(sb.ToString());
        }
    }
}
