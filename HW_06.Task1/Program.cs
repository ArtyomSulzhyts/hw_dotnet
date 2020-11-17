using System;

namespace HW_06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 3;
            int[] massiveRandom = new int[length];
            int[] massiveManual = new int[length];
            int[] massiveSum = new int[length];

            RandomNumbers(massiveRandom);
            ManualNumbers(massiveManual);
            SumNumbers(massiveRandom, massiveManual, massiveSum);
            Results(massiveSum);
        }

        static void RandomNumbers(int[] randoms)
        {
            for (int i = 0; i < randoms.Length; i++)
            {
                Random randomNum = new Random();
                randoms[i] = randomNum.Next(0,50);
            }
        }
        static void ManualNumbers(int[] manuals)
        {
            for (int i = 0; i < manuals.Length; i++)
            {
                Console.WriteLine("Введите " + (i+1) + " число");
                manuals[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void SumNumbers(int[] first, int[] second, int[] sums)
        {
            for (int i = 0; i < first.Length; i++)
            {
                sums[i] = first[i] + second[i];
            }
        }
        static void Results(int[] results)
        {
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine("Сумма " + (i + 1) + " пары чисел равна: " + results[i]);
            }
        }
    }
}
