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
            
            //
            // Insert a node before the second node (after the first node)
            //
            LinkedListNode<string> node = linked.Find("one");
            linked.AddAfter(node, "inserted");
            //
            // Loop through the linked list.
            //
            foreach (var value in linked)
            {
                Console.WriteLine(value);
            }
        }
    }
}
