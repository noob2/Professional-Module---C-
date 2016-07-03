using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Fibunacci fib = new Fibunacci(n);

        Console.WriteLine(string.Join(", ", fib.GetNumbersInRange(m, n)));
    }
}

class Fibunacci
{
    private List<int> fibunacciNumbers = new List<int>();

    public Fibunacci(int n)
    {
        N = n;
        fibunacciNumbers = SetSequence();
    }

    public int N { get; set; }

    private List<int> SetSequence()
    {
        List<int> sequence = new List<int>();
        int i, f1 = 0, f2 = 1, f3 = 0;
        sequence.Add(f1);
        sequence.Add(f2);
        for (i = 0; i <= this.N - 3; i++)
        {
            f3 = f1 + f2;
            sequence.Add(f3);
            f1 = f2;
            f2 = f3;
        }

        return sequence;
    }

    public List<int> GetNumbersInRange(int startPosition, int endPosition)
    {
        var arr = new List<int>();
        for (int i = startPosition; i < endPosition; i++)
        {
            arr.Add(fibunacciNumbers[i]);
        }

        return arr;
    }
}
