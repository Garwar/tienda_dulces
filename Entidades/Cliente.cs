using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {        

        public static List<Producto> Precios = new List<Producto>();

        public DateTime fecha = new DateTime();
    }
}
