using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace CapaDatos
{
    public class RepositorioClientes : Conexion
    {
        List<Cliente> lista = new List<Cliente>();
        List<Producto> Precios = new List<Producto>();
        DataTable dataTable = new DataTable();
        public MySqlCommand cmd;
        public void NuevoCliente(Cliente cliente, List<Producto> precios)
        {            
            registrarOActualizarCliente(cliente);
            foreach (Producto p in precios)
            {
                NuevosPrecios(p, cliente);
            }
        }
        public string NuevosPrecios(Producto producto, Cliente cliente)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarPrecioPresentacionACliente", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcod_cliente", cliente.Identificacion));
                    cmd.Parameters.Add(new MySqlParameter("xpresentacion", producto.Presentacion));                    
                    cmd.Parameters.Add(new MySqlParameter("xprecio", producto.Precio));                    

                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "exito";
                    }
                    else
                    {
                        return "Error";
                    }
                }
                else
                {
                    return "Error Conectar Base Datos";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                desConectar();
            }
        }
        public void EliminarCliente(Cliente cliente)
        {/*
            TablaClientesTableAdapter Tabla = new TablaClientesTableAdapter();
            Tabla.EliminarCliente(cliente.Identificacion);*/
        }
        public void ModificarCliente(Cliente cliente)
        {           
            registrarOActualizarCliente(cliente);
        }

        public Cliente BuscarCliente(string identificacion)
        {
            lista.Clear();
            lista = VerClientes();
            if (lista == null)
            {
                return null;
            }
            else
            {
                Cliente cliente = new Cliente();
                foreach (Cliente row in lista)
                {
                    if (row.Identificacion.Equals(identificacion))
                    {
                        
                        cliente = row;
                        break;
                    }                    
                }
                return cliente;
            }
        }
        public List<Cliente> VerClientes()
        {
            dataTable = cargarRegistros("cargarClientes");
            if (dataTable == null)
            {
                return lista=null;
            }
            else
            {
                Cliente cliente;
                lista.Clear();                
                foreach (DataRow row in dataTable.Rows)
                {
                    cliente = new Cliente();
                    cliente.Nombre = row["Nombre"].ToString();
                    cliente.Identificacion = row["cod_cliente"].ToString();
                    cliente.Telefono = row["Telefono"].ToString();
                    cliente.Direccion = row["Direccion"].ToString();
                    lista.Add(cliente);
                }
                return lista;
            }
            
        }
        public DataTable verListaDePrecios()
        {
            dataTable = cargarRegistros("cargarListaDePrecios");
            return dataTable;
        }

        public List<Cliente> VerNombresDeClientes()
        {
            
            if (VerClientes() == null)
            {
                return null;
            }
            else
            {
                Cliente cliente = new Cliente();
                List<Cliente> clientes = new List<Cliente>();
                foreach(Cliente row in lista)
                {
                    cliente.Identificacion = row.Identificacion;
                    cliente.Nombre = row.Nombre;
                    clientes.Add(cliente);
                }
                return clientes;
            }
        }

        public Cliente VerPreciosDeCliente(String identificacion)
        {
            dataTable = cargarPreciosPorCliente("verListaPreciosCliente", identificacion);
            Cliente cliente = new Cliente();
            if (dataTable == null)
            {
                return cliente = null;
            }
            else
            {
                cliente.Identificacion = dataTable.Rows[0]["cod_cliente"].ToString();
                foreach (DataRow row in dataTable.Rows)
                {
                    Producto producto = new Producto();
                    producto.Presentacion = row["nom_presentacion"].ToString();
                    producto.Precio = Convert.ToInt32(row["precio"].ToString());
                    Cliente.Precios.Add(producto);
                }
                return cliente;
            }
        }
        //----------------------------        
        public String registrarOActualizarCliente(Cliente cliente)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarOActualizarCliente", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcedula", cliente.Identificacion));
                    cmd.Parameters.Add(new MySqlParameter("xnombre", cliente.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("xdireccion", cliente.Direccion));                    
                    cmd.Parameters.Add(new MySqlParameter("xtelefono", cliente.Telefono));                   

                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "exito";
                    }
                    else
                    {
                        return "Error";
                    }
                }
                else
                {
                    return "Error Conectar Base Datos";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                desConectar();
            }
        }

    }
}
