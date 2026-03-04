using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo();
            Humano humano = new Humano();
            Gorila gorila = new Gorila();

            gorila.trepar();


        }
    }

    class Mamiferos
    {

        private String nombreSerVivo;

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }
    }

    class Caballo : Mamiferos
    {

        public Caballo(String nombreCaballo):base(nombreCaballo)
            {
                
            }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }

}
