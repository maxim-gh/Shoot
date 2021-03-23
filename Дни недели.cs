using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace _2
{
    public class DayWeekEnum : IEnumerator
    {
        string[] arr;

        int position = -1;
        public object Current
        {
            get
            {
                return arr[position];
            }
        }

        public bool MoveNext()
        {
            if (position < arr.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    public class DayWeek : IEnumerable
    {
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }

    }

    class Program
    {
        private static void Main(string[] args)
        {
            DayWeek dayweek = new DayWeek();
            foreach (string days in dayweek)
            {
                Console.WriteLine($"День недели: {days}");
            }
            Console.ReadKey();
        }
    }
}
