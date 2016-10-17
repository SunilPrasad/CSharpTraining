using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Point[][] myPolygons = new Point[3][];

            // myPolygons[0] refers to an array of 10 Point instances.
            myPolygons[0] = new Point[10];

            // myPolygons[1] refers to an array of 20 Point instances.
            myPolygons[1] = new Point[20];

            // myPolygons[2] refers to an array of 30 Point instances.
            myPolygons[2] = new Point[30];
            

            // Display the Points in the first polygon.
            for (Int32 x = 0; x < myPolygons[0].Length; x++)
                Console.WriteLine(myPolygons[0][x]);


        }

    }
    
    public class Point
    {
        public int X;
        public int Y;
    }   
    
}
