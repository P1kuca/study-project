using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = new double[1000];
        int count = 0;
        double prev = double.MinValue;
        while (true)
        {
            Console.Write("Введіть число: ");
            double curr = double.Parse(Console.ReadLine());
            if (curr <= prev)
                break;
            numbers[count] = curr;
            count++;
            prev = curr;
        }

        int evenCount = 0;
        int oddCount = 0;
        for (int i = 0; i < count; i++)
        {
            if (numbers[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }
        Console.WriteLine("Парних чисел: " + evenCount);
        Console.WriteLine("Непарних чисел: " + oddCount);

        Console.Write("Введіть розміри матриці (m n): ");
        string[] sizes = Console.ReadLine().Split(' ');
        int m = int.Parse(sizes[0]);
        int n = int.Parse(sizes[1]);
        double[,] matrix = new double[m, n];
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
        Console.Write("Введіть число, на яке потрібно помножити матрицю: ");
        double scalar = double.Parse(Console.ReadLine());
        double[,] product = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                product[i, j] = matrix[i, j] * scalar;
            }
        }

        Console.WriteLine("Матриця:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Множення на число " + scalar + ":");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(product[i, j] + " ");
            }
            Console.WriteLine();
        }

        double min = double.MaxValue;
        int minRow = -1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minRow = i;
                }
            }
        }
        Console.WriteLine("Мінімальний елемент: {0}", min);
        Console.WriteLine("Мінімальний елемент: {0}", minRow);
    }
}
