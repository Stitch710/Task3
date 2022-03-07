using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во линий");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n - i; j++)
                        Console.Write(" ");
                    for (int r = 1; r <= i; r++)
                        Console.Write("*");
                    for (int l = i - 1; l >= 1; l--)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("введите коректное значение");
        }
    }
}
