using System;
using System.Collections.Generic;
using Entidades;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace CapaDatos
{
    public class RepositorioMovimientos : Conexion
    {
        public MySqlCommand cmd;
        DataTable dataTable;
        List<Movimientos> lista = new List<Movimientos>();
        public DataTable cargarMovimientosPorFecha(DateTime fechaA, DateTime fechaB)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand("verMovimientosPorFecha", connection);
                    cmd.Parameters.Add(new MySqlParameter("xfechaInicial", fechaA));
                    cmd.Parameters.Add(new MySqlParameter("xfechaFinal", fechaB));
                    cmd.CommandType = CommandType.StoredProcedure;
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
        public List<Movimientos> VerMovimientos()
        {
            dataTable = cargarRegistros("cargarMovimientos");
            if (dataTable == null)
            {
                return lista = null;
            }
            else
            {
                Movimientos movimientos;
                lista.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    movimientos = new Movimientos();
                    movimientos.Razon = row["RAZON"].ToString();
                    movimientos.Gasto = int.Parse( row["GASTO"].ToString());
                    movimientos.Ingreso = int.Parse( row["INGRESO"].ToString());
                    movimientos.Total = int.Parse( row["TOTAL"].ToString());
                    movimientos.Fecha = DateTime.Parse( row["FECHA"].ToString());
                    lista.Add(movimientos);
                }
                return lista;
            }
        }
        public List<Movimientos> VerPorFechas(DateTime fechaA, DateTime fechaB)
        {
            dataTable = cargarMovimientosPorFecha(fechaA, fechaB);
            if (dataTable == null)
            {
                return lista = null;
            }
            else
            {
                Movimientos movimientos;
                lista.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    movimientos = new Movimientos();
                    movimientos.Razon = row["RAZON"].ToString();
                    movimientos.Gasto = int.Parse(row["GASTO"].ToString());
                    movimientos.Ingreso = int.Parse(row["INGRESO"].ToString());
                    movimientos.Total = int.Parse(row["TOTAL"].ToString());
                    movimientos.Fecha = DateTime.Parse(row["FECHA"].ToString());
                    lista.Add(movimientos);
                }
                return lista;
            }
        }
        public List<Movimientos> ConcultarTotal()
        {
            List<Movimientos> movimientos = new List<Movimientos>();
            VerMovimientos();
            if (lista == null)
            {
                return null;
            }
            else
            {
                Movimientos movimiento = new Movimientos();                               
                foreach (Movimientos row in lista)
                {                                
                    movimiento.Total = row.Total;
                    movimientos.Add(movimiento);
                }
                return movimientos;            
            }
        }
        public string RegistrarMovimiento(Movimientos movimiento)
        {            
            try
            {
                if (conectar())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    cmd = new MySqlCommand("registrarMovimiento", connection, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xrazon", movimiento.Razon));
                    cmd.Parameters.Add(new MySqlParameter("xingreso", movimiento.Ingreso));
                    cmd.Parameters.Add(new MySqlParameter("xgasto", movimiento.Gasto));
                    cmd.Parameters.Add(new MySqlParameter("xtotal", movimiento.Total));

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
    }
}
