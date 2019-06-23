using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        public MySqlConnection connection;
        private const string servidor = "localhost";
        private const string puerto = "3306";
        private const string usuario = "root";
        private const string password = "1981";
        private const string database = "tienda_dulces";
        public MySqlCommand cmd;

        //Cadena de conexion
        public string connectionString =
            String.Format("server={0};port={1};user id={2}; password={3}; " +
            "database={4}; pooling=false;SslMode=none;" +
            "Allow Zero Datetime=False;Convert Zero Datetime=True",
            servidor, puerto, usuario, password, database);

        public bool conectar()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

        public bool desConectar()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }
        public DataTable llenarDataTable(MySqlCommand cmd)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            mySqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable cargarRegistros(string procedimiento)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(procedimiento, connection);
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

        public DataTable cargarRegistros(string procedimiento, string presentacion, string caracteristica)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(procedimiento, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xpresentacion", presentacion));
                    cmd.Parameters.Add(new MySqlParameter("xcaracteristica", caracteristica));
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

        public DataTable cargarRegistros(string procedimiento, string presentacion)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(procedimiento, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xnom_presentacion", presentacion));
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

        public DataTable cargarPreciosPorCliente(string procedimiento, string cod_cliente)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(procedimiento, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("xcod_cliente", cod_cliente));
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

    }
}
