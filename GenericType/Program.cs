// See https://aka.ms/new-console-template for more information


using System;

namespace GenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            DemoClass.toPrint(intArray);
            DemoClass.toPrint(doubleArray);
            DemoClass.toPrint(charArray);

            DemoClass.toPrint<int>(intArray);
            DemoClass.toPrint<double>(doubleArray);
            DemoClass.toPrint<char>(charArray);

            Console.ReadKey();






        }
    }
}
