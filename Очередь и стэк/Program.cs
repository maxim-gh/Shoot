using System;
using System.Collections;

namespace Очередь_и_стек
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyQ = new Queue();
            MyQ.Enqueue(0);
            MyQ.Enqueue(1);
            Console.WriteLine("flflfl");
            for (int i = 1; i <= MyQ.Count; i++)
            {
                Console.WriteLine(MyQ.GetElement(i));
            }
            MyQ.Enqueue(0);
            MyQ.Enqueue(1);
            Console.WriteLine("sdfsdf");
            for (int i = 1; i <= MyQ.Count; i++)
            {
                Console.WriteLine(MyQ.GetElement(i));
            }
        }
    }
}