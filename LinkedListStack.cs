using System;
using System.Collections.Generic;
using System.Text;

namespace StacksandQueues
{
    class LinkedListStack
    {
        public Node top;

        public LinkedListStack()
        {
            top = null;
        }
        public void push(int value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;

        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
        }
    }
}