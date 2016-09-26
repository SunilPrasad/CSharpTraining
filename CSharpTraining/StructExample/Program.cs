using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 1;
            p.y = 2;

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 2;

            Console.WriteLine(p.Equals(p1));

            
            
        }
    }
    public class Student
    {
        public string Name = "Test";
    }

    public struct Point
    {
        public int x;
        public int y;
    }
}
