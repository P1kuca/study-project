/*using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;  
        int num;        
        Console.WriteLine("Введіть послідовність чисел. Для завершення введіть 0.");

        do
        {
            num = int.Parse(Console.ReadLine());  

            if (num > 0)  
            {
                count++;  
            }
        } while (num != 0);  

        Console.WriteLine("Кількість додатніх чисел: " + count);
        Console.ReadLine();
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;


        Console.WriteLine("Введіть послідовність від’ємних чисел. ДЛя завершення введіть 0. ");
        int number;

        do
        {
            number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                sum += number;
                count++;
            }
        } while (number != 0);

        double average = (double)sum / count;
        Console.WriteLine("Середнє арифметичне від'ємних чисел: " + average);

    }
}

int sum = 0;

for (int i = 101; i <= 301; i++)
{
    if (i % 2 != 0) 
    {
        sum += i; 
    }
}

Console.WriteLine("Сума непарних чисел від 101 до 301: " + sum);

for (int i = 1; i <= 9; i += 2)
{
    int cube = i * i * i;
    Console.Write($"{i}Л3={cube}; ");
}


Console.Write("Введіть значення x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введіть значення n: ");
int n = int.Parse(Console.ReadLine());

double sum = 0;
double pow = 1;

for (int i = 1; i <= n; i++)
{
    pow *= x;
    sum += pow;
}

Console.WriteLine($"Сума = {sum}");

Console.Write("Введіть число a: ");
double a = double.Parse(Console.ReadLine());

double sum = 0;
int i = 1;

while (sum < a)
{
    sum += 1.0 / i;
    i++;
}

Console.WriteLine($"Перша часткова сума, що більша за {a}, дорівнює {sum}.");


Console.Write("Введіть кількість чисел: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
sum += i;
}

Console.WriteLine("Сума перших {0} цілих додатних чисел: {1}", n, sum);


Console.Write("Введіть число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
}

Console.Write("Введіть значення х: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введіть кількість елементів: ");
int n = int.Parse(Console.ReadLine());

double sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += 1 / (Math.Pow(i, x));
}

Console.WriteLine("Сума перших {0} елементів ряду: {1}", n, sum);

Console.WriteLine("Введите количество элементов в ряду:");
int n = int.Parse(Console.ReadLine()); 
double sum = 0; 

for (int i = 1; i <= n; i++)
{
    sum += 1.0 / (2 * i); 
}

Console.WriteLine("Сумма первых {0} элементов ряда равна: {1}", n, sum);

Console.WriteLine("Введите стоимость яблок за 1 кг:");
double cost = double.Parse(Console.ReadLine());

Console.WriteLine("Таблица стоимости яблок:");
Console.WriteLine("Вес\t| Стоимость");
Console.WriteLine("---------------------");

for (double weight = 0.1; weight <= 1.0; weight += 0.1)
{
    double price = weight * cost * 10;
    Console.WriteLine("{0:F1} кг\t| {1:C2}", weight, price);
}*/

Console.WriteLine("Введите количество чисел:");
int n = int.Parse(Console.ReadLine()); 

int sumPositive = 0; 
int productNegative = 1;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Введите число {0}:", i);
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        sumPositive += number;
    }
    else if (number < 0)
    {
        productNegative *= number;
    }
}
Console.WriteLine("Сумма положительных чисел: {0}", sumPositive);
Console.WriteLine("Произведение отрицательных чисел: {0}", productNegative);
Console.ReadLine();