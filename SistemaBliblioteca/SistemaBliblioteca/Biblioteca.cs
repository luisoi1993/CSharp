using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; }

        public Biblioteca()
        {
            Libros = new List<Libro>();             
        }
    }
}
