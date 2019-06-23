using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;
using Entidades;
using System.Data;

namespace CapaLogica
{
    public class ServiciosProducto
    {
        RepositorioProductos repositorio = new RepositorioProductos();

        public List<Producto> VerProductos()
        {
            return repositorio.VerProductos();
        }

        public string  NuevoProducto(Producto producto)
        {
            //no se esta usando
            return repositorio.NuevoProducto(producto);
        }

        public DataTable verMovimientosDeProducto()
        {
            return repositorio.verMovimientosDeProducto();
        }

        public void BorrarProducto(Producto producto)
        {
            //Se le podria cambiar el char de disponible en la tabla producto de S a N
            repositorio.BorrarProducto(producto);
        }

        public void MenosProductos(Producto producto)
        {
            repositorio.MenosProductos(producto);
        }
        public Producto BuscarProducto(Producto producto)
        {
            return repositorio.BuscarProducto(producto);
        }
        public void RegistrarPresentacion(string presentacion, int precio)
        {
            repositorio.RegistrarPresentacion(presentacion, precio);
        }
        public int VerPrecioPorPresentacion(string presentacion)
        {
            return repositorio.VerPrecioPorPresentacion(presentacion);

        }
        public List<string> VerPresentaciones()
        {
            return repositorio.VerPresentaciones();
        }
        public void RegistrarConfiguracion(Producto producto)
        {
            repositorio.RegistrarConfiguracion(producto);
        }
        public List<Producto> VerProductosPorPresentacion(string presentacion)
        {
            return repositorio.VerProductosPorPresentacion(presentacion);
        }

        public List<string> verProductosPorConfiguracion(string presentacion, string caracteristica)
        {
            return repositorio.verProductosPorConfiguracion(presentacion, caracteristica);
        }

        public List<string> verCaracteristicas()
        {
            return repositorio.verCaracteristicas();
        }

        public string añadirExistencias(Producto producto)
        {
            return repositorio.añadirExistencias(producto);
        }
    }
}
