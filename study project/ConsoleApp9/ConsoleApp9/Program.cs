using System;

namespace SumArray
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 5)
                {
                    Console.WriteLine("У масиві знайдено число 5!");
                    return -1;
                }

                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            int sum = Sum(array);

            if (sum != -1)
            {
                Console.WriteLine("Сума елементів масиву: {0}", sum);
            }
        }
    }
}
