using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Ciudad { get; set; }
        public string Cliente { get; set; }
        public List<Producto> Productos = new List<Producto>();
        public double Valor { get; set; }
        public string Estado { get; set; }
    }
}
