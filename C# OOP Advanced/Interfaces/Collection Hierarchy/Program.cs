using System;
using Collection_Hierarchy.collections;

namespace Collection_Hierarchy
{
    class Program
    {
        static void Main()
        {
            string[] elementsToAdd = Console.ReadLine().Split();
            int countOfRemoveOps = int.Parse(Console.ReadLine());
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            foreach (var elementToAdd in elementsToAdd)
            {
                Console.Write(addCollection.Add(elementToAdd) + " ");
            }
            Console.WriteLine();
            foreach (var elementToAdd in elementsToAdd)
            {
                Console.Write(addRemoveCollection.Add(elementToAdd) + " ");
            }
            Console.WriteLine();
            foreach (var elementToAdd in elementsToAdd)
            {
                Console.Write(myList.Add(elementToAdd) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
