using System;

class Program
{
    static void Main(string[] args)
    {
        uint a = 15;
        uint b = 20;
        int c = 5;
        int d = 10;
        long e = 25;
        long f = 30;

        Console.WriteLine("Результат для uint: " + Multiply(a, b, (x, y) => x * y + 1));
        Console.WriteLine("Результат для int: " + Multiply(c, d, (x, y) => x * y + 2));
        Console.WriteLine("Результат для long: " + Multiply(e, f, (x, y) => x * y + 3));
    }

    static T Multiply<T>(T num1, T num2, Func<T, T, T> operation)
    {
        return operation(num1, num2);
    }
}
