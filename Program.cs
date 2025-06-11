// See https://aka.ms/new-console-template for more information!

using System;

namespace ConsoleAppWithGit
{
    class Program
    {
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
                        CheckPalindrome();
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
