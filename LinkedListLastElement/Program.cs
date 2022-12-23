using System;
using System.Collections.Generic;

namespace LinkedListLastElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Operations");
            LinkedList list = new LinkedList();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            list.RemoveFirstNode();
            list.Display();
            list.RemoveLastNode();
            list.Display();
        }
    }
}
