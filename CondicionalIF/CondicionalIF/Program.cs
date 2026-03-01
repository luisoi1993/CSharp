using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 15;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if(edad < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
             else if(edad == 18)
            {
                Console.WriteLine("Tienes exactamente 18 años");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad");
            }

            Console.WriteLine("Vamos a evaluar si puedes conducir vehiculos");
            string carnet = "no";

            Console.WriteLine("Introduce tu edad");

            edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet?");

                 carnet = Console.ReadLine();
            }

           

            if (edad >= 18 && carnet.ToLower() == "si")
            {
                Console.WriteLine("Puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("No puedes conducir vehiculos");

            }

            Console.WriteLine("Introduce el primer parcial");
            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo parcial");
            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer parcial");
            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            {
                Console.WriteLine("la nota media es: " +(parcial1+parcial2+parcial3/3));
            }
            else Console.WriteLine("Vuelve en septiembre");

        }
    }
}