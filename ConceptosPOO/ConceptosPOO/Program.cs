using ConceptosPOO;
using System;

using static System.Math;

using static System.Console;

class Program
{
    static void Main(string[] args)
    {
       // realizarTarea();

        double raiz = Sqrt(9);

        double potencia = Pow(3, 4);

        Console.WriteLine(raiz);
        Console.WriteLine(potencia);

        var miVariable = new {
            Nombre = "Juan",
            Edad = 30
        };

        Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

        var miOtraVariabe = new {
            Nombre = "Maria",
            Edad = 25
        };

        miVariable = miOtraVariabe;
    }

    static void realizarTarea()
    {
        Punto punto1 = new Punto();
        Punto punto2 = new Punto(5, 10);
        Punto punto3 = new Punto(2, 3);

        double distancia = punto1.DistanciaHasta(punto2);

        WriteLine($"La distancia entre los dos puntos es {distancia}");

        WriteLine($"Numero de objetos creados {Punto.ContadorDeObjetos()}");

        
    }

}