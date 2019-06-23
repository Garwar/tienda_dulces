using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimientos
    {
        public DateTime Fecha { get; set; }
        public int Ingreso { get; set; }
        public int Gasto { get; set; }
        public string Razon { get; set; }
        public int Total { get; set; }
    }
}
