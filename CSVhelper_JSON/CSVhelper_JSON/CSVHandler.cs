﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVhelper_JSON
{
    internal class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"D:\Fellowship\Fellowship05-Day21_ThirdPartyLibrary\Day21_CSVHelperAndJson\Day21_CSVHelperAndJson\Utility\Addresses.csv";
            string exportFilePath = @"D:\Fellowship\Fellowship05-Day21_ThirdPartyLibrary\Day21_CSVHelperAndJson\Day21_CSVHelperAndJson\Utility\export.csv";

            //reading csv file
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
                Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
                //Writing csv file

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
                Console.WriteLine("Record inserted successfully in file in CSV format");
            }
        }


    }



}
