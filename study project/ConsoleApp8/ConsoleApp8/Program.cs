using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3;
        int n = 4;

        double[,] matrix = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Введіть елемент [{0},{1}]: ", i, j);
                string input = Console.ReadLine();

                if (!double.TryParse(input, out matrix[i, j]))
                {
                    Console.WriteLine("Введене значення не є числом. Встановлено значення 0.");
                }
            }
        }

        Console.Write("Введіть число, на яке потрібно помножити матрицю: ");
        string factorInput = Console.ReadLine();

        double factor;

        if (!double.TryParse(factorInput, out factor))
        {
            Console.WriteLine("Введене значення не є числом. Помноження на 1.");
            factor = 1;
        }

        double[,] resultMatrix = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                resultMatrix[i, j] = matrix[i, j] * factor;
            }
        }

        Console.WriteLine("Вхідна матриця:" + matrix;

        Console.WriteLine("Результат множення на число {0}:", factor);
    }
}
