using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        Queue<long> sequence = new Queue<long>();
        sequence.Enqueue(number);

        Console.Write($"{number} ");

        for (long i = 0; i < 50; i++)
        {
            long current = sequence.Dequeue();

            long first = current + 1;
            sequence.Enqueue(first);
            Console.Write($"{first} ");

            long second = current * 2 + 1;
            sequence.Enqueue(second);
            Console.Write($"{second} ");

            long third = current + 2;
            sequence.Enqueue(third);
            Console.Write($"{third} ");
        }
    }
}
