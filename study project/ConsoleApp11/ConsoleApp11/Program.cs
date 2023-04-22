using System;
class Program
{
static void Main(string[] args)
    {
        double x1, y1, x2, y2, x3, y3;

        Console.Write("Введіть координати вершини A (x y): ");
        string[] input = Console.ReadLine().Split();
        x1 = double.Parse(input[0]);
        y1 = double.Parse(input[1]);

        Console.Write("Введіть координати вершини B (x y): ");
        input = Console.ReadLine().Split();
        x2 = double.Parse(input[0]);
        y2 = double.Parse(input[1]);

        Console.Write("Введіть координати вершини C (x y): ");
        input = Console.ReadLine().Split();
        x3 = double.Parse(input[0]);
        y3 = double.Parse(input[1]);

        double area = TriangleArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("Площа трикутника: " + area);

    }

    /*public static double FindTrianglePerimeter(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return perimeter;
    }*/

    /*public static int FindMax(int a, int b, int c)
    {
        int max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        return max;
    }*/

    /*public static double FindTriangeArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }*/

    /*public static bool IsNumbEven(int numb)
    {
        return numb % 2 == 0;
    }*/

    /*public static void Name(string name, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(name);
        }
    }*/

    public static double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }

}
