using System;
using System.Collections;

namespace Очередь_и_стек
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyQ = new Queue();
            MyQ.Enqueue(10);
            MyQ.Enqueue(20);
            Console.WriteLine("Все числа");
            for (int i = 1; i <= MyQ.Count; i++)
            {
                Console.WriteLine(MyQ.Get(i));
            }
            MyQ.Enqueue(30);
            MyQ.Enqueue(40);
            Console.WriteLine("После изменения");
            Console.WriteLine(MyQ.Get(2));

                Console.ReadKey();
        }
    }
}