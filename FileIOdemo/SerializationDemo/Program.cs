// See https://aka.ms/new-console-template for more information
using System;

namespace SerializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization Demo");

            BinarySerialization obj = new BinarySerialization();
            obj.Serialization();
            BinaryDeSerialization obj1 = new BinaryDeSerialization();
            //  obj1.DeSerialization();
        }

    }
}
