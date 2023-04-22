using System;
namespace Consolepp6
{


    class Program
    {
        static void Main(string[] args)
        {
            double m, a = 1.4f, b = 10.5f, c = 7.8f, h = 0.9f, k = 0.15f, i = 1, x = 8;
            do
            {
                if (x < c)
                {
                    m = Math.Pow(a, 2) + x;
                    Console.WriteLine(m);
                }
                else
                {
                    m = k + Math.Pow(Math.E, (k * x));
                    Console.WriteLine(m);
                }
                ++i;
                x += h;
            }
            while (a <= x && x <= b);
        }
    }
}

//using System;
//namespace Consolepp6
//{


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double  m, a = 1.4f, b = 10.5f, c = 7.8f, h = 0.9f, k = 0.15f, x = 8;
//            int n = 11;
//            double[] f = new double [n]; 
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("value x: {0}", i);
//                f[i] = Convert.ToDouble(Console.ReadLine());
//            }
//            for (int j = 0; j < n; j++)
//            {
//                if (f[j] < c) 
//                {
//                    m = Math.Pow(a, 2) + x;
//                    Console.WriteLine(m);
//                }
//                else
//                {
//                    m = k + Math.Pow(Math.E, (k * x));
//                    Console.WriteLine(m);
//                }
//            }
//        Console.ReadKey();
//        }
//    }
//}