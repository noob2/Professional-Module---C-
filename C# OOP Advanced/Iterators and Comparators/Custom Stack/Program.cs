using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Stack<string> collection = new Stack<string>();

            while (input != "END")
            {
                var inputParams = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                switch (inputParams[0])
                {
                    case "Push":
                        AddItems(collection, inputParams);
                        break;
                    case "Pop":
                        collection.Pop();
                        break;
                    default: throw new InvalidExpressionException("invalid Command");
                }
                input = Console.ReadLine();
            }
            PrintStack(collection);
        }

        private static void AddItems(Stack<string> collection, string[] inputParams)
        {
            for (int i = 1; i < inputParams.Length; i++)
            {
                collection.Push(inputParams[i]);
            }
        }

        public static void PrintStack(Stack<string> stack)
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("No elements");
            }
            else
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
