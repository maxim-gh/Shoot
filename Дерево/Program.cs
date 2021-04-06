using System;

namespace дерево
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            var treeSize = tree.Count;
            var check = false;
            var counter = 0;

            int [] mas = new int[15]
            {
                31,49,98,66,60,12,41,50,38,80,49,49,98,66,41
            };
            foreach (var element in mas)
            {
                tree.AddElement(element);
            }

            foreach (var element in mas)
            {
                tree.Search(element, out check, out counter);
                Console.WriteLine($"Значение: {element}, кол-во повторений {counter}, есть ли это число в дереве {check}");
            }
            Console.ReadKey();
        }
    }
}
