// See https://aka.ms/new-console-template for more information


using System;

namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //add += new DelEventHandler(India);
            //add += new DelEventHandler(USA);
            //add += new DelEventHandler(England);
            //add.Invoke();
            Console.WriteLine("************Event Handling****************");
            EventHandling.ImplementEvent();
        }
    }
}
