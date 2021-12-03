using System;

namespace algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            Console.WriteLine("Введите число");
          int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    d++;
            }
            if (d == 0) Console.WriteLine("Число простое");
            else Console.WriteLine("Число не простое");
        }
    }
}
