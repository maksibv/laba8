using System;

namespace Lab3
{
    class Program
    {
        static double a, b;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выполнить операцию '-'");
                Console.WriteLine("5. Выполнить операцию '*'");
                Console.WriteLine("6. Выполнить операцию '/'");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": InputA(); break;
                    case "2": InputB(); break;
                    case "3": Add(); break;
                    case "4": Subtract(); break;
                    case "5": Multiply(); break;
                    case "6": Divide(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный ввод!"); break;
                }
            }
        }

        static void InputA() { }
        static void InputB() { }
        static void Add() { }
        static void Subtract() { }
        static void Multiply() { }
        static void Divide() { }
    }
}