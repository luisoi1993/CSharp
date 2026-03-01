using System;

namespace Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.WriteLine("MEsnsaje desde el Main");

            sumarNumeros(5, 10);
            Console.WriteLine(sumaNumeros2(7, 8));

            Console.WriteLine(dividirNumeros(7, 8));
            Console.WriteLine(multiplicarNumeros(5,4));

            Console.WriteLine(Suma(5, 10));
            Console.WriteLine(Suma(5, 10, 15));
            Console.WriteLine(Suma(5, 10.5, 15));

            

        }
        
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");
        }

        static void sumarNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los números es: " + (num1+num2));
        }

        static int sumaNumeros2(int num1, int num2)
        {
            return num1 + num2;
        }

        static double dividirNumeros(double num1, double num2)
        {
            return num1 / num2;
        }

        static double multiplicarNumeros(double num1, double num2) => num1 * num2;

        static int Suma(int num1, int num2) => num1 + num2;

        static int Suma(int num1, int num2, int num3) => num1 + num2 + num3;

        static double Suma(int num1, double num2, int num3) => num1 + num2 + num3;

        static double Suma(int num1, double num2, double num3 = 0) => num1 + num2 + num3;
    }
}