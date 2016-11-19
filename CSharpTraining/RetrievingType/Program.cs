using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrievingType
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] values = { "word", true, 120, 136.34, 'a',new Employee() };


            foreach (var value in values)
                Console.WriteLine("{0} - type {1}", value,value.GetType().Name);
        }
    }

    public class Employee
    {
        
    }
}
