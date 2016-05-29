using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] entryConditions = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int elementsToPush = entryConditions[0];
        int elementsToPop = entryConditions[1];
        int elementToSearch = entryConditions[2];

        int[] numbersArray = Console.ReadLine()
            .Trim()
            .Split((new char[] { ' ' }), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Stack<int> numbersStack = new Stack<int>();

        for (int i = 0; i < elementsToPush; i++)
        {
            numbersStack.Push(numbersArray[i]);
        }

        for (int i = 0; i < elementsToPop; i++)
        {
            numbersStack.Pop();
        }

        if (numbersStack.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (numbersStack.Contains(elementToSearch))
        {
            Console.WriteLine("true");
        }
        else
        {
            int min = numbersStack.Concat(new[] {int.MaxValue}).Min();
            Console.WriteLine(min);
        }
    }
}
