// See https://aka.ms/new-console-template for more information
using System;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Patterns patterns = new Patterns();
            bool validation = patterns.ValidatePincode("02345");
            Console.WriteLine(validation);


            //Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
            if (patterns.validateString("560035"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
