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

    }
}
