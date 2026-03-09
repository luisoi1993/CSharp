using EjercicioHerencia.clases;
using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
           Coche mercedes = new Coche();
           Avion boeing = new Avion();

         // crear array de vehiculos
           Vehiculo[] vehiculos = new Vehiculo[2];
           vehiculos[0] = mercedes;
           vehiculos[1] = boeing;

            vehiculos[0].arrancarMotor();
            vehiculos[0].conducir();
            vehiculos[1].conducir();

            mercedes.abrirPuertas();
            boeing.despegar();  
        }
    }
    
    
}
