// See https://aka.ms/new-console-template for more information

using System;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection Demo");
            CustomerInfo obj = new CustomerInfo();
            ReflectionOnCustomer.ReflectionTest();
            obj.Id = -2;
            Console.WriteLine(obj.Id);
        }
    }
}
