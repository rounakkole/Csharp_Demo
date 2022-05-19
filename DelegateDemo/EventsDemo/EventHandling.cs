using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{

    internal class EventHandling
    {

        public static event EventHandler add;
        private static void India()
        {
            Console.WriteLine("India");
        }
        private static void USA()
        {
            Console.WriteLine("USA");
        }
        private static void England()
        {
            Console.WriteLine("England");
        }


    }
}
