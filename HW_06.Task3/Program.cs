using System;

namespace HW_06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[5] { 1, 2, 3, 4, 5 };

            ReverseArray(someArray);
            PrintArray(someArray);
           
        }
        static void ReverseArray(int [] forReverse)
        {
            for (int i = 0; i < forReverse.Length / 2; i++)
            {
                int temporaryVariable = forReverse[i];
                forReverse[i] = forReverse[forReverse.Length - i - 1];
                forReverse[forReverse.Length - i - 1] = temporaryVariable;
            }
        }
        static void PrintArray(int[]reversedArray)
        {
            Console.WriteLine("Массив наоборот: ");
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.WriteLine(reversedArray[i]);
            }
        }
    }
}