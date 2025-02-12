using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 15; n++)
            {
                if(n % 3 == 0 && n % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if(n % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if(n % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                
                else
                {
                    Console.Write(n);
                }
            Console.WriteLine("");
            }
        }
    }
}