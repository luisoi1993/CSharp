using System;

namespace Adivinar_Numero_Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ramdom = new Random();
            int numeroAleatorio = ramdom.Next(1, 101);
            int numeroDeIntentos = 1;

            Console.WriteLine("Cual crees que es el número: ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());

            while (numeroAleatorio != numeroUsuario)
            {
                if(numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor, intenta de nuevo: ");
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());
                    numeroDeIntentos++;
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor, intenta de nuevo: ");
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());
                    numeroDeIntentos++;
                }

            }

            Console.WriteLine($"El numero aleatorio es {numeroUsuario} y as tardado este número de intentos: {numeroDeIntentos}");


        }
    }
}