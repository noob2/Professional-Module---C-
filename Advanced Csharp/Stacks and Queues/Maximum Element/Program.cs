using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int queries = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();
        Stack<int> maxNumber = new Stack<int>();
        maxNumber.Push(int.MinValue);

        for (int i = 0; i < queries; i++)
        {
            int[] numbersArray = Console.ReadLine()
            .Trim()
            .Split((new char[] { ' ' }), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            if (numbersArray.Length == 1)
            {
                if (numbersArray[0] == 2)
                {
                    if (maxNumber.Peek() == stack.Peek())
                    {
                        maxNumber.Pop();
                    }
                    stack.Pop();
                    
                }
                else if (numbersArray[0] == 3)
                {
                    Console.WriteLine(maxNumber.Peek());
                }
            }
            else if (numbersArray.Length == 2)
            {
                if (numbersArray[0] == 1)
                {
                    stack.Push(numbersArray[1]);

                    if (numbersArray[1] > maxNumber.Peek())
                    {
                        maxNumber.Push(numbersArray[1]);
                    }
                }
            }
        }
    }
}

