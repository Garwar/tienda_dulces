using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;
using System.IO;
using Entidades;
using System.Data;

namespace CapaLogica
{
    public class ServiciosCliente
    {
        RepositorioClientes Repositorio = new RepositorioClientes();           
        public void NuevoCliente(Cliente cliente, List<Producto> precios)
        {
            Repositorio.NuevoCliente(cliente, precios);
        }
        public void NuevosPrecios(Producto producto, Cliente cliente)
        {
            Repositorio.NuevosPrecios(producto, cliente);
        }
        public void EliminarCliente(Cliente cliente)
        {
            Repositorio.EliminarCliente(cliente);
        }
        public void ModificarCliente(Cliente cliente)
        {
            Repositorio.registrarOActualizarCliente(cliente);
        }
        public Cliente BuscarCliente(string identificacion)
        {
            return Repositorio.BuscarCliente(identificacion);
        }
        public List<Cliente> VerClientes()
        {
            return Repositorio.VerClientes();
        }

        public List<Cliente> VerNombresDeClientes()
        {
            return Repositorio.VerNombresDeClientes();
        }

        public bool VerificarCliente(Cliente cliente)
        {
            if (cliente.Nombre.Equals("") || cliente.Direccion.Equals("") || cliente.Identificacion.Equals("") || cliente.Telefono.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable verListaDePrecios()
        {
            return Repositorio.verListaDePrecios();
        }
        public Cliente VerPreciosDeCliente(String nombre)
        {
            return Repositorio.VerPreciosDeCliente(nombre);
        }
        public AutoCompleteStringCollection Autocomplete()
        {
            List<Cliente> lista = VerNombresDeClientes();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();            
            foreach (Cliente row in lista)
            {
                coleccion.Add(row.Nombre);
            }
            return coleccion;
        }
    }
}
