// See https://aka.ms/new-console-template for more information!

using System;

namespace ConsoleAppWithGit
{
    class Program
    {
        static void GenerateRandomNumbers()
        {
            Console.WriteLine("\n--- Генератор случайных чисел ---");
            Console.Write("Введите минимальное значение: ");
            int min = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите максимальное значение: ");
            int max = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Сколько чисел сгенерировать? ");
            int count = Convert.ToInt32(Console.ReadLine());
            
            if (min >= max)
            {
                Console.WriteLine("Ошибка: минимальное значение должно быть меньше максимального");
                return;
            }
            
            Random random = new Random();
            Console.WriteLine("Сгенерированные числа:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(random.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
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
                        Console.WriteLine("Калькулятор - функция будет реализована");
                        break;
                    case "2":
                        GenerateRandomNumbers();
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
