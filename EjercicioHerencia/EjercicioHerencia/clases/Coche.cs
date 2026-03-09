using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia.clases
{
     class Coche(): Vehiculo
    {
        public void abrirPuertas()
        {
            Console.WriteLine("Las puertas del coche se han abierto.");
        }
        public void cerrarPuertas()
        {
            Console.WriteLine("Las puertas del coche se han cerrado.");
        }
        public override void conducir()
        {
            Console.WriteLine("Estas conduciendo el coche");
        }
    }
}
