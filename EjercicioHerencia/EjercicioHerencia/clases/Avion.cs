using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia.clases
{
     class Avion(): Vehiculo
    {
        public void despegar()
        {
            Console.WriteLine("El avión ha despegado.");
        }
        public void aterrizar()
        {
            Console.WriteLine("El avión ha aterrizado.");
        }
        public override void conducir()
        {
            Console.WriteLine("Estas volando el avión");
        }
    }
}
