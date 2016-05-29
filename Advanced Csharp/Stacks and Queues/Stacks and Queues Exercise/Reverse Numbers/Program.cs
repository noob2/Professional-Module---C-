using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbersArray = Console.ReadLine()
            .Trim()
            .Split((new char[] { ' ' }), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Stack<int> numbersStack = new Stack<int>();

        foreach (var number in numbersArray)
        {
            numbersStack.Push(number);
        }

        while (numbersStack.Count != 0)
        {
            Console.Write($"{numbersStack.Pop()} ");
        }
    }
}