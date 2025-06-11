// See https://aka.ms/new-console-template for more information!

using System;

namespace ConsoleAppWithGit
{
    class Program
    {
        static void RunCalculator()
        {
            Console.WriteLine("\n--- Калькулятор ---");
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите оператор (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Ошибка: деление на ноль!");
                    break;
                default:
                    Console.WriteLine("Неверный оператор");
                    break;
            }
            
            Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в многофункциональное консольное приложение!");
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1. Калькулятор");
            Console.WriteLine("2. Генератор случайных чисел");
            Console.WriteLine("3. Проверка палиндрома");
            Console.WriteLine("4. Конвертер температуры");
            Console.WriteLine("0. Выход");
            
            bool running = true;
            while (running)
            {
                Console.Write("\nВведите номер функции: ");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        RunCalculator();
                        break;
                    case "2":
                        Console.WriteLine("Генератор случайных чисел - функция будет реализована");
                        break;
                    case "3":
                        Console.WriteLine("Проверка палиндрома - функция будет реализована");
                        break;
                    case "4":
                        Console.WriteLine("Конвертер температуры - функция будет реализована");
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
            }
            
            Console.WriteLine("Спасибо за использование приложения!");
        }
    }
}
