using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Hoja : Componente
    {
        public Hoja(string producto, string presentacion, string caracteristica, int precio) : base (presentacion, precio)
        {
            Producto = producto;
            Caracteristica = caracteristica;
        }

        public override void Agregar(Componente componente)
        {
            throw new NotImplementedException();
        }

        public override List<Componente> MostrarHijos()
        {
            throw new NotImplementedException();
        }

        override
        public Componente MostrarProducto()
        {
            Hoja hoja = new Hoja(Producto, Presentacion, Caracteristica, Precio);
            return hoja;
        }

        public override void Remover(Componente componente)
        {
            throw new NotImplementedException();
        }
    }
}
