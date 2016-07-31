using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Box
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<double>> items = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                items.Add(new Box<double>(input));
            }

            var elementToCompare = new Box<double>(double.Parse(Console.ReadLine()));

            Console.WriteLine(CompareElements(items, elementToCompare));
        }

        static int CompareElements<T>(List<Box<T>> boxes, Box<T> box)
            where T : IComparable<T>
        {
            return boxes.Count(currentBox => currentBox.Value.CompareTo(box.Value) > 0);
        }
    }
}
