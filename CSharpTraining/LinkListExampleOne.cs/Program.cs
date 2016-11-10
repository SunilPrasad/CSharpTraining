using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListExampleOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Create a new linked list.
            //
            LinkedList<string> linked = new LinkedList<string>();
            //
            // First add three elements to the linked list.
            //

            
            linked.AddLast("one");

            linked.AddLast("two");

            linked.AddLast("three");

            var node = linked.Find("two");

            linked.AddAfter(node, "Three");


        }
    }
}
