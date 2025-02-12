using System;

namespace squarePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            char fChar, sChar;
            int size;
            Console.Write("First Character: ");
            fChar = char.Parse(Console.ReadLine());
            Console.Write("Second Character: ");
            sChar = char.Parse(Console.ReadLine());
            Console.Write("Enter Size: ");
            size = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= size; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("-");
                }
                if(i % 2 == 0)
                {
                    Console.Write(fChar);
                }
                else
                {
                    Console.Write(sChar);
                }
                Console.WriteLine();
            }
        }
    }
}