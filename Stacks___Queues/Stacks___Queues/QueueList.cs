using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks___Queues
{
    public class QNode
    {
        public int data;
        public QNode next;
    }
    public class QueueList
    {
        public QNode top;
        public QueueList()
        {
            this.top = null;
        }
        public bool IsEmpty()
        {
            if(this.top == null)
            {
                return true;
            }
            else
            return false;
        }
        public void Enqueue(int data)
        {
            QNode qNode = new QNode();
            qNode.data = data;
            if(IsEmpty() == true)
            {
                this.top = qNode;
                qNode.next = null;
            }
            else
            {
                QNode qNode1 = top;
                while(qNode1.next != null)
                {
                    qNode1 = qNode1.next;
                }
                qNode1.next = qNode;
            }
            Console.WriteLine("elements are"+qNode.data);
        }
        public void QShow()
        {
            QNode qNode = this.top;
            if(IsEmpty() == true)
            {
                Console.WriteLine("the Queue is empty");
            }
            while(qNode != null)
            {
                Console.WriteLine(qNode.data);
                qNode = qNode.next;
            }
        }
        public int Size()
        {
            int count = 0;
            QNode qNode = this.top;
            while(qNode != null)
            {
                count++;
                qNode = qNode.next;
            }
            Console.WriteLine("count is"+count);
            return count;
        }
        public void Dequque()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Queue empty!!");
            }
            if (Size() == 1)
            {
                Console.WriteLine($"Dequeued element:"+top.data);
                this.top = null;
            }
            if (Size() > 1)
            {
                QNode n = this.top;
                this.top = n.next;
                Console.WriteLine($"Dequeued element:"+n.data);
            }
        }

    }
}
