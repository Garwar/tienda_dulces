using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using CapaPresentacion;
using System.Threading;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
            UserPedidosPendientes pendientes = new UserPedidosPendientes();
            splitContainer1.Panel2.Controls.Add(pendientes);           
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
            Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
            Hide();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pedidos.Show();
            Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pedidos.Show();
            Hide();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            Hide();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            Hide();
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            frmMovimientos movimientos = new frmMovimientos();
            movimientos.Show();
            Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            frmMovimientos movimientos = new frmMovimientos();
            movimientos.Show();
            Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
