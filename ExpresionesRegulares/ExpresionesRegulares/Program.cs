using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares 
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y mi nº de tfno es (+34)123-45-67 y mi código postal es 29679";

            string patron = @"\d{3}-";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0)
            {
                Console.WriteLine("Se ha encontrado numeros");
            }
            else
            {
                Console.WriteLine("No se ha encontrado numeros");
            }
        }
    }
}
