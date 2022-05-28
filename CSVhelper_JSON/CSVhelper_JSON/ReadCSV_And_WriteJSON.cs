﻿using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVhelper_JSON
{
    internal class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
    {
        string importFilePath = @"C:\Users\rounak\source\repos\CSVhelper_JSON\CSVhelper_JSON\Utility\Addresses1.csv";
        string exportFilePath = @"C:\Users\rounak\source\repos\CSVhelper_JSON\CSVhelper_JSON\Utility\Export1.csv";
        using (var reader = new StreamReader(importFilePath))
        using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<AddressData>().ToList();
            Console.WriteLine("Read data successfully from addresses csv.");
            foreach (AddressData addressData in records)
            {
                Console.Write("\t" + addressData.firstname);
                Console.Write("\t" + addressData.lastname);
                Console.Write("\t" + addressData.address);
                Console.Write("\t" + addressData.city);
                Console.Write("\t" + addressData.state);
                Console.Write("\t" + addressData.code);
                Console.WriteLine();
            }
            Console.WriteLine("**********************Reading from csv file and Write to csv file **************************");

            //Writing json file

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(exportFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, records);
            }

        }
    }
}

}
