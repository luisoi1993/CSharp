using System;

namespace genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);

            

            archivos.agregar("Hola");
            archivos.agregar("Adios");
            archivos.agregar("Chau");
            archivos.agregar("Hasta luego");

               

            String nombrePersona = (String)archivos.getElemento(2);

            Console.WriteLine(nombrePersona);

            /*

            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));

            Empleado emp = (Empleado)archivos.getElemento(0);

            Console.WriteLine(emp.getSalario());

            */
        }

        class AlmacenObjetos<T> 
        {
            public AlmacenObjetos(int z)
            {
                datosElemento = new T[z];
            }

            public void agregar(T obj)
            {

                datosElemento[i] = obj;
                i++;

            }

            public T getElemento(int i)
            {
                return datosElemento[i];
            }

            private T[] datosElemento;

            private int i = 0;
        }
    }

    class Empleado
    {
        public Empleado( double salario)
        {
           
            this.slario = salario;
        }
        public double getSalario()
        {
            return slario;
        }
        private double slario;
    }

}
