using System;
using System.Collections;

namespace Очередь_и_стек
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начала работы");
            var queue = new Queue();
            var stack = new Stack();
            Console.WriteLine("Переменные инициализированы");
            int [] arr = new int[5]
            {
                5,10,15,20,25
            };
            for (int i = 0; i < arr.Length; i++) 
            {
                queue.Enqueue(arr[i]);
                stack.Push(arr[i]);
            }
            Console.WriteLine("Очередь и стек заполнены\n");
            Console.WriteLine("Работа с Очередью");
            var queuesize = queue.Count;
            for (int i = 0; i < queuesize; i++)
            {
                Console.WriteLine($"Получил значение : {queue.Peek()}");
                Console.WriteLine($"Удалил значение : {queue.Dequeue()}");
            }
            Console.WriteLine();
            Console.WriteLine("Работа с Стеком");
            var stacksize = stack.Count;
            for (int i = 0; i < stacksize; i++)
            {
                Console.WriteLine($"Получил значение : {stack.Peek()}");
                Console.WriteLine($"Удалил значение : {stack.Pop()}");
            }

            Console.ReadKey();
        }
    }
}