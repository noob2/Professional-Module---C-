using System;


class Program
{
    static void Main()
    {
        string typeOfShape = Console.ReadLine();
        Shape shape = null;
        if (typeOfShape == "Square")
        {
            int side = int.Parse(Console.ReadLine());
            Square square = new Square(side);
            shape = square;
        }
        else
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            Rectangel rectangle = new Rectangel(length, width);
            shape = rectangle;
        }
        CoreDraw.Draw(shape);
    }
}

internal static class CoreDraw
{
    public static void Draw(Shape shape)
    {
        shape.Draw();
    }
}

public abstract class Shape
{
    public abstract void Draw();
}

public class Square : Shape
{
    public int side;

    public Square(int side)
    {
        this.side = side;
    }

    public override void Draw()
    {
        Console.WriteLine($"{'|'}{new string('-', this.side)}{'|'}");
        for (int i = 0; i < this.side - 2; i++)
        {
            Console.WriteLine($"{'|'}{new string(' ', this.side)}{'|'}");
        }
        Console.WriteLine($"{'|'}{new string('-', this.side)}{'|'}");
    }
}

public class Rectangel : Shape
{
    public int length;
    public int width;

    public Rectangel(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public override void Draw()
    {
        Console.WriteLine($"{'|'}{new string('-', this.width)}{'|'}");
        for (int i = 0; i < this.length - 2; i++)
        {
            Console.WriteLine($"{'|'}{new string(' ', this.width)}{'|'}");
        }
        Console.WriteLine($"{'|'}{new string('-', this.width)}{'|'}");
    }
}
