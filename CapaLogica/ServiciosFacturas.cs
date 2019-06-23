
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Entidades;
using CapaDatos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;

namespace CapaLogica
{
    public class ServiciosFacturas
    {
        RepositorioFacturas repositorioFacturas = new RepositorioFacturas();
        System.Drawing.Image imgFactura = Properties.Resources.factura;
        System.Drawing.Font LetraMediana = new System.Drawing.Font("Source Sans", 14, FontStyle.Bold);
        System.Drawing.Font LetraPequeña = new System.Drawing.Font("Source Sans Pro", 9, FontStyle.Regular);
        SolidBrush brush = new SolidBrush(Color.FromArgb(42,60,73));
        int[] PosCodigo = { 160, 232 };
        int[] PosFecha = { 120, 253 };
        int[] PosTotal = { 407, 535 };        
        int[] PosColumnas = { 65, 276, 357, 447 };
        int FilaInicial = 330;
        int IntervaloX = 28;
        double Total = 0;


        public System.Drawing.Image GenerarImgFactura(Factura facturas)
        {
            Graphics graficos = Graphics.FromImage(imgFactura);
            StringFormat formato = new StringFormat();
            formato.LineAlignment = StringAlignment.Center;
            formato.Alignment = StringAlignment.Center;
            graficos.DrawString(facturas.numero.ToString(), LetraMediana, brush, new Point(PosCodigo[0], PosCodigo[1]));
            graficos.DrawString(facturas.Fecha.Date.ToString("dd/MM/yyyy"), LetraPequeña, brush, new Point(PosFecha[0], PosFecha[1]));
            int k = 0;
            int contador = 0;
            facturas.Productos = agruparCantidades(facturas.Productos);
            for (int i = FilaInicial; contador < facturas.Productos.Count; i = i + IntervaloX)
            {
                graficos.DrawString(facturas.Productos[k].Presentacion.ToString(), LetraPequeña, brush, new Point(PosColumnas[0], i));
                graficos.DrawString(facturas.Productos[k].Cantidad.ToString(), LetraPequeña, brush, new Point(PosColumnas[1], i));
                graficos.DrawString((facturas.Productos[k].Precio / facturas.Productos[k].Cantidad).ToString(), LetraPequeña, brush, new Point(PosColumnas[2], i));
                graficos.DrawString(facturas.Productos[k].Precio.ToString(), LetraPequeña, brush, new Point(PosColumnas[3], i));
                contador++;
                k++;
            }
            graficos.DrawString(CalcularTotal(facturas).ToString(), LetraMediana, brush, new Point(PosTotal[0], PosTotal[1]));
            return imgFactura;
        }

        private List<Producto> agruparCantidades(List<Producto> lista)
        {            
            List<Producto> agrupados = new List<Producto>();
            foreach(Producto p in lista)
            {
                Producto producto = new Producto();
                if (agrupados.Count == 0)
                {
                    producto.Presentacion = p.Presentacion;
                    producto.Cantidad = p.Cantidad;
                    producto.Precio = p.Precio * p.Cantidad;
                    agrupados.Add(producto);
                }
                else
                {                    
                    if(agrupados.Find(x => x.Presentacion == p.Presentacion) != null)
                    {
                        agrupados.Find(x => x.Presentacion == p.Presentacion).Precio =
                            (agrupados.Find(x => x.Presentacion == p.Presentacion).Precio / agrupados.Find(x => x.Presentacion == p.Presentacion).Cantidad);
                        agrupados.Find(x => x.Presentacion == p.Presentacion).Cantidad += p.Cantidad;
                        agrupados.Find(x => x.Presentacion == p.Presentacion).Precio =
                            (agrupados.Find(x => x.Presentacion == p.Presentacion).Precio * agrupados.Find(x => x.Presentacion == p.Presentacion).Cantidad);
                    }
                    else
                    {
                        producto.Presentacion = p.Presentacion;
                        producto.Cantidad = p.Cantidad;
                        producto.Precio = p.Precio * p.Cantidad;
                        agrupados.Add(producto);
                    }
                }
            }

            return agrupados;
        }

        private void GenerarDocumentoFactura(Factura factura)
        {
            /*ServiciosFacturas serviciosFacturas = new ServiciosFacturas();
            System.Drawing.Image facturaNormal = Properties.Resources.factura;
            System.Drawing.Image fact = serviciosFacturas.GenerarImgFactura(factura);
            Document documento = new Document();
            //"C:\\Users\\Usuario\\source\\Workspaces\\Sistema de gestion para distribuidora de dulces\\TiendaDulces\\CapaPresentacion\\bin\\Debug"
            //C:/Users/Usuario/factura.pdf
            
            using (var stream = new FileStream("Factura.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(documento, stream);
                documento.Open();
                var image = iTextSharp.text.Image.GetInstance(fact, fact.RawFormat);
                documento.Add(image);
                documento.Close();
            }
            Process.Start(Application.StartupPath + "//Factura.pdf"); */           
        }        
        private double CalcularTotal(Factura factura)
        {
            for (int i = 0; i < factura.Productos.Count; i++)
            {
                Total = Total + (factura.Productos[i].Precio);
            }
            return Total;
        }
        public int NuevaFactura(Factura factura, List<Producto> productos, bool verificador)
        {
            int codigoFactura = repositorioFacturas.NuevaFactura(factura, productos);
            factura.numero = codigoFactura;
            if (verificador)
                GenerarDocumentoFactura(factura);

            return codigoFactura;
        }
        public bool modificarDetallesFactura(int codMFactura,List<Producto> productos)
        {
            try
            {
                if (repositorioFacturas.borrarDetallesFactura(codMFactura))
                {
                    foreach (var item in productos)
                    {
                        repositorioFacturas.RegistrarDetalle(codMFactura, item);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public List<Producto> verDetallesFactura( int codMFactura)
        {
            DataTable dataTable = new DataTable();
            dataTable = repositorioFacturas.verDetallesFactura(codMFactura);
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                List<Producto> detalles = new List<Producto>();
                foreach (DataRow item in dataTable.Rows)
                {
                    Producto detalle = new Producto();
                    detalle.Cantidad = int.Parse(item["cantidad"].ToString());
                    detalle.Caracteristica = item["caracteristica"].ToString();
                    detalle.Nombre = item["descripcion"].ToString();
                    detalle.Precio = int.Parse(item["precio_unitario"].ToString());
                    detalle.Presentacion = item["nom_presentacion"].ToString();
                    detalles.Add(detalle);
                }
                return detalles;
            }
        }
        public int verCodFactura()
        {
            return repositorioFacturas.verCodUltimaMfactura();
        }
    }
}
