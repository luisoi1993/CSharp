using System;

using SistemaBiblioteca;

using System.Text.Json;
using System.IO;
using System.Diagnostics;

namespace SistemaBiblioteca
{
    class Program
    {
        public static int id = 1;
        public static Biblioteca biblioteca = new Biblioteca();
        static void Main(string[] args)
        {
            cargarBiblioteca();
            int eleccion;
          

            do
            {
                Console.WriteLine("Bienvenido a la biblioteca: ");
                Console.WriteLine("1 - Añadir un libro");
                Console.WriteLine("2 - Ver los libros");
                Console.WriteLine("3 - Buscar libro");
                Console.WriteLine("4 - Prestar libro");
                Console.WriteLine("5 - Devolver libro");
                Console.WriteLine("6 - Ver libros prestados");
                Console.WriteLine("7 - Ver libros disponibles");
                Console.WriteLine("8 - Elimímar libro");
                Console.WriteLine("9 - Ordenar libros por título");
                Console.WriteLine("10 Mostrar número total de libros");
                Console.WriteLine("0 - Salir");
                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        anadirLibros();
                        break;

                    case 2:
                        verLibros();
                        break;

                    case 3:
                        Console.WriteLine("¿quieres buscar por titulo - 0 , o quieres buscar por autor- 1?");
                        int busqueda = int.Parse(Console.ReadLine());

                        if(busqueda == 0)
                        {
                            buscarLibro(0);
                            break;
                        }
                        else if(busqueda == 1)
                        {
                            buscarLibro(1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No has seleccionado una opción valida");
                            break;
                        }


                    case 4:
                                prestarLibro();
                                break;

                            case 5:
                                devolverLibro();
                                break;

                            case 6:
                                verPrestados(1);
                                break;

                            case 7:
                                verPrestados(0);
                                break;


                            case 8:
                                eliminarLibro();
                                break ;

                            case 9:
                                mostrarLibrosOrdenadosTitulo();
                                break;


                            case 10:
                                contarLibros();
                                break;


                            case 0:
                                Console.WriteLine("Hasta pronto: ");
                                break;

                            default:
                                Console.WriteLine("Opción no valida");
                                break;

                            }
            } while (eleccion != 0);
        }

        public static void guardarBiblioteca()
        {
            string json = JsonSerializer.Serialize(biblioteca.Libros);

            File.WriteAllText("biblioteca.json", json);
        }

        public static void cargarBiblioteca()
        {
            if (File.Exists("biblioteca.json"))
            {
                string json = File.ReadAllText("biblioteca.json");

                biblioteca.Libros = JsonSerializer.Deserialize<List<Libro>>(json);
            }
        }

        public static void contarLibros()
        {
            int cuenta = biblioteca.Libros.Count;
            Console.WriteLine($"El número total de libros es {cuenta}");
        }

        public static void anadirLibros()
        {
            Console.WriteLine("Digite el titulo del libro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite el Autor del libro");
            string autor = Console.ReadLine();



            Libro l1 = new Libro(id,titulo,autor);
            id++;
            biblioteca.Libros.Add(l1);
            guardarBiblioteca();
            
        }

        public static void verLibros()
        {


            foreach (Libro libro in biblioteca.Libros) {
                Console.WriteLine($"ID: {libro.Id}\nTítulo: {libro.Titulo}\nAutor: {libro.Autor}\nEstado: {(libro.Prestado ? "Prestado" : "Disponible")}");
            }
        }

        public static Libro buscarLibro(int busqueda)
        {

            if(busqueda == 0)
            {
                Console.WriteLine("Digite el titulo del libro a buscar:");
                string buscar = Console.ReadLine().ToLower();
                bool encontrado = false;
                foreach (Libro libro in biblioteca.Libros)
                {

                    if (libro.Titulo.ToLower() == buscar)
                    {
                        Console.WriteLine($"EL titulo del libro es {libro.Titulo} \n El autor es {libro.Autor}");
                        encontrado = true;
                        return libro;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("No se ha encontrado el libro");

                }
            }

            if(busqueda == 1)
            {
                Console.WriteLine("Digite el autor del libro a buscar:");
                string buscar = Console.ReadLine().ToLower();
                bool encontrado = false;
                foreach (Libro libro in biblioteca.Libros)
                {

                    if (libro.Autor.ToLower() == buscar)
                    {
                        Console.WriteLine($"EL titulo del libro es {libro.Titulo} \n El autor es {libro.Autor}");
                        encontrado = true;
                        return libro;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("No se ha encontrado el libro");

                }   
            }
           

            return null;
        }

        public static void prestarLibro()
        {
            Libro prestado = buscarLibro(0);

            if (prestado != null && prestado.Prestado == false)
            {
                Console.WriteLine("Libro prestado correctamente: ");
                prestado.Prestado = true;
               
            }
            else if (prestado != null && prestado.Prestado == true)
            {
                Console.WriteLine("El libro ya esta prestado");
               

            }
        }

        public static void devolverLibro()
        {
            Libro prestado = buscarLibro(0);

            if(prestado != null && prestado.Prestado == true)
            {
                Console.WriteLine("Libro devuelto");
                prestado.Prestado = false;
            }
        }

        public static void verPrestados(int valor)
        
            
            {
                foreach(Libro libro in biblioteca.Libros)
                {
                    if(valor == 0 && libro.Prestado == false)
                    {
                        Console.WriteLine($"EL titulo del libro es {libro.Titulo} \n El autor es {libro.Autor}");
                        Console.WriteLine();
                    }

                    if(valor == 1 && libro.Prestado == true)
                    {
                        Console.WriteLine($"EL titulo del libro es {libro.Titulo} \n El autor es {libro.Autor}");
                        Console.WriteLine();
                    }

                    
                }
            
            }

        public static void eliminarLibro()
        {
            Console.WriteLine("Digite el id del libro que quiere eliminar: ");
            int id = int.Parse(Console.ReadLine());

            biblioteca.Libros.RemoveAll(libro => libro.Id == id);

            Console.WriteLine("Libro eliminado si existía");
        }

        public static void mostrarLibrosOrdenadosTitulo()
        {
            biblioteca.Libros.Sort((a, b) => a.Titulo.CompareTo(b.Titulo));

            foreach (Libro libro in biblioteca.Libros)
            {
                Console.WriteLine($"ID: {libro.Id}\nTítulo: {libro.Titulo}\nAutor: {libro.Autor}\nEstado: {(libro.Prestado ? "Prestado" : "Disponible")}");
            }
        }

    }

}

    
