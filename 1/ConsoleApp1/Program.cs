using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int Age(int x)
        {
            if (x % 2 == 0)
                return 1;
            else
            {
                return 0;
            }
        }
        public static double Function(double x, double y)
        {
            x = Math.Sqrt(x);
            x = Math.Ceiling(x);
            if (x % y == 0)
                return 1;
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            
            int a;
            double b;
            string c;

            Console.WriteLine("Добро пожаловать в консольное приложение!\nВведите свое имя: ");
            c = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите свой возраст: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите любое число");
            b = Convert.ToDouble(Console.ReadLine());

            if (Age(a) == 1)
            {
                Console.WriteLine(c + " твой возраст - это четное число");
            }
            else
            {
                Console.WriteLine(c + "твой возраст - это нечетное число");
            }

            if(Function(a,b) == 1)
            {
                Console.WriteLine("Квадратный корень полученный из твоего возраста, делится на " + b);
            }
            else
            {
                Console.WriteLine("Квадратный корень полученный из твоего вохраста, не делится на " + b);
            }
            Console.ReadKey();
        }
    }
}
