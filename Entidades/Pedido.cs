using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public int CodigoFactura { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Cliente { get; set; }        
        public double descuento { get; set; }
        public double Total { get; set; }
        public double Adelanto { get; set; }
        public double Pendiente { get; set; }
        public string Estado { get; set; }
        public List<Producto> productos = new List<Producto>();
    }
}
