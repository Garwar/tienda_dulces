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
    public partial class UserPresentaciones : UserControl
    {
        public UserPresentaciones()
        {
            InitializeComponent();
            txtPrecio.ShortcutsEnabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ServiciosProducto servicios = new ServiciosProducto();
            Composicion composicion = new Composicion(txtPresentacion.Text, Convert.ToInt32(txtPrecio.Text));
            MessageBox.Show(composicion.RegistrarPresentacion());
            txtPrecio.Text = String.Empty;
            txtPresentacion.Text = String.Empty;
            Refresh();
        }

        private void UserPresentaciones_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
