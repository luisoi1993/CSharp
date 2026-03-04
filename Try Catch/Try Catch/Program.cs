using System;

namespace Try_Catch
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
                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor, intenta de nuevo: ");
                    try
                    {
                        numeroUsuario = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("No has introducido un valor numerico: ");
                        numeroUsuario = 0;
                        Console.WriteLine(ex.Message);
                    }
                    catch(OverflowException ex)
                    {
                        Console.WriteLine("Has introducido un numero demasiado alto ");
                        numeroUsuario = 0;
                    }
                    
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