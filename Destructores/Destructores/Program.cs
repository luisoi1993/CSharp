using System;
using System.IO;

namespace Destructores 
{

    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miarchivo = new ManejoArchivos();

            miarchivo.mensasaje();
    
                
        }

    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivos() 
        {
            archivo = new StreamReader(@"C:\Users\luis\Desktop\tirar.txt");

            while ((linea = archivo.ReadLine()) != null) 
            {
                Console.WriteLine(linea);

                contador++;
            }
                
        }

        public void mensasaje() 
        {
            Console.WriteLine($"El numero de lineas es: {contador}");
        }

        ~ManejoArchivos()
        {
            if (archivo != null)
            {
                archivo.Close();
            }
        }

        }

    }
        
