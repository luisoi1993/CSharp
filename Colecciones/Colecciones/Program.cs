using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace Colecciones
{
       class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenar el diccionario

            edades.Add("Juan", 18);
            edades.Add("Diandra", 36);

            edades["María"] = 25;

            edades["Antonio"] = 34;

            // REcorrer el diccionario

            foreach (KeyValuePair<string, int> kvp in edades) 
            {
                Console.WriteLine("nombre: " + kvp.Key + "  Edad : " + kvp.Value );
            }

            /*
            Stack<int> stack = new Stack<int>();

            //recorriendo el stack

            foreach (int i in new int[] { 10, 5, 3, 6, 3 })
            {
                stack.Push(i);
            }

            //eliminando elementos de stack

            stack.Pop();

            //Mostrando el stack
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            */
            /*
            Queue<int> numeros = new Queue<int>();

            //rellenando o agregando elementos a la coala

            foreach (int i in new int[] { 10, 5, 3, 6, 3 })
            {
                numeros.Enqueue(i);
            }

            //recorriendo la cola 

            Console.WriteLine("recorriendo Queue");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            //eliminando elementos del Queue
            Console.WriteLine("Eliminando elementos");
            numeros.Dequeue();

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }


            */


            /*

            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int i in new int[] {10,5,3,6,3})
            {
                numeros.AddLast(i);
            }

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(100);

            numeros.AddFirst(nodoImportante);


            // numeros.Remove(3);

            for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value);
            }

            */

            /*

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            */

            /*
            List<int> numeros = new List<int>(); // Declarar una lista (coleccion de tipo lista

             Console.WriteLine("Introduce elementos en la coleccion (0 para salir)");

             int elem = 1;

             while (elem != 0)
             {
                 Console.WriteLine("Introduce un numero: ");
                 elem = Convert.ToInt32(Console.ReadLine());
                 if (elem != 0)
                 {
                     numeros.Add(elem);
                 }

              }

             numeros.RemoveAt(numeros.Count - 1);

             Console.WriteLine("Elementos introducidos: ");

             foreach (int i in numeros) 
             {
                 Console.WriteLine(i);
             }

             /*
             Console.WriteLine("¿cuantos elementos quieres introducir?");

             int cantidadElementos = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < cantidadElementos; i++)
             {
                 Console.WriteLine("Introduce un numero: ");
                 int numero = Convert.ToInt32(Console.ReadLine());
                 numeros.Add(numero);
             }

             Console.WriteLine("Elementos intruducidos " + cantidadElementos);

             for (int i = 0; i < numeros.Count; i++)
                 {
                     Console.WriteLine(numeros[i]);
             }

             /*

             */

            /*

            int[] listaNUmeros = new int[] { 2,6,8,3,6,7};

            for(int i = 0; i < listaNUmeros.Length; i++)
            {
                numeros.Add(listaNUmeros[i]);
            }

            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);

            for (int i = 0; i < numeros.Count; i++) 
            {
                Console.WriteLine(numeros[i]);
            }

            */
        }
    }
}
