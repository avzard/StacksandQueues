using System;

namespace StacksandQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListStack");
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            Console.ReadLine();
        }
    }
}