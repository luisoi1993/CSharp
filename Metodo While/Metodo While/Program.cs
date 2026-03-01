using System;

namespace EstructuraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige medio de trasporte (coche,tren,avión)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Has elegido coche");
                    break;
                case "tren":
                    Console.WriteLine("Has elegido tren");
                    break;
                case "avión":
                    Console.WriteLine("Has elegido avión");
                    break;
                default:
                    Console.WriteLine("Medio de transporte no reconocido");
                    break;
            }
        }
    }
}