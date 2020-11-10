using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLetter = 97;
            int lastLetter = 122;
            int alphabetLength = lastLetter - firstLetter + 1;

            char[] alphabet = new char[alphabetLength];

            for (int i = 0; i < alphabetLength; i++)
            {
                char letter = Convert.ToChar(lastLetter);
                alphabet[i] = letter;
                lastLetter--;
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.Write(alphabet[i]);
            }
        }
    }
}
