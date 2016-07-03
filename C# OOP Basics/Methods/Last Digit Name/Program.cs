using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        Number number = new Number(n);
        Console.WriteLine(number.LastDigitToString());
    }
}

class Number
{
    public Number(int digit)
    {
        Digit = digit;
    }

    public int Digit { get; set; }

    public string LastDigitToString()
    {
        var lastNumber = this.Digit % 10;

        string numberString;
        switch (lastNumber)
        {
            case 1:
                numberString = "one";
                break;
            case 2:
                numberString = "two";
                break;
            case 3:
                numberString = "three";
                break;
            case 4:
                numberString = "four";
                break;
            case 5:
                numberString = "five";
                break;
            case 6:
                numberString = "six";
                break;
            case 7:
                numberString = "seven";
                break;
            case 8:
                numberString = "eight";
                break;
            case 9:
                numberString = "nine";
                break;
            case 0:
                numberString = "zero";
                break;
            default:
                throw new IndexOutOfRangeException("the number is not in the range 0-10");
        }
        return numberString;
    }
}
