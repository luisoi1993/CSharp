using System;
using System.Collections.Generic;
using System.Text;


namespace ConceptosPOO
{
     class Punto
    {
        private int x;
        private int y;

        public Punto(int x ,int y)
        {
            this.x = x;
            this.y = y;

            contadorDeObjetos++;
        }

        public Punto()
        {
           this.x = 0;
           this.y = 0;
           contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distancia = Math.Sqrt(xDif * xDif + yDif * yDif);

            return distancia;
        }

        public static int ContadorDeObjetos()
        {
            return contadorDeObjetos;
        }

        private static int contadorDeObjetos = 0;

        public const int constantePrueba = 7;
    }
}
