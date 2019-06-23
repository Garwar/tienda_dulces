using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Drawing;
using Entidades;
using System.Data;

namespace CapaLogica
{
    public class ServicioPedido
    {
        
        List<Producto> ListaProductos = new List<Producto>();
        RepositorioPedidos repositorio = new RepositorioPedidos();
        public string GenerarPedido(Pedido pedido)
        {
            string Mensaje;            
            try
            {
                repositorio.GenerarPedido(pedido);
                Mensaje = "Pedido Generado correctamente.";

            }
            catch (Exception)
            {
                Mensaje = "Por algun motivo no se pudo registrar el pedido.";
            }
            return Mensaje;
        }
        public string ConfirmarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.Estado == "Entregado")
                {
                    Factura factura = new Factura();
                    ServiciosFacturas servicio = new ServiciosFacturas();
                    factura.numero = pedido.CodigoFactura;
                    factura.Valor = pedido.Total;
                    factura.Fecha = pedido.FechaEntrega;
                    factura.Productos = pedido.productos;
                    pedido.Pendiente = 0;
                    if (ConfirmarExistencias(pedido.CodigoFactura))
                    {

                        //servicio.GenerarFactura(factura);
                        if (repositorio.RegistrarEntrega(pedido))
                        {
                            return "Exito";
                        }
                        else
                            return "Error";

                    }
                    else
                    {
                        return "Existencias";
                    }
                }
                else
                {
                    /*pedido.Estado = "Olvidado";
                    repositorio.RegistrarEntrega(pedido);*/
                    return "Exito";
                }
            }
            catch (Exception)
            {
                
            }
            return "Error";
        }
        public void ConfirmarPedido(Pedido pedido, bool verificador)
        {
            try
            {
                if (pedido.Estado == "Entregado")
                {
                    Factura factura = new Factura();
                    ServiciosFacturas servicio = new ServiciosFacturas();
                    factura.numero = 1;
                    factura.Valor = pedido.Total;
                    factura.Fecha = pedido.FechaEntrega;
                    factura.Productos = pedido.productos;
                    pedido.Pendiente = 0;
                    if (ConfirmarExistencias(pedido.Codigo) == true)
                    {
                        repositorio.RegistrarEntrega(pedido);
                        //servicio.GenerarFactura(factura);
                    }
                    else if(verificador == true)
                    {
                        repositorio.RegistrarEntrega(pedido);
                        //servicio.GenerarFactura(factura);
                    }
                }
                else
                {
                    pedido.Estado = "Olvidado";
                    repositorio.RegistrarEntrega(pedido);
                }
            }
            catch (Exception)
            {

            }

        }

        private DataTable ConsultarPorPedido(int codigo)
        {
            return repositorio.ConsultarPorPedido(codigo);
        }

        private bool ConfirmarExistencias(int codigo)
        {
            ServiciosProducto servicios = new ServiciosProducto();
            DataTable pedido = ConsultarPorPedido(codigo);
            if (pedido != null)
            {
                foreach (DataRow item in pedido.Rows)
                {
                    if (int.Parse(item["Cantidad"].ToString()) > int.Parse(item["Existencias"].ToString()))
                    {
                        return false;
                    }
                }/*
                for (int i = 0; i < pedido.Count; i++)
                {
                    Producto producto = new Producto();
                    producto.Nombre = pedido[i].Nombre;
                    producto.Presentacion = pedido[i].Presentacion;
                    Producto stock = servicios.BuscarProducto(producto);
                    if ((stock.Cantidad - pedido[i].Cantidad) < 0)
                    {
                        return false;
                    }
                }*/
            }
            else
                return false;
            return true;
        }
        public List<Pedido> VerTodo()
        {
            return repositorio.VerTodo();
        }
        public List<Pedido> ConsultarPorCliente(string cliente)
        {
            return repositorio.ConsultarPorCliente(cliente);
        }

        public List<Pedido> ConsultarPorEstado(string estado)
        {
            List<Pedido> lista = new List<Pedido>();
            DataTable dataTable = new DataTable();
            ServiciosFacturas serviciosFacturas = new ServiciosFacturas();
            dataTable = repositorio.ConsultarPorEstado(estado);
            if (dataTable == null)
            {
                return lista = null;
            }
            else
            {
                Pedido pedido;
                lista.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    pedido = new Pedido();
                    pedido.Codigo = int.Parse(row["COD_PEDIDO"].ToString());
                    pedido.Cliente = row["COD_CLIENTE"].ToString();
                    pedido.FechaGeneracion = DateTime.Parse(row["FECHA_GENERACION"].ToString());
                    pedido.FechaEntrega = DateTime.Parse(row["FECHA_ENTREGA"].ToString());
                    pedido.CodigoFactura = int.Parse(row["COD_FACTURA"].ToString());
                    pedido.Total = double.Parse(row["TOTAL"].ToString());
                    pedido.descuento = double.Parse(row["DESCUENTO"].ToString());
                    pedido.Adelanto = double.Parse(row["ADELANTO"].ToString());
                    pedido.Pendiente = double.Parse(row["PENDIENTE"].ToString());
                    pedido.productos = serviciosFacturas.verDetallesFactura(pedido.CodigoFactura);
                    lista.Add(pedido);
                }
                return lista;
            }
        }

        public List<Pedido> ConsultarPorFecha(DateTime fecha)
        {
            return repositorio.ConsultarPorFecha(fecha);
        }
    }
}
