using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
           Empleado Juan = new Empleado("Juan");

           Juan.SALARIO = 5000;

            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);
        }
    }

    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        public void setSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asigna 0 como salario");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }

        public double getSalario() {
            return salario;
        }

        private double evaluaSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asigna 0 como salario");
                return 0;
            }
            else
            {
                return salario;
            }
        }

        // CReacion de propiedad

        /*public double SALARIO
        {
            get { return salario; }
            set 
            { 
                if(value < 0)
                {
                    Console.WriteLine("El salario no puede ser negativo. Se asigna 0 como salario");
                    salario = 0;
                }
                else
                {
                    salario = value;
                }
            }
        }
        */  

        public double SALARIO { get => this.salario; set => this.salario = evaluaSalario(value); }

        /*
        public double SALARIO
        {
            get { return salario; }
            set { salario = evaluaSalario(value); }
        }

        */

        private double salario;

        private string nombre;


    }
}