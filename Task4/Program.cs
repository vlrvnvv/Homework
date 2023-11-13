using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество ящиков на складе:");
            int warehouseAmount = int.Parse(Console.ReadLine());

            while (warehouseAmount > 0)
            {
                Console.Write("Введите количество ящиков, которые готова забрать машина:");
                int amountToTake = int.Parse(Console.ReadLine());
                if (amountToTake > warehouseAmount)
                {
                    Console.WriteLine("Вашего количества нет на складе");
                    Console.WriteLine($"Отгружено {warehouseAmount}");
                    break; 
                }
                warehouseAmount = warehouseAmount - amountToTake;
                Console.WriteLine($"Осталось: {warehouseAmount}");
            }

        }
    }
}
