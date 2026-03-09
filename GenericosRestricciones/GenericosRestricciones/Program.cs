using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> almacenDirectores = new AlmacenEmpleados<Director>(3);
            almacenDirectores.agregar(new Director(5000));
            almacenDirectores.agregar(new Director(6000));
            almacenDirectores.agregar(new Director(7000));
            AlmacenEmpleados<Secretaria> almacenSecretarias = new AlmacenEmpleados<Secretaria>(2);
            almacenSecretarias.agregar(new Secretaria(3000));
            almacenSecretarias.agregar(new Secretaria(3500));
            AlmacenEmpleados<Electricista> almacenElectricistas = new AlmacenEmpleados<Electricista>(2);
            almacenElectricistas.agregar(new Electricista(4000));
            almacenElectricistas.agregar(new Electricista(4500));
        }
    }

    class AlmacenEmpleados<T> where T : IParaEmpleados
    {
        public AlmacenEmpleados(int capacidad)
        {
            datosEmpleado = new T[capacidad];
        }
        public void agregar(T empleado)
        {
            if (i < datosEmpleado.Length)
            {
                datosEmpleado[i] = empleado;
                i++;
            }
        }

        private int i = 0;

        private T[] datosEmpleado;

        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }
    }



    class Director : IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }

    }

    class Secretaria : IParaEmpleados
        {
            public Secretaria(double salario)
            {
                this.salario = salario;
            }

            private double salario;

            public double getSalario()
            {
                return salario;
            }
        }

        class Electricista : IParaEmpleados
        {
            public Electricista(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }

            private double salario;
        }

        class Estudiante
        {
           public Estudiante(double edad)
            {
                this.edad = edad;
            }

            public double getEdad()
            {
                return edad;
            }
        private double edad;
            
        }

    interface IParaEmpleados
        {
            double getSalario();
        }

    
}
