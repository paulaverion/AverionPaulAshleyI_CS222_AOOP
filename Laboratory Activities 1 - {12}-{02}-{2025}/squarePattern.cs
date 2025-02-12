using System;

namespace squarePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, y;
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            y = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                if(i != y)
                {
                    for(int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
    }
}