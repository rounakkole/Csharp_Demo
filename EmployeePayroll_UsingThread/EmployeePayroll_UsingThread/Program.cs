// See https://aka.ms/new-console-template for more information

using System;

namespace EmployeePayroll_UsingThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Payroll using Threads");
            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");
            Console.WriteLine("Size of array after splitting the content: " + words.Length);
            #region ParallelTasks
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin first task...");
                GetLongestWord(words);
            },// close 1st action
            () =>
            {
                Console.WriteLine("Begin second task...");
                GetMostCommonWords(words);
            },
            () =>
            {
                Console.WriteLine("Begin third task...");
                GetMostCommonWords(words);
            }// close third action
            );// close parallel.invoke
            #endregion

        }



        private static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into q
                                 orderby q.Count() descending
                                 select q.Key;
            var commonWord = frequencyOrder.Take(10);
            //while(commonWord.move)
            foreach (var list in commonWord)
            {
                Console.WriteLine(list);
            }
            //Console.WriteLine($"The most common word is {commonWord}");
            Console.ReadKey();
        }

        public static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving from {uri}");
            //Download a web page the easy way
            string blog = new System.Net.WebClient().DownloadString(uri);
            return blog.Split(
                new char[] { ' ', '\u000A', '.', ',', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
        private static string GetLongestWord(string[] words)
        {
            string longestWord = (from w in words
                                  orderby w.Length descending
                                  select w).First();

            Console.WriteLine($"Task 1 -- The longest word is {longestWord}.");
            return longestWord;
        }

    }
}
