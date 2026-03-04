using System;
using System.Transactions;

namespace UsoCoches
{
     class Program
    {
       static void Main(string[] args)
        {
           Coche coche1 = new Coche(); // crear objeto de tipo coche 
            //dar un estado inicial a nuestro coche

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getRuedas());
            Console.WriteLine(coche1.getInfoCoche());

            Coche coche3 = new Coche(2500.5, 350.5);

            Console.WriteLine(coche3.getInfoCoche());
          //  coche3.setExtras(true, "Cuero");
            Console.WriteLine(coche3.getExtras());
        }
    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 300.5;

            tapiceria = "Tela";



        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }
        }

        partial class Coche
        {

        public int getRuedas()
        {
            return ruedas;
        }

        public String getInfoCoche()
        {
            return "El coche tiene " + ruedas + " ruedas, mide " + largo + " cm de largo y " + ancho + " cm de ancho.";
        }

        public void setExtras(bool climatizadorCoche, string tapiceriaCoche)
        {
            climatizador = climatizadorCoche;
            tapiceria = tapiceriaCoche;
        }

        public string getExtras()
        {
            return "El coche tiene climatizador: " + climatizador + " y tapiceria: " + tapiceria;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string tapiceria;

    }
  
    }
