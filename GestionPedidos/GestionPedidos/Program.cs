using System;

namespace GestionPedidos
{
    class Program
    {
        public static Tienda tienda = new Tienda();
        public static int idProductos = 1;
        public static int idPedidos = 1;

        static void Main(string[] args)
        {
            
            int respuesta = 1;
            do
            {
                Console.WriteLine("Bienvenido a la Tienda: ");
                Console.WriteLine("1 - Añadir Producto");
                Console.WriteLine("2 - Ver productos");
                Console.WriteLine("3 - Crear Pedido");
                Console.WriteLine("4 - Añadir producto a pedido");
                Console.WriteLine("5 - Ver pedidos");
                Console.WriteLine("6 - Enviar pedido");
                Console.WriteLine("7 - Ver pedidos pendientes");
                Console.WriteLine("8 - Ver pedidos enviados");
                Console.WriteLine("0 - Salir");
                respuesta = int.Parse(Console.ReadLine());


                switch(respuesta)
                {
                    case 1:
                        anadirProducto();
                        break;

                    case 2:
                        verProductos();
                        break;

                    case 3:
                        crearPedido();
                        break;

                    case 4:
                        anadirProductoPedido();
                        break;

                    case 5:
                        verPedidos();
                        break;

                    case 6:
                        enviarPedido();
                        break;

                    case 7:
                        verPedidosPendientes();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo......");
                        break;

                    default:
                        Console.WriteLine();
                        break;

            
                }
            }while (respuesta !=0);
        }

        public static void verPedidosEnviados()
        {


            foreach (Pedido pedido in tienda.Pedidos)
            {
                if (pedido.Estado == EstadoPedido.Enviado)
                {
                    Console.WriteLine($"ID: {pedido.Id}\nNº productos: {pedido.Productos}\nTotal: {pedido.Total}\nEstado: {pedido.Estado}");
                }

            }
        }

        public static void enviarPedido()
        {
            Console.WriteLine("Digite el id del pedido que quiere enviar: ");
            int idEnviar = int.Parse(Console.ReadLine());
            bool encontrado = false;

            foreach (Pedido pedido in tienda.Pedidos)
            {
                if (pedido.Id == idEnviar)
                {
                    encontrado = true;
                    if (pedido.Estado == EstadoPedido.Pendiente)
                    {
                        pedido.Estado = EstadoPedido.Enviado;
                        Console.WriteLine("El pedido se ha a enviado ");
                    }
                    else
                    {
                        Console.WriteLine("El pedido ya se habia enviado");

                    }
                }

                if(encontrado == false)
                {
                    Console.WriteLine("No hay ningun pedido con ese id: ");
                }
            }
        }

        public static void verPedidosPendientes()
        {

            
            foreach (Pedido pedido in tienda.Pedidos)
            {
                if(pedido.Estado == EstadoPedido.Pendiente)
                {
                    Console.WriteLine($"ID: {pedido.Id}");
                    Console.WriteLine($"Total: {pedido.Total}");
                    Console.WriteLine($"Estado: {pedido.Estado}");
                    Console.WriteLine("Productos:");

                    foreach (Producto producto in pedido.Productos)
                    {
                        Console.WriteLine(producto.Nombre);
                    }
                }
               
            }
        }

        public static void verPedidos()
        {
            foreach (Pedido pedido in tienda.Pedidos)
            {
                Console.WriteLine($"ID: {pedido.Id}");
                Console.WriteLine($"Total: {pedido.Total}");
                Console.WriteLine($"Estado: {pedido.Estado}");
                Console.WriteLine("Productos:");

                foreach (Producto producto in pedido.Productos)
                {
                    Console.WriteLine(producto.Nombre);
                }
            }

        }

        public static void anadirProductoPedido()
        {
            Console.WriteLine("Digite el número del ID del  pedido al que quiero añadir ");
            int idPe = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el id del producto que quiere añadir");
            int idPr = int.Parse(Console.ReadLine());

            Pedido pedidoEncontrado = null;
            Producto productoEncontrado = null;

            // buscar pedido
            foreach (Pedido p in tienda.Pedidos)
            {
                if (p.Id == idPe)
                {
                    pedidoEncontrado = p;
                    break;
                }
            }

            // buscar producto
            foreach (Producto pr in tienda.Productos)
            {
                if (pr.Id == idPr)
                {
                    productoEncontrado = pr;
                    break;
                }
            }

            // añadir producto al pedido
            if (pedidoEncontrado != null && productoEncontrado != null)
            {
                pedidoEncontrado.Productos.Add(productoEncontrado);
                Console.WriteLine("Producto añadido al pedido correctamente");
            }
            else
            {
                Console.WriteLine("Pedido o producto no encontrado");
            }
        }

        public static void crearPedido()
        {
            Pedido p1 = new Pedido(idPedidos);
            tienda.Pedidos.Add(p1);
            idPedidos++;
            Console.WriteLine("Pedido creado correctamente: ");
        }

        public static void verProductos()
        {
            Console.WriteLine("Los productos son: ");

            foreach (Producto producto in tienda.Productos)
            {
                Console.WriteLine($"ID: {producto.Id}\nNombre: {producto.Nombre}\nPrecio: {producto.Precio}\nStock: {producto.Stock}");
            }

        }
        public static void anadirProducto()
        {
            Console.WriteLine("Vamos a crear un nuevo producto: ");

            Console.WriteLine("Digite el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Digite el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Dijite el stock del producto: ");
            int stock = int.Parse(Console.ReadLine());

            Producto p1 = new Producto(idProductos,nombre,precio,stock);

            tienda.Productos.Add(p1);
            idProductos++;
        }
    }
}