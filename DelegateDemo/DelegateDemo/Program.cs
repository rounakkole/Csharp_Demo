// See https://aka.ms/new-console-template for more information


using System;

namespace DelegateDemo
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Demo");
            //operation obj = new operation(Addition);
            //Console.WriteLine("Addition is = {0}",obj(23,27));
            MulticastDelegate1.ImplementDelegate();
        }
    }
}
