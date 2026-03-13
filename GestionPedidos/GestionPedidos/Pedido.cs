using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos
{
    public enum EstadoPedido
    {
        Pendiente,
        Enviado
    }

    class Pedido
    {
        public int Id { get; set; }

        public List<Producto> Productos { get; set; }

        public EstadoPedido Estado { get; set; }

        public double Total
        {
            get
            {
                double total = 0;

                foreach (Producto p in Productos)
                {
                    total += p.Precio;
                }

                return total;
            }
        }

        public Pedido(int id)
        {
            Id = id;
            Productos = new List<Producto>();
            Estado = EstadoPedido.Pendiente;
        }
    }
}