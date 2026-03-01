using System;

namespace UsoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 10;

            do
            {
                Console.WriteLine("Impresión" + z);

                z++;
            }while (z < 15);
        }
    }
}