using System;
using System.Linq;

namespace fundamentalsI
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; 1 <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Nada");
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }

            for (int i = 0; 1 <= 100; i++)
            {
                if(i % 15 == 0) {
                    Console.WriteLine("FizzBuzz");
                }else if (randVal % 3 == 0)
                {
                    Console.WriteLine("Fuzz");
                }else if (randVal % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
