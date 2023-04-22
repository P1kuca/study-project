using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[8];
            //int min = nums[0];
            //double sum = 0;

            //Random rand = new Random();

            //for (int i = 0; i < nums.Length; i++)
            //    nums[i] = rand.Next(-8, 8);

            //foreach(int num in nums)
            //    Console.WriteLine("El: {0}", num);

            //foreach (int number in nums)
            //{
            //    if (number < min)
            //        min = number;

            //    sum += number;
            //}  
            //double average = sum / nums.Length;

            //Console.WriteLine("Minimal values: {0}", min);
            //Console.WriteLine("Average values: {0}", average);

            int[,,] mas = { { { 1, 2 },{ 3, 4 } },

                { { 4, 5 }, { 6, 7 } },

                { { 7, 8 }, { 9, 10 } },

                { { 10, 11 }, { 12, 13 } }

              };

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        Console.WriteLine("mas[{0}, {1}, {2}] = {3}", i, j, k, mas[i, j, k]);
                    }
                }
            }


        }
    }
}