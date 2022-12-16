using System;
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.AddFront(30);
            list.AddFront(56);
            list.Display();
        }
    }
}
