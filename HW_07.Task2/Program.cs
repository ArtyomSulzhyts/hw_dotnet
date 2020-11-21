using System;

namespace HW_07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            CountWords(text);

        }

        static void CountWords(string originalText)
        {
            string[] splitted = originalText.Split(' ');

            string temp;

            for (int i = 0; i < splitted.Length-1; i++)
            {
                for (int j = i + 1; j < splitted.Length; j++)
                {
                    if (splitted[i].Length < splitted[j].Length)
                    {
                        temp = splitted[i];
                        splitted[i] = splitted[j];
                        splitted[j] = temp;
                    }
                }
            }

            DeleteTheLongest(splitted);
            ChangePLace(splitted);
            Print(splitted);
        }
        static void Print(string[] forPrint)
        {
            for (int i = 0; i < forPrint.Length; i++)
            {
                Console.WriteLine(forPrint[i]);
            }
        }
        static void DeleteTheLongest(string[] forDelete)
        {
            forDelete[0] = forDelete[0].Remove(0);
        }

        static void ChangePLace(string [] forChange)
        {
            string temp;
            temp = forChange[1];
            forChange[1] = forChange[forChange.Length-1];
            forChange[forChange.Length - 1] = temp;
        }
    }
}
