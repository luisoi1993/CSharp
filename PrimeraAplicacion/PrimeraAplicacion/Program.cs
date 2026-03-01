using System;

namespace PrimeraAplicacion
{



    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Bienveidos a C#"); // Imprime un mensaje de bienvenida en la consola

            /*gfgfgfdg
             gffgdgd
             gfdgfdgd*/

            int edad;


            //video 8
            const double PI = 3.1416; // Declaración de una constante para el valor de pi
            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            //double area = PI * radio * radio; // Cálculo del área del círculo utilizando la fórmula A = πr²

            double area = Math.Pow(radio, 2) * PI; // Cálculo del área del círculo utilizando la función Math.Pow para elevar el radio al cuadrado

            Console.WriteLine($"El area del circulo es: {area}");



        }

    }

}

            

