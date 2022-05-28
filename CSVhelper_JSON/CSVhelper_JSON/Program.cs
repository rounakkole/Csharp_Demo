// See https://aka.ms/new-console-template for more information
using System;

namespace CSVhelper_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Read data from CSV & Write data in CSV");
            CSVHandler.ImplementCSVDataHandling();
            //ReadCSV_And_WriteJSON.ImplementCSVToJSON();
        }
    }
}
