// See https://aka.ms/new-console-template for more information
using System;

namespace FileIOdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File IO");

            FileExists();
            //ReadAllLines();
            //ReadAllText();
            //FileCopy();
            //DeleteFile();
            //ReadFromStreamReader();
            WriteUsingStreamWriter();
        }




        public static void FileExists()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example.txt";
            String[] lines;
            //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example.txt";
            String copypath = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example1.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example1.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"D:\Fellowship\Fellowship05-Day20_FileIO\Day20_FileIO\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome1");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }


    }
}
