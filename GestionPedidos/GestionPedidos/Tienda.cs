using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos
{
    class Tienda
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}