using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample.cs
{
    class Program
    {
        //Stack is a collection type with Last-In-First-Out (LIFO) behaviour

        // Think of your browser.As you navigate to different web sites, these addresses that you visit are 
        //pushed on a stack. Then, when you click the back button, the item on the stack 
        //(which represents the current address in the browser) is popped and now we can get the 
        //last address you visited from the item on the stack.The undo feature in applications is implemented using a stack as well.


        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            // Push items in a stack
            stack.Push("http://www.google.com");

            // Check to see if the stack contains a given item 
            var contains = stack.Contains("http://www.google.com");

            // Remove and return the item on the top of the stack
            var top = stack.Pop();

            // Return the item on the top of the stack without removing it 
            top = stack.Peek();

            // Get the number of items in stack 
            var count = stack.Count;

            // Remove all items from stack 
            stack.Clear();

        }
    }
}
