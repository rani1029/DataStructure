using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Display();
            Console.WriteLine();
            list.InsertAtParticularPosition(2, 30);

            Console.WriteLine(" linked list after inserting new element");
            list.Display();


        }
    }
}
