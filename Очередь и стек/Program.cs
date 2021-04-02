using System;
using System.Collections;

namespace Очередь_и_стек
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начала работы");
            var Queue = new Queue();
            Console.WriteLine("Переменные инициализированы");
            int[] arr = new int[5]
            {
                5,10,15,20,25
            };
            for (int i = 0; i < arr.Length; i++)
            {
                Queue.Enqueue(arr[i]);
            }
            Console.WriteLine("Очередь заполнена\n");

            Console.WriteLine("Работа с Очередью");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Получил значение: {Queue.Peek(arr[i])}");
                Console.WriteLine($"Удалил значение : {Queue.Dequeue(arr[i])}");
            }
            Console.ReadKey();
        }
    }
}