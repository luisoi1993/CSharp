using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creacio de objeto de tipo circulo. Variable/objeto de tipo circulo 

            miCirculo = new Circulo(); // Iniciacion de varible/objeto de tipo circulo. Instanciar una clase 
            //INstanciación. Ejemplarización. Creacion de ejemplar de clase 

            Console.WriteLine(miCirculo.CalcualoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalcualoArea(9));

            ConversorEuroDolar miConversor = new ConversorEuroDolar();

            miConversor.euro = 1.253;
            Console.WriteLine(miConversor.convierte(50)); 
            
            miConversor.cambiaValorEuro(1.3);




        }
    }

    class Circulo
    {
       private const double pi = 3.1416; //propiedad de la clase circulo. Campo de clase.

        public double CalcualoArea(int radio) // método de clase . ¿que ueen hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }


    }
    class ConversorEuroDolar
    {
       public  double euro =1.253;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0)
            {
               euro = 1.253;
            }
            else
            {
                euro = nuevoValor;
            }
            
        }
    }
}

 
