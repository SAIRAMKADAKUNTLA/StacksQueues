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
            list.Pop();
            Console.WriteLine("after pop");
            list.Show();
            list.Peek();
            Console.WriteLine("after peek");
            list.Show();
            list.Size();
            QueueList list1 = new QueueList();
            list1.Enqueue(56);
            list1.Enqueue(30);
            list1.Enqueue(70);
            Console.WriteLine("elements are");
            list1.QShow();
        }
    }
}
