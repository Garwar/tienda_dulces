using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Entidades;

namespace CapaDatos
{
    public class RepositorioFacturas : Conexion
    {
        List<Producto> lista = new List<Producto>();
        DataTable dataTable;

        public int NuevaFactura(Factura factura,List<Producto> productos)
        {
            int codMFactura = registrarMaestra(factura);
            if (codMFactura!=-1 && codMFactura!=factura.numero)
            {                
                foreach (Producto producto in productos)
                {
                    RegistrarDetalle(codMFactura, producto);
                }
            }                
            return codMFactura;
        }

        public int verCodUltimaMfactura()
        {
            dataTable = cargarRegistros("verCodMfactura");
            if (dataTable == null)
            {
                return 0;
            }
            else
            {                
                return Convert.ToInt32(dataTable.Rows[0][0].ToString());
            }
        }
        public int registrarMaestra(Factura factura)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarMFactura", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcod_cliente", factura.Cliente));
                    cmd.Parameters.Add(new MySqlParameter("xtotal", factura.Valor));
                    cmd.Parameters.Add(new MySqlParameter("XFECHA", factura.Fecha));
                    cmd.Parameters.Add(new MySqlParameter("XESTADO", factura.Estado));
                    cmd.Parameters.Add(new MySqlParameter("XCOD_MFACTURA", factura.numero));
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return int.Parse(llenarDataTable(cmd).Rows[0]["XCOD_MFACTURA"].ToString());
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                desConectar();
            }
        }
        public bool borrarDetallesFactura(int cod_MFactura)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("borrarDetallesFactura", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add(new MySqlParameter("XCOD_MFACTURA", cod_MFactura));
                    
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                desConectar();
            }
        }
        public DataTable verDetallesFactura(int codMFactura)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();
                    cmd = new MySqlCommand("verDFactura", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("XCOD_MFACTURA", codMFactura));
                    
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        return llenarDataTable(cmd);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                desConectar();
            }
        }
        public string RegistrarDetalle(int codMFactura, Producto producto)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarDFactura", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcod_mfactura", codMFactura));
                    cmd.Parameters.Add(new MySqlParameter("xnom_presentacion", producto.Presentacion));
                    cmd.Parameters.Add(new MySqlParameter("xdescripcion", producto.Nombre));
                    cmd.Parameters.Add(new MySqlParameter("xcaracteristica", producto.Caracteristica));
                    cmd.Parameters.Add(new MySqlParameter("xcantidad", producto.Cantidad));
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
    }
}
