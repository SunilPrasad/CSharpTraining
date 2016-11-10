using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();

            genericList.AddNode(10);
            genericList.AddNode(20);
            genericList.AddNode(30);

            genericList.PrintAllNodes();
        }
    }

    public class GenericList<T>
    {
        private class Node
        {
            // Each node has a reference to the next node in the list.
            public Node Next;
            // Each node holds a value of type T.
            public T Data;
        }

        // The list is initially empty.
        private Node head = null;
        private Node currentNode = null;

        // Add a node at the beginning of the list with t as its data value.
        public void AddNode(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                currentNode.Next = newNode;
            }

            currentNode = newNode;
           
        }
        
        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            
        }
    }

}
