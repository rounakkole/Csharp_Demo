// See https://aka.ms/new-console-template for more information


using System;

namespace QueueUsingLinkedList
{ 
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Hello, World!");
LinkedListQueue linkedListQueue = new LinkedListQueue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Display();// this.top=this.top.next
Console.ReadKey();

        }
    }
}