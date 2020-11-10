using System;

namespace HW04.Task2
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите первое число");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите оператор");
                string oper = Console.ReadLine();

                Console.WriteLine("Введите результат вычисления");
                int result = Convert.ToInt32(Console.ReadLine());

                Operation(oper, firstNum, secondNum);
                Check(oper, firstNum, secondNum, result); // Task3    
            }
            public static void Sum(int a, int b) // Task2
            {
                int c = a + b;
                Console.WriteLine("Сумма чисел =" + c);
            }
            public static void Minus(int a, int b)
            {
                int c = a - b;
                Console.WriteLine("Разность чисел =" + c);
            }
            public static void Check(string oper, int num1, int num2, int res)
            {
                if (oper == "+")
                {
                    if (res == num1 + num2)
                    {
                        Console.WriteLine("Правильно");
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                        MoreOrLess(num1, num2, res);
                    }
                }
                else
                {
                    if (res == num1 - num2)
                    {
                        Console.WriteLine("Правильно");
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                        MoreOrLess(num1, num2, res);
                    }
                }
            }
            public static void MoreOrLess(int num1, int num2, int res) // Task4
            {
                if (res < num1 + num2)
                {
                    Console.WriteLine("Должно быть больше");
                }
                else
                {
                    Console.WriteLine("Должно быть меньше");
                }
            }
            public static void Operation(string operand, int a, int b)
            {
                if (operand == "+")
                {
                    Sum(a, b);
                }
                else
                {
                    Minus(a, b);
                }
            }
        }
    }

