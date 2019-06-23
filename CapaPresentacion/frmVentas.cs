using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaLogica;
using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        int cuenta = 0;
        List<Producto> lista = new List<Producto>();
        ServiciosProducto servicios = new ServiciosProducto();
        ServiciosFacturas serviciosFacturas = new ServiciosFacturas();
        List<string> presentaciones;
        List<string> caracteristicas;
        public frmVentas()
        {
            InitializeComponent();
            llenarPresentaciones();
            llenarCaracteristicas();            
        }

        public void llenarPresentaciones()
        {
            presentaciones = servicios.VerPresentaciones();
            if (presentaciones != null)
            {
                for (int i = 0; i < presentaciones.Count; i++)
                {
                    txtPresentacion.Items.Add(presentaciones[i]);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar las presentaciones", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
        public void llenarCaracteristicas()
        {
            caracteristicas = servicios.verCaracteristicas();
            if (caracteristicas != null)
            {
                for (int i = 0; i < caracteristicas.Count; i++)
                {
                    txtCaracteristica.Items.Add(caracteristicas[i]);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar las caracteristicas", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void bunifuCircleProgressbar1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panelVentas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }
        private void borrarDelaLista(Producto producto)
        {
            foreach (Producto p in lista)
            {
                if (p.Nombre==producto.Nombre && p.Presentacion == producto.Presentacion)
                {
                    lista.Remove(p);
                    break;
                }
            }
        }
        private void BotonAgregarClick(object sender, EventArgs e)
        {
            MessageBox.Show(agregarProductos(txtProducto.Text, txtCaracteristica.Text, txtPresentacion.Text, Convert.ToInt32(txtCantidad.Value)));                    
            Limpiar();
        }

        public string agregarProductos(string nombre, string caracteristica, string presentacion, int cantidad)
        {
            if (string.IsNullOrEmpty(presentacion) || string.IsNullOrEmpty(caracteristica) ||
                string.IsNullOrEmpty(nombre) || cantidad <= 0)
            {
                return "Debe seleccionar las opciones disponibles";
            }
            else
            {
                Producto producto = mapearProducto(presentacion, nombre, caracteristica, cantidad);
                ServiciosProducto servicios = new ServiciosProducto();
                Producto ProductoStock = servicios.BuscarProducto(producto);
                if (lista.Count == 0)
                {
                    if (ProductoStock != null && producto.Cantidad <= ProductoStock.Cantidad)
                    {
                        TablaVentas.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, producto.Cantidad, producto.Precio);
                        cuenta = cuenta + (producto.Cantidad * producto.Precio);
                        txtprecio.Text = cuenta.ToString();
                        lista.Add(producto);
                        return "Ok";
                    }
                    else if (producto.Cantidad > ProductoStock.Cantidad)
                    {
                        return "La cantidad deseada excede la(las) " + ProductoStock.Cantidad + " unidad(es) tenemos en inventario";
                    }
                    else
                    {
                        return "Lo sentimos, algun dato esta mal registrado";
                    }
                }
                else
                {
                    verificarEnLista(producto);
                }
            }
            return "";
        }

        private Producto mapearProducto(string presentacion, string nombre, string caracteristica, int cantidad)
        {
            ServiciosProducto servicios = new ServiciosProducto();
            Producto producto = new Producto();                       
            producto.Nombre = nombre;
            producto.Presentacion = presentacion;
            producto.Caracteristica = caracteristica;
            producto.Cantidad = cantidad;            
            Producto ProductoStock = servicios.BuscarProducto(producto);
            producto.Precio = ProductoStock.Precio;
            return producto;
        }
        
        private void verificarEnLista(Producto producto)
        {
            
            ServiciosProducto servicios = new ServiciosProducto();
            Producto productoStock = servicios.BuscarProducto(producto);
            bool band = false;            
            TablaVentas.Rows.Clear();
            cuenta = 0;
            foreach (Producto p in lista)
            {                
                if (p.Nombre == producto.Nombre && p.Presentacion == producto.Presentacion && p.Caracteristica == producto.Caracteristica)
                {
                    p.Cantidad += producto.Cantidad;                    
                    band = true;
                    if (p.Cantidad > productoStock.Cantidad)
                    {
                        p.Cantidad = productoStock.Cantidad;
                        MessageBox.Show("La cantidad deseada excede la(las) " + productoStock.Cantidad + " unidad(es) tenemos en inventario, se asigno la totalidad de unidades");
                    }
                }                
             
                TablaVentas.Rows.Add(p.Nombre, p.Presentacion, p.Caracteristica, p.Cantidad, p.Precio);            
                cuenta = cuenta + (p.Cantidad * p.Precio);                
            }
            if (!band)
            {
                if (producto.Cantidad > productoStock.Cantidad)
                {
                    producto.Cantidad = productoStock.Cantidad;
                    MessageBox.Show("La cantidad deseada excede la(las) " + productoStock.Cantidad + " unidad(es) tenemos en inventario, se asigno la totalidad de unidades");
                }
                else
                {
                    lista.Add(producto);
                    cuenta = cuenta + (producto.Cantidad * producto.Precio);
                    TablaVentas.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, producto.Cantidad, producto.Precio);
                }
            }
            txtprecio.Text = cuenta.ToString();
        }
        private void Limpiar()
        {
            txtProducto.Text = "";
            txtPresentacion.Text = "";
            txtCaracteristica.Text = "";
            txtCantidad.Value = 0;
            Refresh();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Agregue productos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ServiciosFacturas serviciosFacturas = new ServiciosFacturas();                
                Factura factura = new Factura();                
                factura.Cliente = "1065840833";
                factura.Valor = int.Parse(txtprecio.Text);
                factura.Estado = "Pagado";
                factura.Fecha = DateTime.Today;                
                CargarProductos(factura);
                serviciosFacturas.NuevaFactura(factura, factura.Productos, verificadorFactura.Checked);
                MapearMovimiento(cuenta);
                limpiar();
            }
        }

        private void MapearMovimiento(int cuenta)
        {
            ServiciosMovimientos movimientos = new ServiciosMovimientos();
            Movimientos movimiento = new Movimientos();
            movimiento.Fecha = DateTime.Today;
            movimiento.Ingreso = cuenta;
            movimiento.Gasto = 0;
            movimiento.Razon = "Venta de productos ";
            movimiento.Total = movimientos.ConsultarTotal()[movimientos.ConsultarTotal().Count - 1].Total + cuenta;
            mensaje(movimientos.RegistrarMovimiento(movimiento));
        }
        private void limpiar()
        {
            lista.Clear();
            TablaVentas.Rows.Clear();
            txtprecio.Text = "";
        }

        private void CargarProductos(Factura factura)
        {            
            foreach (Producto producto in lista)
            {
                factura.Productos.Add(producto);
                RestarExistencias(producto);
            }
        }

        private void RestarExistencias(Producto producto)
        {
            ServiciosProducto servicios = new ServiciosProducto();
            servicios.MenosProductos(producto);
        }
        private void mensaje(string mensaje)
        {
            if (mensaje.Equals("Exito"))
            {
                MessageBox.Show("Venta realizada con exito total de: " + cuenta);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al tratar de registrar el movimiento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (lista.Count != 0)
            {
                DialogResult result = MessageBox.Show("Seguro que desea salir? aún tiene productos en la lista", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    Close();
                }
            }
            else
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                Close();
            }
            
        }

        private void txtPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProducto.Items.Clear();
            if (txtCaracteristica.Text != String.Empty)
            {
                List<string> productosPorPresentacion = servicios.verProductosPorConfiguracion(txtPresentacion.Text, txtCaracteristica.Text);
                if (productosPorPresentacion != null)
                {
                    for (int i = 0; i < productosPorPresentacion.Count; i++)
                    {
                        txtProducto.Items.Add(productosPorPresentacion[i]);
                    }
                }
            }            
        }

        private void txtCaracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProducto.Items.Clear();            
            if (txtPresentacion.Text != String.Empty)
            {
                List<string> productosPorPresentacion = servicios.verProductosPorConfiguracion(txtPresentacion.Text, txtCaracteristica.Text);
                if (productosPorPresentacion != null)
                {
                    for (int i = 0; i < productosPorPresentacion.Count; i++)
                    {
                        txtProducto.Items.Add(productosPorPresentacion[i]);
                    }
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (TablaVentas.Rows.Count !=0)
            {
                Producto producto;
                for (int i = 0; i < TablaVentas.Rows.Count; i++)
                {                
                    for (int j = 0; j < TablaVentas.Columns.Count; j++)
                    {
                        if (j==TablaVentas.Columns.Count -1)
                        {
                            bool quitar = Convert.ToBoolean(TablaVentas[j,i].Value);
                            if (quitar)
                            {
                                producto = new Producto();
                                producto.Nombre = TablaVentas[0, i].Value.ToString();
                                producto.Presentacion = TablaVentas[1, i].Value.ToString();
                                producto.Caracteristica = TablaVentas[2, i].Value.ToString();
                                producto.Cantidad = int.Parse( TablaVentas[3, i].Value.ToString());
                                producto.Precio = int.Parse(TablaVentas[4, i].Value.ToString());
                                cuenta -= producto.Cantidad * producto.Precio;
                                txtprecio.Text = (cuenta).ToString();
                                borrarDelaLista(producto);
                                TablaVentas.Rows.Remove(TablaVentas.CurrentRow);
                            }
                        }                    
                    }               
                }

            }
                /*
            for (int i = 0; i < TablaVentas.Rows.Count; i++)
            {
                bool quitar = Convert.ToBoolean(TablaVentas.CurrentRow.Cells["Estado"].Value);
                if (quitar )
                {
                    TablaVentas.Rows.Remove(TablaVentas.CurrentRow);
                }
            }*/
        }

        private void TablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)TablaVentas.Rows[e.RowIndex].Cells["Estado"];
                if (Convert.ToBoolean(check.Value) == true)
                {
                    check.Value = false;
                    TablaVentas.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    check.Value = true;
                    TablaVentas.Rows[e.RowIndex].Selected = true;
                }
            }
        }
    }
}