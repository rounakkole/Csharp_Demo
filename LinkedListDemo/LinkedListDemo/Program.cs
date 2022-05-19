// See https://aka.ms/new-console-template for more information


using System;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2,30);
            list.Display();
            Console.ReadKey();
        }
    }
}
