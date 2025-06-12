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

        static void CheckPalindrome()
        {
            Console.WriteLine("\n--- Проверка палиндрома ---");
            Console.Write("Введите строку для проверки: ");
            string input = Console.ReadLine();
            
            // Удаляем пробелы и приводим к нижнему регистру
            string cleaned = input.Replace(" ", "").ToLower();
            bool isPalindrome = true;
            
            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            
            if (isPalindrome)
                Console.WriteLine($"\"{input}\" - это палиндром!");
            else
                Console.WriteLine($"\"{input}\" - это не палиндром.");
        }

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
            
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nВыберите функцию:");
                Console.WriteLine("1. Калькулятор");
                Console.WriteLine("2. Генератор случайных чисел");
                Console.WriteLine("3. Проверка палиндрома");
                Console.WriteLine("4. Конвертер температуры");
                Console.WriteLine("0. Выход");
                
                Console.Write("\nВведите номер функции: ");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        RunCalculator();
                        break;
                    case "2":
                        GenerateRandomNumbers();
                        break;
                    case "3":
                        CheckPalindrome();
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
        
