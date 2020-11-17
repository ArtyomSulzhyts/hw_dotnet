using System;

namespace HW_06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            int[] numbers = new int[length];

            EnterNumbers(numbers);

            Console.WriteLine("Введите последнее число");
            numbers[numbers.Length - 1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите его позицию");
            int positionIndex = Convert.ToInt32(Console.ReadLine());

            PrintArray(numbers);
            Sort(numbers, positionIndex);
            PrintArray(numbers);
        }
        static void EnterNumbers(int[] enteredNumbers)
        {
            for (int i = 0; i < enteredNumbers.Length-1; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " число");
                enteredNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Sort(int[] forSorting, int position)
        {
            for (int i = forSorting.Length-1; i > 0; i--)
            {
                    if (i != position - 1)
                    {
                        int temporaryVariable = forSorting[i];
                        forSorting[i] = forSorting[i-1];
                        forSorting[i-1] = temporaryVariable;
                    }              
            }
        }

        static void PrintArray(int[] sortedArray)
        {
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
        }
    }
}
