using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks___Queues
{
    public class Node
    {
        public int data;
        public Node next;
    }
    public class StackList
    {
        public Node top;
        public StackList()
        {
            this.top = null;
        }
        public bool isEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }
        public void Push(int data)
        {
            Node node = new Node();
            node.data = data;
            if(isEmpty() == true)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("elements are"+node.data);
        }
        public void Show()
        {
            Node node = this.top;
            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void Pop()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("No elements to remove.");
            }
            if (this.top != null)
            {
                Console.WriteLine($"popped element: "+this.top.data);
                this.top = this.top.next;
            }
        }
        public void Peek()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine($"top element:" +this.top.data);
            }
        }
        public int Size()
        {
            int count = 0;
            Node n = top;
            while (n != null)
            {
                count++;
                n = n.next;
            }
            Console.WriteLine($"size of stack:"+count);
            return count;
        }
    }
}
