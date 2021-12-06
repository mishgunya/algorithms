using System;

namespace algorithms
{
    internal class Program
    {
        public static void IsSimple(int num)
        {
            int d = 0;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                    d++;
            }
            if (d == 0) Console.WriteLine("Число простое");
            else { Console.WriteLine("Число не простое"); Console.WriteLine($"Число делителей: {d}"); }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("выберите задачу: 1 - определение простое ли число, 2 - Числа фибоначи с рекурсией и без");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Введите число, которое хотите проверить.");
                    int num = Convert.ToInt32(Console.ReadLine());
                    IsSimple(num);
                    break;
                    case 2:
                    Console.WriteLine("Введите порядковый номер числа");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("рекурсия");
                    Console.WriteLine(FiboR(n));
                    Console.WriteLine("цикл");
                    Console.WriteLine(FiboC(n));
                    break;

            }

            

            

        }

        public static int FiboR (int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return FiboR(n - 2) + FiboR(n - 1);
        }

        public static int FiboC(int n)
        {

            int[] Array = new int[n+1];
            Array[0] = 0;
            Array[1] = 1;
            for (int i = 2;i < n+1; i++)
            {
                Array[i] = Array[i - 2] + Array[i - 1];
            }
            return Array[n];
        }

    }
}
