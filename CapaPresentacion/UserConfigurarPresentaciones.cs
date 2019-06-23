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
    public partial class UserConfigurarPresentaciones : UserControl
    {
        ServiciosProducto servicios = new ServiciosProducto();
        public UserConfigurarPresentaciones()
        {
            InitializeComponent();
            if(servicios.VerPresentaciones() != null && txtPresentacion.Items.Count == 0)
            {
                for (int i = 0; i < servicios.VerPresentaciones().Count; i++)
                {
                    txtPresentacion.Items.Add(servicios.VerPresentaciones()[i]);
                }
            }            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {                
                Composicion composicion = new Composicion(txtPresentacion.Text, Convert.ToInt32(txtPrecio.Text));
                composicion.Agregar(new Hoja(txtProducto.Text, txtPresentacion.Text, txtCaracteristica.Text, Convert.ToInt32(txtPrecio.Text)));
                MessageBox.Show("Configuracion registrada con exito");
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha habido un error al momento de registrar la configuracion.");
                throw;
            }
            
        }
        private void Limpiar()
        {
            txtPresentacion.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtCaracteristica.Text = "";
            Refresh();
        }

        private void txtPresentacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPrecio.Text = servicios.VerPrecioPorPresentacion(txtPresentacion.Text).ToString();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            int valor = 0;
            if (!int.TryParse(txtPrecio.Text, out valor))
                txtPrecio.Text = "";
        }
    }
}
