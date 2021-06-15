using System;

namespace Stacks___Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to stack and queue problems");
            StackList list = new StackList();
            list.Push(56);
            list.Push(30);
            list.Push(70);
            Console.WriteLine("elements are");
            list.Show();
        }
    }
}
