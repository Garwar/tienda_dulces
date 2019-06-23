using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CapaLogica;
using Entidades;

namespace CapaPresentacion
{
    public partial class frmAgregarPrecios : Form
    {
        ServiciosProducto servicios = new ServiciosProducto();
        List<string> presentaciones;
        public frmAgregarPrecios()
        {
            InitializeComponent();
            llenarPresentaciones();
            cargarLista();
            txtPrecioProductos.ShortcutsEnabled = false;
        }

        private void cargarLista()
        {
            foreach (Producto p in Cliente.Precios)
            {
                tablaListaPrecios.Rows.Add(p.Presentacion, p.Precio);
            }
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {                        
            Producto producto = new Producto();
            producto.Presentacion = txtPresentacion.Text;
            producto.Precio = Convert.ToInt32(txtPrecioProductos.Text);
            Cliente.Precios.Add(producto);            
            tablaListaPrecios.Rows.Add(producto.Presentacion, producto.Precio);
            limpiar();
        }

        private void limpiar()
        {
            txtPresentacion.Text = String.Empty;
            txtPrecioProductos.Text = "0";
            Refresh();
        }
        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            Close();
        }

        private void txtPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (tablaListaPrecios.Rows.Count != 0)
            {
                Producto producto;
                for (int i = 0; i < tablaListaPrecios.Rows.Count; i++)
                {
                    for (int j = 0; j < tablaListaPrecios.Columns.Count; j++)
                    {

                        if (j == tablaListaPrecios.Columns.Count - 1)
                        {
                            bool quitar = Convert.ToBoolean(tablaListaPrecios[j, i].Value);
                            if (!quitar)
                            {
                                producto = new Producto();
                                producto.Presentacion = tablaListaPrecios[0, i].Value.ToString();
                                producto.Precio = int.Parse(tablaListaPrecios[1, i].Value.ToString());
                                borrarDeLaLista(producto);
                                tablaListaPrecios.Rows.Remove(tablaListaPrecios.CurrentRow);
                            }
                        }
                    }
                }

            }
        }

        private void borrarDeLaLista(Producto producto)
        {
            Cliente.Precios.Remove(Cliente.Precios.Find(x => x.Presentacion == producto.Presentacion));
        }

        private void txtPrecioProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
