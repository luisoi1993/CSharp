using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia.clases
{
     class Vehiculo()
    {
        public void arrancarMotor()
        {
            Console.WriteLine("El motor ha arrancado.");
        }

        public void pararMotor()
        {
            Console.WriteLine("El motor se ha detenido.");
        }

        public virtual void conducir()
        {
            Console.WriteLine("Estas conduciendo");
        }
    }
}
