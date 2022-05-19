using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class MulticastDelegate1
    {
        delegate int Delop(int x, int y);
        public static void ImplementDelegate()
        {

            Delop obj = new Delop(Operation.Add);
            obj += new Delop(Operation.Add);   //  int x=5;   x+=6 x
            // obj -= Operation.Square;
            var obj1 = obj(5, 5);
            //Console.WriteLine(obj1);
            obj(8, 3);
        }
    }
    public class Operation
    {
        public Operation(int a)
        {
            Console.WriteLine(a);
        }
        public static int Add(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a + b);
            return a + b;
        }
        public static int Square(int a, int b)
        {
            Console.WriteLine("Multiple = {0}", a * b);
            return a * b;
        }
    }

}
