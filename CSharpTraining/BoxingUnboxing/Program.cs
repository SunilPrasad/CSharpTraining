using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    public sealed class Program
    {
        public static void Main()
        {
            ArrayList a = new ArrayList();
            Point p; // Allocate a Point (not in the heap).
            for (Int32 i = 0; i < 10; i++)
            {
                p.x = p.y = i; // Initialize the members in the value type.
                a.Add(p); // Box the value type and add the
                          // reference to the Arraylist.
            }
        }
    }

    struct Point
    {
        public Int32 x, y;
    }
}
