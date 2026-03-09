using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo("Babieca");
            Humano humano = new Humano("Juan");
            Gorila gorila = new Gorila("Copito");

            gorila.trepar();

            humano.getNombre();
            caballo.getNombre();
            gorila.getNombre();

            Mamiferos animal = new Mamiferos("Bucefalo");

            Caballo Bucefalo = new Caballo("Bucefalo");

            Object miAnimal = new Caballo("Bucefalo");

            Object miPErsona = new Humano("Maria");

            Object miMamifero = new Mamiferos("Bucefalo");

            animal = Bucefalo;



            Mamiferos persona = new Humano("Maria");

            Mamiferos[] almacenMamiferos = new Mamiferos[3];

            almacenMamiferos[0] = Bucefalo;
            almacenMamiferos[1] = humano;
            almacenMamiferos[2] = gorila;

            almacenMamiferos[1].getNombre();

            for (int i = 0; i < almacenMamiferos.Length; i++)
            {
                almacenMamiferos[i].getNombre();
                almacenMamiferos[i].pensar();
            }

            Mamiferos miMamifero2 = new Mamiferos("Maria");

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            IMamiferosTerrestres miCaballo = caballo;

            Console.WriteLine("Numero de patas del caballo: " + miCaballo.NumeroPatas());

            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.respirar();

            Humano Juan = new Humano("Juan");

            Juan.respirar();

            Juancho.getNombre();
            Juan.getNombre();

        }

        interface IMamiferosTerrestres
        {
            int NumeroPatas();
        }

        interface IAnimalesYDeportes
        {
            string tipoDeporte();
            bool esOlimpico();
        }

        interface ISaltoConPatas
        {
            int NumeroPatas();
        }

        abstract class Animales
        {
            public void respirar()
            {
                Console.WriteLine("Soy capaz de rspirar");
            }

            public abstract void getNombre();
        }

        class Lagartija : Animales
        {
            // Constructor cambiado a público para que `Program.Main` (u otros tipos) puedan instanciarla.
            public Lagartija(string nombre) {
                nombreReptil = nombre;
            }
            private string nombreReptil;
            public override void getNombre()
            {
                Console.WriteLine("El nombre del reptil es: " + nombreReptil);
            }
        }

        class Mamiferos : Animales
        {



            private String nombreSerVivo;

            public Mamiferos(String nombre)
            {
                nombreSerVivo = nombre;
            }
            

            public virtual void pensar()
            {
                Console.WriteLine("pensamiento basico instintivo");
            }

            public void cuidarCrias()
            {
                Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
            }

            public override void getNombre()
            {
                Console.WriteLine("Mi nombre del mamífero: " + nombreSerVivo);
            }

            

        }

        class Caballo : Mamiferos, IMamiferosTerrestres , IAnimalesYDeportes , ISaltoConPatas
        {

            

            public Caballo(String nombreCaballo) : base(nombreCaballo)
            {

            }

            public void galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
                respirar();
            }

             int IMamiferosTerrestres.NumeroPatas()
            {
                return 4;
            }

            public string tipoDeporte()
            {
                return "Hípica";
            }
            public bool esOlimpico()
            {
                return true;
            }

            int ISaltoConPatas.NumeroPatas()
            {
                return 2;
            }


        }

        class Humano : Mamiferos
        {
            public Humano(String nombreHumano) : base(nombreHumano)
            {
            }
            public override void pensar()
            {
                Console.WriteLine("Soy capaz de pensar");
            }
        }

        class Adolescente: Humano
        {
            public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
            {

            }

            public override void pensar()
            {
                Console.WriteLine("Las hormonas me inpiden pensar con claridad");
            }
        }

        class Gorila : Mamiferos, IMamiferosTerrestres
        {
            public Gorila(string nombreGorila) : base(nombreGorila)
            {

            }
            public override void pensar()
            {
                Console.WriteLine("Soy capaz de pensar, pero de forma instintiva");
            }

            public void trepar()
            {
                Console.WriteLine("Soy capaz de trepar");
            }

            public int NumeroPatas()
            {
                return 2;
            }
        }

        class Ballena : Mamiferos
        {
            public Ballena(string nombreBallena) : base(nombreBallena)
            {

            }

            public void nadar()
            {
                Console.WriteLine("Soy capaz de nadar");
            }
        }

        class Chimpance: Gorila
        {
            public Chimpance(string nombreChinpance) : base(nombreChinpance) 
            { 

            }
        }

    }

}
