using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 35; i++)
            {
                if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
