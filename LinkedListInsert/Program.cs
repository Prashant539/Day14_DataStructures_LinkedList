using System;
namespace LinkedListInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.add(56);
            list.add(70);
            list.AddBTW(1, 30);
            list.show();
        }
    }
}
