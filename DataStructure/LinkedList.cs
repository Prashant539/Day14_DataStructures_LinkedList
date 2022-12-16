﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int id)
        {
            Node node = new Node(id);

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
                    temp.next = node;
                }
            }
           Console.WriteLine("{0} is inserted int Linked List", node.id);
        }
    }
}
