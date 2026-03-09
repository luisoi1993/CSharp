using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DelegadosPredicadosLambdas
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            // CReación del objeto delegado apuntando a MensajeBienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            // Utilización del delagado para llamar al metodo saludoBienvenida
            ElDelegado("Hola acabo de lllegar");

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ElDelegado("Hola ya me voy");

            */
            /*
            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declaramos delegado predicado

            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);

            foreach (int num in numPares)
            {
                Console.WriteLine(num);
            }
            */

            

            List<Personas> gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 30;

            Personas P2 = new Personas();
            P2.Nombre = "Maria";
            P2.Edad = 25;

            /*
            gente.AddRange(new Personas[] {
                new Personas() { Nombre = "Juan", Edad = 30 },
                new Personas() { Nombre = "Maria", Edad = 25 },
                new Personas() { Nombre = "Pedro", Edad = 40 },
                new Personas() { Nombre = "Ana", Edad = 35 }
            });
            */

            /*

            Predicate<Personas> elDelegadoPred = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(elDelegadoPred);

            if(existe) Console.WriteLine("hay personas que se llaman Juan");
            else
            {
                Console.WriteLine("No hay nadie llamado Juan");
            }
            */

            // Uso del delegado
            //  OperacionesMatematicas operacion = new OperacionesMatematicas((num1, num2 )=> num1 + num2);

            //  Console.WriteLine(operacion(4,7));

            //  List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //   List<int> numerosPares = numeros.FindAll(num => num % 2 == 0);

            /*

            foreach (int num in numerosPares)
            {
                Console.WriteLine(num);
            }*/

            /*
            numerosPares.ForEach(num => { Console.WriteLine(num);
                Console.WriteLine("El numero par es: " );
            });

            */


            ComparaPersonas comparaEdades = (persona1, persona2) => persona1 > persona2;

            Console.WriteLine(comparaEdades(P1.Edad,P2.Edad));
        }

        public delegate bool ComparaPersonas(int edad1, int edad2);
        public delegate int OperacionesMatematicas(int numero1, int numero2);
        
        /*
        public static int Cuadrado(int num)
        {
            return num * num;
        }
        */

        /*

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
        */
        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // DEfinicion del objeto delegado
        delegate void ObjetoDelegado(string msg);

        static bool DamePares(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        class MensajeBienvenida
        {
            public static void SaludoBienvenida(string msj)
            {
                Console.WriteLine("Mensaje de bienvenida: {0}", msj);
            }

        }


        class MensajeDespedida
        {
            public static void SaludoDespedida(string msg)
            {
                Console.WriteLine("MEnsaje de despedida: {0}", msg);
            }

        }

        class Personas
        {
           
            private string nombre;
            private int edad;

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }
        }


    }

}

    
