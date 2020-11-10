using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            DateTime now = DateTime.Today;
            int resultYear = now.Year - birthYear;
            int resultMonth = now.Month - birthMonth;

            Console.WriteLine("Возраст: " + resultYear + " лет/года " + resultMonth + " месяца/ев");
        }
    }
}
