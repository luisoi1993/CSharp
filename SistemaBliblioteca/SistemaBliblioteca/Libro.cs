using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Libro
    {     
        
        // Constructor corregido para inicializar las propiedades
        public Libro()
        {
            Prestado = false;
        }

        // Constructor adicional para inicializar con parámetros
        public Libro(int id, string titulo, string autor, bool prestado = false)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Prestado = prestado;
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public bool Prestado { get; set; }
    }
}
