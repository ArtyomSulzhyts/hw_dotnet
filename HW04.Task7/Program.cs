using System;

namespace HW04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите W, S, A или D");
            string move = Console.ReadLine();
            switch (move)
            {
                case "W":
                    Console.WriteLine("Фигура перемещается ВВЕРХ");
                    break;
                case "S":
                    Console.WriteLine("Фигура перемещается ВНИЗ");
                    break;
                case "A":
                    Console.WriteLine("Фигура перемещается ВЛЕВО");
                    break;
                case "D":
                    Console.WriteLine("Фигура перемещается ВПРАВО");
                    break;
                default:
                    Console.WriteLine("Вы нажали не W, S, A или D");
                    break;
            }
        }
    }
}
