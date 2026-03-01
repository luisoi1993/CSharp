using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar en el bucle While?");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Sadrás del bucle {nombre} cuando respondas 'no' ");

                Console.WriteLine("Deseas repetir otra vez");

                respuesta = Console.ReadLine();

            }
            Console.WriteLine("Has salido del bucle");
        }
    }
}