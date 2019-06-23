using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public abstract class Componente
    {    
        public string Producto;
        public string Presentacion;
        public string Caracteristica;
        public int Precio;
        public Componente(string presentacion, int precio)
        {
            Presentacion = presentacion;
            Precio = precio;
        }
        public abstract void Agregar(Componente componente);
        public abstract void Remover(Componente componente);
        public abstract List<Componente> MostrarHijos();
        public abstract Componente MostrarProducto();

    }
}
