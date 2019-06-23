using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaLogica
{
    public class Composicion : Componente
    {

        private List<Componente> Hijos;
        private List<Producto> lista;
        ServiciosProducto servicios = new ServiciosProducto();
        public Composicion(string presentacion, int precio) : base (presentacion, precio)
        {
            Hijos = new List<Componente>();
            try
            {
                foreach (Producto p in servicios.VerProductosPorPresentacion(presentacion))
                {
                    Hijos.Add(new Hoja(p.Nombre, p.Presentacion, p.Caracteristica, precio));
                }
            }
            catch(Exception e)
            {

            }
        }       


        public string RegistrarPresentacion()
        {
            string Mensaje;
            try
            {
                servicios.RegistrarPresentacion(Presentacion, Precio);
                Mensaje = "Presentacion Registrada con exito.";
            }
            catch (Exception)
            {
                Mensaje = "Ha habido un error al momento de registrar esta presentacion.";
                throw;
            }         
            return Mensaje;
        }
        override
        public void Agregar(Componente producto)
        {
            Hijos.Add(producto);
            servicios.RegistrarConfiguracion(MapearComponente(producto));
        }
        override
        public void Remover(Componente producto)
        {
            Hijos.Remove(producto);
        }
        override
        public List<Componente> MostrarHijos()
        {
            return Hijos;
        }

        override
        public Componente MostrarProducto()
        {
            return null;
        }

        public Producto MapearComponente(Componente componente)
        {
            Producto producto = new Producto();
            producto.Nombre = componente.Producto;
            producto.Presentacion = componente.Presentacion;
            producto.Caracteristica = componente.Caracteristica;
            producto.Precio = componente.Precio;
            return producto;
        }
    }
}
