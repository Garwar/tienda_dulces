using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class RepositorioProductos : Conexion
    {
        List<Producto> lista = new List<Producto>();
        public MySqlCommand cmd;
        DataTable dataTable;
        public List<Producto> VerProductos()
        {
            dataTable = cargarRegistros("verProductos");
            if (dataTable == null)
            {
                return lista = null;
            }
            else
            {                                
                lista.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    Producto producto = new Producto();                    
                    producto.Nombre = row["DESCRIPCION"].ToString();
                    producto.Presentacion = row["NOM_PRESENTACION"].ToString();
                    producto.Caracteristica = row["CARACTERISTICA"].ToString();
                    producto.Cantidad = Convert.ToInt16(row["EXISTENCIAS"].ToString());
                    producto.Vendidos = Convert.ToInt32(row["VENDIDOS"].ToString());
                    producto.Precio = Convert.ToInt32(row["PRECIO"].ToString());
                    lista.Add(producto);
                }
                return lista;
            }
        }

        public List<Producto> VerProductosPorPresentacion(string presentacion)
        {
            dataTable = cargarRegistros("verProductosPorPresentacion", presentacion);
            if (dataTable == null)
            {
                return lista = null;
            }
            else
            {
                lista.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    Producto producto = new Producto();
                    producto.Nombre = row["DESCRIPCION"].ToString();
                    producto.Presentacion = row["NOM_PRESENTACION"].ToString();
                    producto.Caracteristica = row["CARACTERISTICA"].ToString();
                    producto.Cantidad = Convert.ToInt16(row["EXISTENCIAS"].ToString());
                    producto.Vendidos = Convert.ToInt32(row["VENDIDOS"].ToString());
                    lista.Add(producto);
                }
                return lista;
            }
        }

        public DataTable verMovimientosDeProducto()
        {
            return cargarRegistros("verMovimientosDeProducto");
        }
        public string NuevoProducto(Producto producto)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("registrarProducto", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", producto.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("xnom_presentacion", producto.Presentacion));
                    cmd.Parameters.Add(new MySqlParameter("xexistencias", producto.Cantidad));
                    cmd.Parameters.Add(new MySqlParameter("xcaracteristica", producto.Caracteristica));
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "Exito";
                    }
                    else
                    {
                        return "Ha ocurrido un problema";
                    }
                }
                else
                {
                    return "Error al Conectar con la Base Datos";
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

        public string añadirExistencias(Producto producto)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("añadirExistencias", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", producto.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("xpresentacion", producto.Presentacion));
                    cmd.Parameters.Add(new MySqlParameter("xentrada", producto.Cantidad));
                    cmd.Parameters.Add(new MySqlParameter("xcaracteristica", producto.Caracteristica));
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "Exito";
                    }
                    else
                    {
                        return "Ha ocurrido un problema";
                    }
                }
                else
                {
                    return "Error al Conectar con la Base Datos";
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

        public void BorrarProducto(Producto producto)
        {/*
            TablaProductosTableAdapter tabla = new TablaProductosTableAdapter();
            tabla.EliminarProducto(producto.Nombre, producto.Presentacion);
            
             No se esta usando
             */
        }

        public void AgregarProducto(Producto producto)
        {/*
            TablaProductosTableAdapter tabla = new TablaProductosTableAdapter();
            tabla.MasProductos(producto.Cantidad, producto.Presentacion, producto.Nombre);
            
            Parece que hace lo mismo que nuevoProducto()
             */
        }
        public string extraerExistencias(Producto producto)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("extraerExistencias", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", producto.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("xpresentacion", producto.Presentacion));
                    cmd.Parameters.Add(new MySqlParameter("xcaracteristica", producto.Caracteristica));
                    cmd.Parameters.Add(new MySqlParameter("xsalida", producto.Cantidad));
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "Exito";
                    }
                    else
                    {
                        return "Ha ocurrido un problema";
                    }
                }
                else
                {
                    return "Error al Conectar con la Base Datos";
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

        public void MenosProductos(Producto producto)
        {
            try
            {
                lista = VerProductos();
                Producto productoVerificador = lista.Find(x => x.Nombre == producto.Nombre && x.Presentacion == producto.Presentacion && x.Caracteristica == producto.Caracteristica);
                productoVerificador.Cantidad -= producto.Cantidad;
                if (productoVerificador.Cantidad >= 0)
                    extraerExistencias(producto);                
            }
            catch (Exception)
            {
                
            }
        }
        public Producto BuscarProducto(Producto producto)
        {
            lista.Clear();
            lista = VerProductos();
            if (lista == null)
            {
                return null;
            }
            else
            {                
                foreach (Producto row in lista)
                {
                    if (producto.Nombre == row.Nombre && producto.Presentacion == row.Presentacion)
                    {
                        Producto productoBuscado = new Producto();
                        productoBuscado.Cantidad = row.Cantidad;
                        productoBuscado.Precio = Convert.ToInt32(row.Precio);
                        return productoBuscado;
                    }
                }
                return null;
            }
        }
        public string RegistrarPresentacion(string presentacion, int precio)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarPresentacion", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xnom_presentacion", presentacion));                    
                    cmd.Parameters.Add(new MySqlParameter("xprecio", precio));                    

                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "Exito";
                    }
                    else
                    {
                        return "Ha ocurrido un problema";
                    }
                }
                else
                {
                    return "Error al Conectar con la Base Datos";
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
        public int VerPrecioPorPresentacion(string presentacion)
        {
            dataTable = cargarRegistros("verPresentaciones");
            if (dataTable == null)
            {
                return 0;
            }
            else
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Producto producto = new Producto();
                    producto.Presentacion = row["NOM_PRESENTACION"].ToString();
                    if(presentacion == producto.Presentacion)
                    {
                        producto.Precio = Convert.ToInt32(row["PRECIO"].ToString());
                        return producto.Precio;
                    }                    
                }
            }
            return 0;
        }

        public List<string> VerPresentaciones()
        {
            List<string> precios = new List<string>();
            dataTable = cargarRegistros("verPresentaciones");
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                precios.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    precios.Add(row["NOM_PRESENTACION"].ToString());
                }
                return precios;
            }
        }
        public List<string> verProductosPorConfiguracion(string presentacion, string caracteristica)
        {
            List<string> productos = new List<string>();
            dataTable = cargarRegistros("verProductosPorConfiguracion", presentacion, caracteristica);
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                productos.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    productos.Add(row["DESCRIPCION"].ToString());
                }
                return productos;
            }
        }

        public List<string> verCaracteristicas()
        {
            List<string> caracteristicas = new List<string>();
            dataTable = cargarRegistros("verCaracteristicas");
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                caracteristicas.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    caracteristicas.Add(row["CARACTERISTICA"].ToString());
                }
                return caracteristicas;
            }
        }
        public List<Producto> VerConfigurados()
        {
            /*
            TablaConfiguradosTableAdapter tabla = new TablaConfiguradosTableAdapter();
            TablaConfiguradosDataTable tablita = tabla.VerTodo();
            DataRow row;
            lista.Clear();
            for (int i = 0; i < tablita.Count; i++)
            {
                row = tablita.Rows[i];
                Producto producto = new Producto();
                producto.Presentacion = row["Presentacion"].ToString();
                producto.Precio = Convert.ToInt32(row["Precio"].ToString());
                lista.Add(producto);
            }*/
            return lista;
            
        }
        public string RegistrarConfiguracion(Producto producto)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarProducto", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", producto.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("xnom_presentacion", producto.Presentacion));
                    cmd.Parameters.Add(new MySqlParameter("xcaracteristica", producto.Caracteristica));
                    cmd.Parameters.Add(new MySqlParameter("xexistencias", producto.Cantidad));
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "Exito";
                    }
                    else
                    {
                        return "Ha ocurrido un problema";
                    }
                }
                else
                {
                    return "Error al Conectar con la Base Datos";
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
        public List<Producto> VerPorPresentacion (string presentacion)
        {
            lista.Clear();
            lista = VerProductos();
            if (lista == null)
            {
                return null;
            }
            else
            {
                foreach (Producto row in lista)
                {
                    if (presentacion == row.Presentacion)
                    {
                        Producto producto = new Producto();
                        producto.Nombre = row.Nombre;
                        producto.Presentacion = row.Presentacion;
                        producto.Caracteristica = row.Caracteristica;
                        producto.Precio = row.Precio;
                        lista.Add(producto);
                    }
                }
                return lista;
            }
            
        }

    }

    
}
