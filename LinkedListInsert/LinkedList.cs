using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsert
{

    public class LinkedList
    {
        public Node head;

        public void add(int data)
        {
            Node node = new Node(data);
            node.data = data;

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }

        }

        public void AddBTW(int index, int data)
        {
            Node node = new Node(data);
            node.data = data;

            Node temp = head;
            for (int i = 0; i < index - 1; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;

        }
        public void show()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
    }
    
}

