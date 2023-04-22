using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("Два числа равны");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго");
        }


        Console.WriteLine("----------------------");

        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 5 && number < 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Невідоме число");
        }


        Console.WriteLine("----------------------");

        Console.WriteLine("Введите число: ");
        int nb1 = int.Parse(Console.ReadLine());

        if (nb1 == 5)
        {
            Console.WriteLine(nb1 + " равно 5!");
        }
        else if (nb1 == 10)
        {
            Console.WriteLine(nb1 + " равно 10!");
        }
        else
        {
            Console.WriteLine("неизвестное число");
        }

        Console.WriteLine("----------------------");

        Console.Write("Введите сумму вклада: ");
        double sum = Convert.ToDouble(Console.ReadLine());

        double interestRate;
        if (sum < 100)
        {
            interestRate = 0.05;
        }
        else if (sum <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double interest = sum * interestRate;
        double bonus = 15;
        double total = sum + interest + bonus;

        Console.WriteLine($"Сумма вклада: {sum}");
        Console.WriteLine($"Проценты: {interest}");
        Console.WriteLine($"Бонус: {bonus}");
        Console.WriteLine($"Итого: {total}");

        Console.WriteLine("----------------------");

        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Вы выбрали операцию сложения");
                break;
            case 2:
                Console.WriteLine("Вы выбрали операцию вычитания");
                break;
            case 3:
                Console.WriteLine("Вы выбрали операцию умножения");
                break;
            default:
                Console.WriteLine("Операция не определена");
                break;
        }
        Console.WriteLine("------------------------");

        Console.WriteLine("Введіть номер операції: 1.Сложеніе 2.Вичітаніе 3.Умноженіе");

        int operation1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть перше число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation1)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Результат: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("Результат: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("Результат: " + result);
                break;
            default:
                Console.WriteLine("Операція невизначена");
                break;
        }

    }
}




