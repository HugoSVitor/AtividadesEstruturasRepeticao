using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contemplem o poder da sequência de fibonacci");

            int h = 15;
            int x = 0;
            int y = 1;
            int z = 0;

            for (int i = 0; i < h; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }
            Console.ReadLine();
        }
    }
}
