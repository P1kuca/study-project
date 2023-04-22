/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть суму вкладу: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введіть кількість місяців: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= months; i++)
        {
            deposit += deposit * 0.06m; 
        }

        Console.WriteLine("Кінцева сума вкладу: " + deposit);
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть суму вкладу: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введіть кількість місяців: ");
        int months = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        while (i <= months)
        {
            deposit += deposit * 0.06m; 
            i++;
        }

        Console.WriteLine("Кінцева сума вкладу: " + deposit);
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблиця множення:");

        Console.Write("  ");
        for (int j = 1; j <= 10; j++)
        {
            Console.Write("{0,4}", j);
        }
        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0,2}", i); 
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0,4}", i * j); 
            }
            Console.WriteLine();
        }
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введіть перше число (від 0 до 10): ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть друге число (від 0 до 10): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
            {
                int result = num1 * num2;
                Console.WriteLine($"Результат множення: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Введені числа неприпустимі! Спробуйте ще раз.");
            }
        }

        Console.ReadLine();
    }
}*/


while (true)
{
    Console.Write("Введіть значення x: ");
    string inputX = Console.ReadLine();
    if (inputX.ToLower() == "stop") break;

    Console.Write("Введіть значення y: ");
    string inputY = Console.ReadLine();
    if (inputY.ToLower() == "stop") break;

    Console.Write("Введіть значення z: ");
    string inputZ = Console.ReadLine();
    if (inputZ.ToLower() == "stop") break;

    int x, y, z;
    if (int.TryParse(inputX, out x) && int.TryParse(inputY, out y) && int.TryParse(inputZ, out z))
    {
        Console.WriteLine($"Результат: {x * y * z}\n");
    }
    else
    {
        Console.WriteLine("Невірний формат введених даних. Спробуйте ще раз.\n");
    }
}

Console.WriteLine("Робота програми завершена.");
