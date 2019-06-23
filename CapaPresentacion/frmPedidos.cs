using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using Entidades;

namespace CapaPresentacion
{
    public partial class frmPedidos : Form
    {
        ServiciosProducto serviciosProducto = new ServiciosProducto();
        ServiciosCliente serviciosCliente = new ServiciosCliente();
        ServicioPedido servicioPedido = new ServicioPedido();
        ServiciosFacturas serviciosFacturas = new ServiciosFacturas();
        ServiciosMovimientos serviciosMovimiento = new ServiciosMovimientos();
        Cliente clienteActivo = new Cliente();
        frmPrincipal principal = new frmPrincipal();
        private List<Producto> lista = new List<Producto>();
        private List<Producto> Precios = new List<Producto>();
        Pedido pedidoAModificar = new Pedido();
        List<string> presentaciones;
        List<string> caracteristicas;
        private double cuenta = 0, descuento = 0, cuentaConDescuento;
        Validaciones validaciones = new Validaciones();
        public frmPedidos()
        {
            InitializeComponent();
            btnModificar.Visible = false;
            btnAnular.Visible = false;
        }
        public frmPedidos(Pedido pedido)
        {
            InitializeComponent();
            this.pedidoAModificar = pedido;
            txtAdelanto.Text = pedidoAModificar.Adelanto.ToString();
            txtCliente.Text = pedidoAModificar.Cliente;
            txtDescuento.Value = (Decimal)pedidoAModificar.descuento;
            txtFechaEntrega.Value = pedidoAModificar.FechaEntrega;
            txtPendiente.Text = pedidoAModificar.Pendiente.ToString();
            txtTotal.Text = pedidoAModificar.Total.ToString();
            txtCliente.Enabled = false;
            btnRegistrar.Visible = false;
            serviciosCliente.VerPreciosDeCliente(txtCliente.Text);
            llenarDataGridPedidoAModificar(pedido);
            txtAdelanto.ShortcutsEnabled = false;
        }
        private void llenarDataGridPedidoAModificar(Pedido pedido)
        {
            lista = pedido.productos;
            foreach (var producto in lista)
            {
                TablaPedidos.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, producto.Cantidad, producto.Precio);
                cuenta = cuenta + (producto.Cantidad * producto.Precio);
                txtTotal.Text = cuenta.ToString();
                txtPendiente.Text = (cuenta - double.Parse(txtAdelanto.Text)).ToString();
            }
        }
        public void llenarPresentaciones()
        {
            presentaciones = serviciosProducto.VerPresentaciones();
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
            caracteristicas = serviciosProducto.verCaracteristicas();
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

        private void txtAdelanto_TextChanged(object sender, EventArgs e)
        {
            if (txtAdelanto.Text != "")
                txtPendiente.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtAdelanto.Text)).ToString();
        }

        private void txtDescuento_ValueChanged(object sender, EventArgs e)
        {
            if (txtDescuento.Value == 0 && descuento > 0)
            {
                cuentaConDescuento = cuenta;
                txtTotal.Text = cuenta.ToString();
            }
            else
            {
                descuento = (Convert.ToDouble(txtDescuento.Value) / 100);
                double TotalConDescuento = Convert.ToDouble(cuenta - cuenta * descuento);
                txtTotal.Text = TotalConDescuento.ToString();
                cuentaConDescuento = TotalConDescuento;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtPendiente.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtAdelanto.Text)).ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(registrarPedido(txtCliente.Text, txtDescuento.Value, txtTotal.Text, txtAdelanto.Text, txtPendiente.Text, txtFechaEntrega.Value));            
        }

        public string registrarPedido(string cliente, decimal descuento, string total, string adelanto, string pendiente, DateTime fecha)
        {
            try
            {
                if (validaciones.validarIdentificacion(cliente))
                {
                    if (fecha.Date < DateTime.Today.Date)
                    {
                        MessageBox.Show("No puede registrar un pedido en el pasado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        return "";
                    }
                    else
                    {
                        Pedido pedido = new Pedido();
                        Factura factura = new Factura();
                        factura.Cliente = cliente;
                        factura.Valor = double.Parse(total);
                        factura.Fecha = DateTime.Today.Date;
                        CargarProductos(factura);
                        pedido.Cliente = cliente;
                        pedido.FechaEntrega = fecha;
                        pedido.FechaGeneracion = DateTime.Today;
                        pedido.descuento = Convert.ToDouble(descuento);
                        pedido.Total = Convert.ToDouble(total);
                        pedido.Adelanto = Convert.ToDouble(adelanto);
                        pedido.Pendiente = Convert.ToDouble(pendiente);
                        pedido.productos = lista;
                        pedido.Estado = verificarEstadoPedido(pedido)[0].ToString();
                        factura.Estado = verificarEstadoPedido(pedido)[0].ToString();
                        pedido.CodigoFactura = serviciosFacturas.NuevaFactura(factura, factura.Productos, true);
                        Limpiar();
                        return servicioPedido.GenerarPedido(pedido);
                    }                    
                }
                else
                    MessageBox.Show("Por favor debe digitar un NIT de un cliente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CargarProductos(Factura factura)
        {
            foreach (Producto producto in lista)
            {
                factura.Productos.Add(producto);
            }
        }
        private Object[] verificarEstadoPedido(Pedido pedido)
        {
            Object[] objetos = new Object[2];
            if (pedido.Pendiente != 0)
            {
                objetos[0] = "Pendiente";
                objetos[1] = false;
            }
            else
            {
                objetos[0] = "Pagado";
                objetos[1] = true;
            }            
            return objetos;
        }

        private void registrarMovimiento(bool pagado, Pedido pedido)
        {
            Movimientos movimiento = new Movimientos();
            int total = serviciosMovimiento.ConsultarTotal()[serviciosMovimiento.ConsultarTotal().Count - 1].Total;
            if (Convert.ToBoolean(verificarEstadoPedido(pedido)[1]))
            {                                
                movimiento.Fecha = DateTime.Today;
                movimiento.Ingreso = int.Parse(txtTotal.Text);
                movimiento.Gasto = 0;
                movimiento.Razon = "Pago de pedido No. ";
                movimiento.Total = total + int.Parse(txtTotal.Text);                
            }
            else
            {
                movimiento.Fecha = DateTime.Today;
                movimiento.Ingreso = int.Parse(txtAdelanto.Text);
                movimiento.Gasto = 0;
                movimiento.Razon = "Adelanto de pedido No. ";
                movimiento.Total = total + int.Parse(txtAdelanto.Text);
            }
            serviciosMovimiento.RegistrarMovimiento(movimiento);
        }
        private void Limpiar()
        {
            txtProducto.Text = String.Empty;
            txtCantidad.Value = 0;
            txtPresentacion.Text = String.Empty;
            txtTotal.Text = "0";
            txtPendiente.Text = "0";
            txtAdelanto.Text = "0";
            txtDescuento.Value = 0;
            txtFechaEntrega.Value = DateTime.Today;
            txtCliente.Text = String.Empty;
            TablaPedidos.Rows.Clear();
            Refresh();
        }

        private void btnCargarPrecios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text) || !validaciones.validarIdentificacion(txtCliente.Text))
            {
                MessageBox.Show("Por favor debe digitar un NIT de un cliente.","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                serviciosCliente.VerPreciosDeCliente(txtCliente.Text);
                //clienteActivo.Identificacion = serviciosCliente.VerPreciosDeCliente(txtCliente.Text).Identificacion;
                if (Cliente.Precios == null || Cliente.Precios.Count == 0)
                {
                    MessageBox.Show("Este cliente no tiene precios mayoritas,\n" +
                                    "sus productos tomaran el precio de normal.");
                    Precios = serviciosProducto.VerProductos();
                }
                else
                {
                    MessageBox.Show("Los precios para este cliente mayorista\n" +
                                    "han sido cargados correctamente.");
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }
        private bool VerificarFecha(DateTime fecha)
        {
            if (DateTime.Today == fecha)
            {
                return true;
            }
            return false;
        }
        private Producto mapearProducto(string nombreProducto, string presentacion, string caracteristica, int cantidad)
        {
            Producto producto = new Producto();
            producto.Nombre = nombreProducto;
            producto.Presentacion = presentacion;
            producto.Caracteristica = caracteristica;
            producto.Cantidad = cantidad;
            if (Cliente.Precios.Find(x => x.Presentacion == producto.Presentacion)==null)
            {
                return null;
            }
            else
            {
                producto.Precio= Cliente.Precios.Find(x => x.Presentacion == producto.Presentacion).Precio;
                return producto;
            }
                
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(verificarCampos() == true && Cliente.Precios.Count > 0)
            {
                Producto producto = mapearProducto(txtProducto.Text, txtPresentacion.Text, txtCaracteristica.Text, 
                    Convert.ToInt32(txtCantidad.Value));
                if (producto == null)
                {
                    DialogResult result = MessageBox.Show("El cliente no cuenta con un precio para la presentacion seleccionada" +
                        "\n¿Desea configurarla ahora?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        frmAgregarPrecios form1 = new frmAgregarPrecios();
                        frmClientes modificarCliente = new frmClientes();                        
                        form1.ShowDialog();
                        
                        modificarCliente.registrarPrecios(clienteActivo);
                        clienteActivo.Identificacion = serviciosCliente.VerPreciosDeCliente(txtCliente.Text).Identificacion;
                        btnAgregar_Click(sender, e);
                        
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (lista.Count == 0)
                    {
                        TablaPedidos.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, 
                            producto.Cantidad, producto.Precio);

                        cuenta = cuenta + (producto.Cantidad * producto.Precio);
                        txtTotal.Text = cuenta.ToString();
                        txtPendiente.Text = (cuenta - double.Parse(txtAdelanto.Text)).ToString();
                        lista.Add(producto);
                    }
                    else
                    {
                        verificarEnLista(producto);
                    }
                    limpiar();

                }
            }            
        }

        private bool verificarCampos()
        {
            if(txtProducto.Text == String.Empty || txtPresentacion.Text == String.Empty || txtCaracteristica.Text == String.Empty || Convert.ToInt32(txtCantidad.Value) == 0)
            {
                MessageBox.Show("Por favor verifique que todos los campos esten llenos correctamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void limpiar()
        {
            txtPresentacion.Text = String.Empty;
            txtProducto.Text = String.Empty;
            txtCaracteristica.Text = String.Empty;
            txtCantidad.Value = 0;
            txtProducto.Items.Clear();
        }
        private void verificarEnLista(Producto producto)
        {
            TablaPedidos.Rows.Clear();
            cuenta = 0;
            bool verificador = false;
            for(int i = 0; i < lista.Count; i++)
            {
                Producto p = lista[i];
                if (p.Nombre == producto.Nombre && p.Presentacion == producto.Presentacion && p.Caracteristica == producto.Caracteristica)
                {
                    lista[i].Cantidad = producto.Cantidad;
                    verificador = true;
                }
                TablaPedidos.Rows.Add(p.Nombre, p.Presentacion, p.Caracteristica, p.Cantidad, p.Precio);
                cuenta = cuenta + (p.Cantidad * p.Precio);
            }
            if(verificador == false)
            {
                lista.Add(producto);
                TablaPedidos.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, producto.Cantidad, producto.Precio);
                cuenta = cuenta + (producto.Cantidad * producto.Precio);                
            }            
            txtTotal.Text = cuenta.ToString();
            txtPendiente.Text = (cuenta - double.Parse(txtAdelanto.Text)).ToString();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cargarPresentaciones()
        {
            txtProducto.Items.Clear();
            if (txtCaracteristica.Text != String.Empty)
            {
                List<string> productosPorPresentacion = serviciosProducto.verProductosPorConfiguracion(txtPresentacion.Text, txtCaracteristica.Text);
                if (productosPorPresentacion != null)
                {
                    for (int i = 0; i < productosPorPresentacion.Count; i++)
                    {
                        txtProducto.Items.Add(productosPorPresentacion[i]);
                    }
                }
            }
        }
        private void txtPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPresentaciones();
        }
        private bool VerificarExistencia(string producto, string presentacion)
        {
            foreach (Producto p in lista)
            {
                if (p.Nombre == producto && p.Presentacion == presentacion)
                {
                    return true;
                }
            }
            return false;
        }        

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (TablaPedidos.Rows.Count != 0)
            {
                Producto producto;
                for (int i = 0; i < TablaPedidos.Rows.Count; i++)
                {
                    for (int j = 0; j < TablaPedidos.Columns.Count; j++)
                    {
                        
                        if (j == TablaPedidos.Columns.Count - 1)
                        {
                            bool quitar = Convert.ToBoolean(TablaPedidos[j, i].Value);
                            if (quitar)
                            {
                                producto = new Producto();
                                producto.Nombre = TablaPedidos[0, i].Value.ToString();
                                producto.Presentacion = TablaPedidos[1, i].Value.ToString();  
                                producto.Caracteristica = TablaPedidos[2, i].Value.ToString();
                                producto.Cantidad = int.Parse(TablaPedidos[3, i].Value.ToString());
                                producto.Precio = int.Parse(TablaPedidos[4, i].Value.ToString());
                                cuenta -= producto.Cantidad * producto.Precio;
                                txtTotal.Text = (cuenta).ToString();
                                txtPendiente.Text = (cuenta - double.Parse(txtAdelanto.Text)).ToString();
                                borrarDelaLista(producto);
                                TablaPedidos.Rows.Remove(TablaPedidos.CurrentRow);
                            }
                        }
                    }
                }

            }
        }
        private void borrarDelaLista(Producto producto)
        {
            foreach (Producto p in lista)
            {
                if (p.Nombre == producto.Nombre && p.Presentacion == producto.Presentacion)
                {
                    lista.Remove(p);
                    break;
                }
            }
        }


        private void checkColumnDataGrid(DataGridViewCellEventArgs e, DataGridViewCheckBoxCell checkBoxCell)
        {
            if (Convert.ToBoolean(checkBoxCell.Value) == true)
            {
                checkBoxCell.Value = false;
                TablaPedidos.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                checkBoxCell.Value = true;
                TablaPedidos.Rows[e.RowIndex].Selected = true;
            }
        }
       
        private void TablaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewCheckBoxCell checkEstado = (DataGridViewCheckBoxCell)TablaPedidos.Rows[e.RowIndex].Cells["Estado"];
                if (e.ColumnIndex == 5)
                {
                    checkColumnDataGrid(e, checkEstado);
                }            

            }
        }

        private void txtAdelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAdelanto_Enter(object sender, EventArgs e)
        {
            if (txtAdelanto.Text == "0")
            {
                txtAdelanto.Text = "";
            }
        }

        private void txtAdelanto_Leave(object sender, EventArgs e)
        {
            if (txtAdelanto.Text == "")
            {
                txtAdelanto.Text = "0";
            }
        }



        private void frmPedidos_Load(object sender, EventArgs e)
        {
            frmCargando frm = new frmCargando();
            frm.Show();
            txtCliente.AutoCompleteCustomSource = serviciosCliente.Autocomplete();
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            llenarPresentaciones();
            llenarCaracteristicas();
            frm.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validaciones.validarIdentificacion(txtCliente.Text))
            {
                if (txtFechaEntrega.Value.Date < DateTime.Today.Date)
                {
                    MessageBox.Show("No puede registrar un pedido en el pasado", "INFORMACION",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFechaEntrega.ResetText();
                }
                else
                {
                    string Mensaje = "";
                    Pedido pedido = new Pedido();
                    Factura factura = new Factura();
                    factura.Cliente = txtCliente.Text;
                    factura.Valor = double.Parse(txtTotal.Text);
                    factura.Fecha = DateTime.Today.Date;
                    CargarProductos(factura);
                    pedido.Cliente = txtCliente.Text;
                    pedido.FechaEntrega = txtFechaEntrega.Value;
                    pedido.FechaGeneracion = DateTime.Today;
                    pedido.descuento = Convert.ToDouble(txtDescuento.Value);
                    pedido.Total = Convert.ToDouble(txtTotal.Text);
                    pedido.Adelanto = Convert.ToDouble(txtAdelanto.Text);
                    pedido.Pendiente = Convert.ToDouble(txtPendiente.Text);
                    pedido.productos = lista;
                    pedido.Estado = verificarEstadoPedido(pedido)[0].ToString();
                    pedido.CodigoFactura = pedidoAModificar.CodigoFactura;
                    factura.Estado = pedido.Estado;
                    factura.numero = pedidoAModificar.CodigoFactura;
                    pedido.CodigoFactura = serviciosFacturas.NuevaFactura(factura, factura.Productos, false);
                    Mensaje = servicioPedido.GenerarPedido(pedido);
                    if (serviciosFacturas.modificarDetallesFactura(pedido.CodigoFactura, pedido.productos))
                        MessageBox.Show(Mensaje);
                    else
                        MessageBox.Show("Ha ocurrido un erro al intentar modificar el pedido", "Atencion",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            else
                MessageBox.Show("Identificacion Invalida");
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                string Mensaje = "";
                Pedido pedido = new Pedido();
                Factura factura = new Factura();
                factura.Cliente = txtCliente.Text;
                factura.Valor = double.Parse(txtTotal.Text);
                factura.Fecha = DateTime.Today.Date;
                CargarProductos(factura);
                pedido.Cliente = txtCliente.Text;
                pedido.FechaEntrega = txtFechaEntrega.Value;
                pedido.FechaGeneracion = DateTime.Today;
                pedido.descuento = Convert.ToDouble(txtDescuento.Value);
                pedido.Total = Convert.ToDouble(txtTotal.Text);
                pedido.Adelanto = Convert.ToDouble(txtAdelanto.Text);
                pedido.Pendiente = Convert.ToDouble(txtPendiente.Text);
                pedido.productos = lista;
                pedido.Estado = "Anulado";
                factura.Estado = pedido.Estado;
                factura.numero = pedidoAModificar.CodigoFactura;
                pedido.CodigoFactura = serviciosFacturas.NuevaFactura(factura, factura.Productos, false);
                Mensaje = servicioPedido.GenerarPedido(pedido);
                MessageBox.Show("Pedido Anulado");
                Limpiar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TablaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cargarPresentaciones();
                txtPresentacion.SelectedIndex = txtPresentacion.FindString(TablaPedidos[1, e.RowIndex].Value.ToString());
                cargarCaracteristicas();
                txtCaracteristica.SelectedIndex = txtCaracteristica.FindString(TablaPedidos[2, e.RowIndex].Value.ToString());
                txtProducto.SelectedIndex = txtProducto.FindString(TablaPedidos[0, e.RowIndex].Value.ToString());
                txtCantidad.Value = int.Parse(TablaPedidos[3, e.RowIndex].Value.ToString());

            }
        }
        private void cargarCaracteristicas()
        {
            txtProducto.Items.Clear();
            if (txtPresentacion.Text != String.Empty)
            {
                List<string> productosPorPresentacion = serviciosProducto.verProductosPorConfiguracion(txtPresentacion.Text, txtCaracteristica.Text);
                if (productosPorPresentacion != null)
                {
                    for (int i = 0; i < productosPorPresentacion.Count; i++)
                    {
                        txtProducto.Items.Add(productosPorPresentacion[i]);
                    }
                }
            }
        }

        private void txtFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCaracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCaracteristicas();
        }

        private void LimpiarYRefrescarTabla()
        {
            TablaPedidos.Rows.Clear();
            foreach (Producto p in lista)
            {
                TablaPedidos.Rows.Add(p.Nombre, p.Presentacion, p.Cantidad, p.Precio);
            }
        }
    }
}
