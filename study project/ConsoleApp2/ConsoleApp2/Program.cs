/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рік вашого народження:");
        string input = Console.ReadLine();

        int yearOfBirth;
        if (!int.TryParse(input, out yearOfBirth))
        {
            Console.WriteLine("Невірний формат введення.");
            return;
        }

        int age = DateTime.Now.Year - yearOfBirth;

        Console.WriteLine("Ваш вік: " + age);

        Console.WriteLine("---------------------------");

        Console.WriteLine("Введіть перше число:");
        input = Console.ReadLine();
        double a;
        if (!double.TryParse(input, out a))
        {
            Console.WriteLine("Невірний формат введення.");
            return;
        }

        Console.WriteLine("Введіть друге число:");
        input = Console.ReadLine();
        double b;
        if (!double.TryParse(input, out b))
        {
            Console.WriteLine("Невірний формат введення.");
            return;
        }

        double max = a > b ? a : b;

        Console.WriteLine("Максимальне число: " + max);

        Console.WriteLine("---------------------------");

        double numb = a > b ? a : b;

        Console.WriteLine("Максимальне число: " + max);

        double positive = a > 0 ? a : b;
        positive++;

        Console.WriteLine("Додатне число після збільшення на одиницю: " + positive);

        Console.WriteLine("---------------------------");

        Console.WriteLine("Введіть відстань в метрах:");
        input = Console.ReadLine();
        double meters;
        if (!double.TryParse(input, out meters))
        {
            Console.WriteLine("Невірний формат введення.");
            return;
        }

        double centimeters = meters * 100;
        Console.WriteLine("{0} метрів = {1} сантиметрів", meters, centimeters);
    }
}



using System;

class Program
{
    static void Main(string[] args)
    {
        double x = -4.5, y = 0.75 * Math.Pow(10, -4), z = -0.845 * Math.Pow(10, 2);
        double s = Math.Pow(9 + Math.Pow(x - y, 2), 1.0 / 3) / (Math.Pow(x, 2) +
            Math.Pow(y, 2) + 2) - Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Tan(z), 3);
        Console.WriteLine("s = " + s);
    }
}*/


int x = 5;
int y = 7 * x - 3 * x + 6; 
Console.WriteLine("Значение функции у = " + y);

int a = 3;
int b = 4;
double c = Math.Sqrt(a * a + b * b); 
int p = 2 * (a + b);
Console.WriteLine("Периметр прямоугольника = " + p); 
Console.WriteLine("Длина диагонали прямоугольника = " + c); 

int n = 3600; 
int hours = n / 3600; 
Console.WriteLine("Прошло " + hours + " часов"); 

int numb = 123; 
int xum = p * 10 / 9; 
Console.WriteLine("Искомое число x = " + x); 
