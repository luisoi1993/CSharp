using System;
using System.Net.Http.Headers;
using System.Linq;

namespace Trabajo_Con_Link
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Números pares: ");

            
            List<int> numerosPares = new List<int>();

            foreach(int i in valoresNumericos)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
           

            IEnumerable<int> numerosPares = from numero  in valoresNumericos where numero %2 == 0 select numero;

            foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }
            */


            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            ce.getCeo();

            ce.getEmpleadosOrdenados();

            // ce.empleadosSharp();

            Console.WriteLine("Selleciona el id de la empresa que quieres buscar los empleados: ");

            int idBusqueda = int.Parse(Console.ReadLine());

            try
            {
                ce.getEmpleadosEmpresa(idBusqueda);
            } catch(Exception e) 
            {
                Console.WriteLine("El mensaje es :  " + e.Message);
            }

            


        } 
       
    }

    class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();

            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa() { Id = 1, Nombre = "Google" });

            listaEmpresas.Add(new Empresa() { Id = 2, Nombre = "Sharp" });

            listaEmpleados.Add(new Empleado() { Id = 1, Nombre = "Luis Oi", Cargo = "Camarada", EmpresaId = 2, Salario = 20000 });

            listaEmpleados.Add(new Empleado() { Id = 2, Nombre = "Juan", Cargo = "Camarada", EmpresaId = 1, Salario = 2000 });

            listaEmpleados.Add(new Empleado() { Id = 3, Nombre = "Larry", Cargo = "Jugador", EmpresaId = 2, Salario = 200300 });

            listaEmpleados.Add(new Empleado() { Id = 4, Nombre = "Alba", Cargo = "Camarada", EmpresaId = 2, Salario = 120000 });

        }

        public void getCeo()
        {
            IEnumerable<Empleado>Camarada= from empleado in listaEmpleados where empleado.Cargo == "Camarada" select empleado;

            foreach(Empleado empleado in Camarada)
            {
                empleado.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;

            foreach (Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id
                                              where empresa.Id == Id select empleado;

            foreach (Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }

        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;
    }

    class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre , Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }   

        public double Salario { get; set; }

        //Clave foráneo

        public int EmpresaId { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, cargo {2} con salario {3} y perteneciente a la empresa {4}", Nombre, Id,Cargo,Salario ,EmpresaId);
        }
    }


}

