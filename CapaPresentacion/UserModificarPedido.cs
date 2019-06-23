using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using Entidades;

namespace CapaPresentacion
{
    public partial class UserModificarPedido : UserControl
    {
        Pedido pedidoAModificar = new Pedido();
        ServiciosProducto serviciosProducto = new ServiciosProducto();
        ServiciosCliente serviciosCliente = new ServiciosCliente();
        ServicioPedido servicioPedido = new ServicioPedido();
        ServiciosFacturas serviciosFacturas = new ServiciosFacturas();
        ServiciosMovimientos serviciosMovimiento = new ServiciosMovimientos();
        Cliente clienteActivo = new Cliente();
        frmPrincipal principal = new frmPrincipal();
        private List<Producto> lista = new List<Producto>();
        private List<Producto> Precios = new List<Producto>();        
        private double cuenta = 0;

        public UserModificarPedido()
        {
            InitializeComponent();
        }
        public UserModificarPedido(Pedido pedido)
        {
            InitializeComponent();
            this.pedidoAModificar = pedido;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserModificarPedido_Load(object sender, EventArgs e)
        {
            txtAdelanto.Text = pedidoAModificar.Adelanto.ToString();
            txtCliente.Text = pedidoAModificar.Cliente;
            txtDescuento.Value =(Decimal) pedidoAModificar.descuento;
            txtFechaEntrega.Value = pedidoAModificar.FechaEntrega;
            txtPendiente.Text = pedidoAModificar.Pendiente.ToString();
            txtTotal.Text = pedidoAModificar.Total.ToString();
            txtCliente.Enabled = false;

            serviciosCliente.VerPreciosDeCliente(txtCliente.Text);
        }
        private void llenarDatagrid()
        {            
            limpiarDatagridView(TablaPedidos);
            foreach (Producto p in pedidoAModificar.productos)
            {
                TablaPedidos.Rows.Add(p.Nombre,
                p.Presentacion,
                p.Caracteristica,
                p.Cantidad,
                p.Precio);                
            }
        }

        private void limpiarDatagridView(DataGridView dataGridView)
        {
            while (dataGridView.RowCount >= 1)
            {
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
            }
        }
        private bool verificarCampos()
        {
            if (txtProducto.Text == String.Empty || txtPresentacion.Text == String.Empty || txtCaracteristica.Text == String.Empty || Convert.ToInt32(txtCantidad.Value) == 0)
            {
                MessageBox.Show("Por favor verifique que todos los campos esten llenos correctamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private Producto mapearProducto(string nombreProducto, string presentacion, string caracteristica, int cantidad)
        {
            Producto producto = new Producto();
            producto.Nombre = nombreProducto;
            producto.Presentacion = presentacion;
            producto.Caracteristica = caracteristica;
            producto.Cantidad = cantidad;
            if (Cliente.Precios.Find(x => x.Presentacion == producto.Presentacion) == null)
            {
                return null;
            }
            else
            {
                producto.Precio = Cliente.Precios.Find(x => x.Presentacion == producto.Presentacion).Precio;
                return producto;
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificarCampos() == true && Cliente.Precios.Count > 0)
            {
                Producto producto = mapearProducto(txtProducto.Text, txtPresentacion.Text, txtCaracteristica.Text, Convert.ToInt32(txtCantidad.Value));
                if (producto == null)
                {
                    DialogResult result = MessageBox.Show("El cliente no cuenta con un precio para la presentacion seleccionada\n¿Desea configurarla ahora?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                        TablaPedidos.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, producto.Cantidad, producto.Precio);
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
            for (int i = 0; i < lista.Count; i++)
            {
                Producto p = lista[i];
                if (p.Nombre == producto.Nombre && p.Presentacion == producto.Presentacion && p.Caracteristica == producto.Caracteristica)
                {
                    lista[i].Cantidad += producto.Cantidad;
                    verificador = true;
                }
                TablaPedidos.Rows.Add(p.Nombre, p.Presentacion, p.Caracteristica, p.Cantidad, p.Precio);
                cuenta = cuenta + (p.Cantidad * p.Precio);
            }
            if (verificador == false)
            {
                lista.Add(producto);
                TablaPedidos.Rows.Add(producto.Nombre, producto.Presentacion, producto.Caracteristica, producto.Cantidad, producto.Precio);
                cuenta = cuenta + (producto.Cantidad * producto.Precio);
            }
            txtTotal.Text = cuenta.ToString();
            txtPendiente.Text = (cuenta - double.Parse(txtAdelanto.Text)).ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }
    }
}
