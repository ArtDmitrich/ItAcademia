using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте количество гвоздей");
            var numberOfNails = InputAndCheckingOfNumber(10);
            Console.WriteLine("Задайте сколько раз нужно ударить по гвоздю, чтобы он забился");
            var numberOfStrokes = InputAndCheckingOfNumber(5);

            Nailing(numberOfNails, numberOfStrokes);
        }
        static int InputAndCheckingOfNumber(int max)
        {
            Console.WriteLine($"Введите целое положительное число от 1 до {max}");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out int number);

            if (result == false || number <= 0 || number > max)
            {
                number = InputAndCheckingOfNumber(max);
            }
            
            return number;
        }  
        static void Nailing (int numberOfNails, int numberOfStrokes)
        {
            Console.WriteLine("Приступаем к забиванию гвоздей");

            for (int i = 1; i <= numberOfNails; i++)
            {
                Console.WriteLine($"Начинаем забивать {i}-й гвоздь");

                for (int j = 0; j < numberOfStrokes; j++)
                {
                    Console.WriteLine("хдыщ");
                }

                Console.WriteLine("Гвоздь забит");
            }

            Console.WriteLine("Задача выполнена. Ты прирожденный плотник!");
        }
    }
}
