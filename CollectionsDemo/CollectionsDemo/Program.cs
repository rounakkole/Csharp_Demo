// See https://aka.ms/new-console-template for more information
using System;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections");
           
		//doListDemo();
                  //doStackDemo();
                  //doDictionaryDemo();
                  //doQueueDemo();
                  doSetDemo();

        }

        public static void doSetDemo()
        {
            Console.WriteLine("doSetDemo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }

        private static void doQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Jayshankar");
            queue.Enqueue("Raj");

            Console.WriteLine("Head: " + queue.Peek());
            Console.WriteLine("\n Iterating the queue elements after dequeue one element: ");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }


        private static void doDictionaryDemo()
        {
            Console.WriteLine("In dictionary demo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key (key=100): " + dictionary[100]);
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key= " + element.Key + " & Value= " + element.Value);
            }
            Dictionary<int, string>.Enumerator obj = dictionary.GetEnumerator();
            while (obj.MoveNext())
            {
                Console.WriteLine(obj.Current);
            }

        }

        private static void dostackDemo()
        {
            Console.WriteLine("in doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");

            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }

        private static void doListDemo()
        {
            Console.WriteLine("In doListDemo");

            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(list[3]);

        }
    }

}
