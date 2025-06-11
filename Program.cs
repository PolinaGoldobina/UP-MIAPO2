// See https://aka.ms/new-console-template for more information!

using System;

namespace ConsoleAppWithGit
{
    class Program
    {
        static void ConvertTemperature()
        {
            Console.WriteLine("\n--- Конвертер температуры ---");
            Console.WriteLine("1. Цельсий в Фаренгейт");
            Console.WriteLine("2. Фаренгейт в Цельсий");
            Console.Write("Выберите тип конвертации: ");
            string choice = Console.ReadLine();
            
            double temperature, converted;
            switch (choice)
            {
                case "1":
                    Console.Write("Введите температуру в Цельсиях: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    converted = (temperature * 9 / 5) + 32;
                    Console.WriteLine($"{temperature}°C = {converted}°F");
                    break;
                case "2":
                    Console.Write("Введите температуру в Фаренгейтах: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    converted = (temperature - 32) * 5 / 9;
                    Console.WriteLine($"{temperature}°F = {converted}°C");
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
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
                        Console.WriteLine("Генератор случайных чисел - функция будет реализована");
                        break;
                    case "3":
                        Console.WriteLine("Проверка палиндрома - функция будет реализована");
                        break;
                    case "4":
                        ConvertTemperature();
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
