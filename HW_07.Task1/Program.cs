using System;

namespace HW_07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Print(SplitText(ChangeLetters(text)));
                        
        }

        static string [] SplitText (string forSplitting)
        {
            string[] splitted = forSplitting.Split(';');
            return splitted;
        }
        static string ChangeLetters(string forChange)
        {
            string ChangedText = forChange.Replace('О', 'А');
            return ChangedText;
        }

        static void Print(string [] forPrint)
        {
            for (int i = 0; i < forPrint.Length; i++)
            {
                Console.WriteLine(forPrint[i]);
            }
        }
    }
}
