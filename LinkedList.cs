using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_LinkedList
{
    public class LinkedList
    {
        Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;

            }
            Console.WriteLine("{0} inserted into the linkedlist", node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The List is empty");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Linked List Contains: ");
                Console.ResetColor();
                Node tempnode = head;
                while (tempnode != null)
                {
                    Console.Write(tempnode.data + " ");
                    tempnode = tempnode.Next;
                }
            }
            Console.WriteLine("\n");
        }
    }
}
