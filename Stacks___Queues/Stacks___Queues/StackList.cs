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
    }
}
