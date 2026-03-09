using System;

namespace AvisosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("DGT", "Sanción cometida. Pague ants de 3 días y se beneficiara en la sancion del 50%", "12/06/2024");

            av2.MostrarAviso();

            Console.WriteLine(av2.getFecha());
        }
    }
}
