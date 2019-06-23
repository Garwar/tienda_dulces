using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class RepositorioPedidos : Conexion
    {
        DataTable dataTable = new DataTable();

        public bool GenerarPedido(Pedido pedido)
        {
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarPedido", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcod_cliente", pedido.Cliente));
                    cmd.Parameters.Add(new MySqlParameter("xtotal", pedido.Total));
                    cmd.Parameters.Add(new MySqlParameter("XDESCUENTO", pedido.descuento));
                    cmd.Parameters.Add(new MySqlParameter("XCOD_MFACTURA", pedido.CodigoFactura));
                    cmd.Parameters.Add(new MySqlParameter("XFECHA_GENERACION", pedido.FechaGeneracion));
                    cmd.Parameters.Add(new MySqlParameter("XFECHA_ENTREGA", pedido.FechaEntrega));
                    cmd.Parameters.Add(new MySqlParameter("XADELANTO", pedido.Adelanto));
                    cmd.Parameters.Add(new MySqlParameter("XPENDIENTE", pedido.Pendiente));
                    cmd.Parameters.Add(new MySqlParameter("XESTADO", pedido.Estado));
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
        
        public bool RegistrarEntrega(Pedido pedido)
        {
            return GenerarPedido(pedido);
        }
        public List<Pedido> VerTodo()
        {
            List<Pedido> lista = new List<Pedido>();
            /*TablaPedidosTableAdapter tabla = new TablaPedidosTableAdapter();
            List<Pedido> lista = new List<Pedido>();
            TablaPedidosDataTable tablita = tabla.VerTodo();
            for (int i = 0; i < tablita.Count; i++)
            {
                DataRow row = tablita.Rows[i];
                Pedido pedido = new Pedido();
                pedido.Codigo = Convert.ToInt16(row["codigo"].ToString());
                pedido.Cliente = row["cliente"].ToString();
                pedido.FechaEntrega = Convert.ToDateTime(row["entrega"].ToString());
                pedido.FechaGeneracion = Convert.ToDateTime(row["realizacion"].ToString());
                pedido.CodigoFactura = Convert.ToInt16(row["factura"].ToString());
                pedido.Total = Convert.ToInt32(row["total"].ToString());
                pedido.Adelanto = Convert.ToInt32(row["adelanto"].ToString());
                pedido.Pendiente = Convert.ToInt32(row["pendiente"].ToString());
                pedido.Estado = row["estado"].ToString();
                lista.Add(pedido);
            }*/
            return lista;
        }
        public DataTable ConsultarPorPedido(int codMFactura)
        {
            
            dataTable = cargarDetallesPedido(codMFactura);
            
            return dataTable;
        }
        public DataTable cargarDetallesPedido(int codMFactura)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand("verDFactura", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcod_mfactura", codMFactura));
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
        public List<Pedido> ConsultarPorCliente(string cliente)
        {
            List<Pedido> lista = new List<Pedido>();
            /*TablaPedidosTableAdapter tabla = new TablaPedidosTableAdapter();            
            TablaPedidosDataTable tablita = tabla.ConsultarPorCliente(cliente);
            for (int i = 0; i < tablita.Count; i++)
            {
                DataRow row = tablita.Rows[i];
                Pedido pedido = new Pedido();
                pedido.Codigo = Convert.ToInt16(row["codigo"].ToString());
                pedido.Cliente = row["cliente"].ToString();
                pedido.FechaEntrega = Convert.ToDateTime(row["entrega"].ToString());
                pedido.FechaGeneracion = Convert.ToDateTime(row["realizacion"].ToString());
                pedido.CodigoFactura = Convert.ToInt16(row["factura"].ToString());
                pedido.Total = Convert.ToInt32(row["total"].ToString());
                pedido.Adelanto = Convert.ToInt32(row["adelanto"].ToString());
                pedido.Pendiente = Convert.ToInt32(row["pendiente"].ToString());
                pedido.Estado = row["estado"].ToString();
                lista.Add(pedido);
            }*/
            return lista;
        }

        public DataTable ConsultarPorEstado(string estado)
        {
            return cargarRegistros("verPedidosPendientes");
            
        }

        public List<Pedido> ConsultarPorFecha(DateTime fecha)
        {
            List<Pedido> lista = new List<Pedido>();
            /*TablaPedidosTableAdapter tabla = new TablaPedidosTableAdapter();            
            TablaPedidosDataTable tablita = tabla.ConsultarPorFecha(fecha);
            for (int i = 0; i < tablita.Count; i++)
            {
                Pedido pedido = new Pedido();
                DataRow row = tablita.Rows[i];
                pedido.Cliente = row["cliente"].ToString();
                pedido.FechaEntrega = Convert.ToDateTime(row["entrega"].ToString());
                pedido.FechaGeneracion = Convert.ToDateTime(row["realizacion"].ToString());
                pedido.CodigoFactura = Convert.ToInt16(row["factura"].ToString());
                pedido.Total = Convert.ToInt32(row["total"].ToString());
                pedido.Adelanto = Convert.ToInt32(row["adelanto"].ToString());
                pedido.Pendiente = Convert.ToInt32(row["pendiente"].ToString());
                pedido.Estado = row["estado"].ToString();
                lista.Add(pedido);
            }*/
            return lista;
        }

    }
}
