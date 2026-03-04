using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var valores = new[] { 15, 28, 45, 75.5, 40.5 };

            // array de objetos
            Empleados Ana = new Empleados("Ana", 28);

            Empleados[] empleados = new Empleados[3];
            empleados[0] = new Empleados("Juan", 30);
            empleados[1] = new Empleados("Diego", 25);
            empleados[2] = Ana;

            // array de clases anónimas
            var personas = new[] {
                new { Nombre = "Juan", Edad = 30 },
                new { Nombre = "Diego", Edad = 25 },
                new { Nombre = "Ana", Edad = 28 }
            };

            Console.WriteLine(personas[1]);

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine(empleados[i].getInfo());
            }

            foreach (var item in empleados)
            {
                Console.WriteLine(item.getInfo());
            }

            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }

            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 27;
            numeros[3] = 47;

            ProcesaDatos(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Impriminedo desde el main");

            foreach (int i in arrayElementos) Console.WriteLine(i);
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");
                
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }

            return datos;
        }

        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }

        class Empleados
        {
            string nombre;
            int edad;

            public string getInfo()
            {
                return $"Nombre: {nombre}, Edad: {edad}";
            }

            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        }
    }
}