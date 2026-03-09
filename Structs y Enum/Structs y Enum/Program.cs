using System;

namespace Structs_y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
           Empleado empleado1 = new Empleado(1000, 200);

            empleado1.cambiaSalario(empleado1, 500);

            Console.WriteLine(empleado1);

            Estaciones alergia = Estaciones.Primavera;

            String La_alergia = Estaciones.Primavera.ToString();

            Console.WriteLine(alergia);

            Console.WriteLine(La_alergia);

            Estaciones? alegiaNullo = null; 

            Bonus Antonio = Bonus.Alto;

            double bonusAntonio = (double)Antonio;  

            double salarioAntonio = 1500 + bonusAntonio;

            Console.WriteLine(salarioAntonio);

            Console.WriteLine(Antonio);

            Empleado2 Juan = new Empleado2(Bonus.Medio, 2000);

            Console.WriteLine("El salario del empeado es : " + Juan.getSalario());
        }
    }

    enum Bonus { Bajo = 500, Medio = 1000, Alto = 1500};

    enum Estaciones { Primavera, Verano, Otoño, Invierno};

    class Empleado2
    {
        public Empleado2(Bonus bonusEmpleado, double salario)
        {
            bonus =(double)bonusEmpleado;

            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + bonus; 
        }
        private double salario, bonus;
    }
    public struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario Base: {0}, Comisión: {1}", salarioBase, comision);
        }

        public void cambiaSalario(Empleado emp, double incremento) 
        { 
            emp.salarioBase += incremento;

            emp.comision += incremento;
        }
    }
}