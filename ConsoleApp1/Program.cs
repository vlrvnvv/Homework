using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь прямоугольника = {height * length}");
        }
    }
}
