using System;
using System.Collections.Generic;
using System.Data;

namespace ListyIterator
{
    class Program
    {
        private static void Main()
        {
            var input = Console.ReadLine();

            ListyIterator<string> collection = new ListyIterator<string>();

            while (input != "END")
            {
                var inputParams = input.Split();
                switch (inputParams[0])
                {
                    case "Create":
                        AddItems(collection, inputParams);
                        break;
                    case "Move":
                        Console.WriteLine(collection.Move());
                        break;
                    case "Print":
                        collection.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(collection.HasNext());
                        break;
                    case "PrintAll":
                        PrintAll(collection);
                        break;
                    default: throw new InvalidExpressionException("invalid Command");
                }
                input = Console.ReadLine();
            }
        }

        public static void PrintAll(ListyIterator<string> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void AddItems(ListyIterator<string> collection, IReadOnlyList<string> inputParams)
        {
            for (int i = 1; i < inputParams.Count; i++)
            {
                collection.Add(inputParams[i]);
            }
        }
    }
}
