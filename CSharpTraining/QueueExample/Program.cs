using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    //Queue represents a collection with First-In-First-Out (FIFO) behaviour. 
    //We use queues in situations where we need to process items as they arrive.
//    Three main operations on queue include:

//Enqueue: adding an element to the end of a queue
//Dequeue: removing the element at the front of the queue
//Peek: inspecting the element at the front without removing it.

    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            // Add an item to the queue
            queue.Enqueue("transaction1");

            // Check to see if the queue contains a given item 
            var contains = queue.Contains("transaction1");

            // Remove and return the item on the front of the queue
            var front = queue.Dequeue();

            // Return the item on the front without removing it 
            var top = queue.Peek();

            // Remove all items from queue 
            queue.Clear();

            // Get the number of items in the queue
            var count = queue.Count;
        }
    }
}
