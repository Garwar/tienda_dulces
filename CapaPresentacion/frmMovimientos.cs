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
    public partial class frmMovimientos : Form
    {
        Validaciones validaciones = new Validaciones();
        Boolean permitir = true;//variable global para saber si se permite ctrl + C y ctrl + V
        public frmMovimientos()
        {
            InitializeComponent();
            TablaMovimientos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtGasto.ShortcutsEnabled = false;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarGasto(DateTime.Today, txtGasto.Text, txtRazon.Text);                
        }

        public string registrarGasto(DateTime fecha, string gasto, string razon)
        {
            ServiciosMovimientos servicios = new ServiciosMovimientos();
            List<Movimientos> lista = servicios.ConsultarTotal();
            if ((validaciones.validarRazonGasto(razon)
                && !string.IsNullOrEmpty(gasto)) && lista.Count > 0)
            {
                int Total = lista[lista.Count - 1].Total;
                Movimientos movimientos = new Movimientos();
                movimientos.Fecha =fecha;
                movimientos.Ingreso = 0;
                movimientos.Gasto = Convert.ToInt32(gasto);
                movimientos.Razon = razon;
                movimientos.Total = Total - movimientos.Gasto;
                if (movimientos.Total < 0)
                {
                    return "Lo sentimos, el valor del gasto no puede ser mayor a " + Total;
                }
                else
                {
                    servicios.RegistrarMovimiento(movimientos);
                    TablaMovimientos.Rows.Add(movimientos.Ingreso.ToString("C"),
                        movimientos.Gasto.ToString("C"),
                        movimientos.Razon,
                        movimientos.Total.ToString("C"),
                        movimientos.Fecha.ToShortDateString());
                    Refresh();
                    return "Movimiento registrado con exito";
                }
            }
            else
            {
                return "Por favor digite correctamente la informacion del gasto. ";
            }            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ServiciosMovimientos servicios = new ServiciosMovimientos();
            List<Movimientos> lista = servicios.VerPorFechas(txtFechaInicial.Value.Date, txtFechaFinal.Value.Date);
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay registros de movimientos en la base de datos");
            }
            else
            {
                foreach (Movimientos movimientos in lista)
                {
                    TablaMovimientos.Rows.Add(movimientos.Ingreso.ToString("C"),
                        movimientos.Gasto.ToString("C"),
                        movimientos.Razon,
                        movimientos.Total.ToString("C"),
                        movimientos.Fecha.ToShortDateString());
                }
            }            

        }
        void limpiarDatagridView()
        {
            while (TablaMovimientos.RowCount >= 1)
            {
                TablaMovimientos.Rows.Remove(TablaMovimientos.CurrentRow);
            }
        }
        private void BotonCargarDatos_Click(object sender, EventArgs e)
        {
            ServiciosMovimientos servicios = new ServiciosMovimientos();
            List<Movimientos> lista = servicios.VerMovimientos();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay registros de movimientos en la base de datos");
            }
            else
            {
                limpiarDatagridView();
                foreach (Movimientos movimientos in lista)
                {
                    TablaMovimientos.Rows.Add(movimientos.Ingreso.ToString("C"),
                        movimientos.Gasto.ToString("C"),
                        movimientos.Razon,
                        movimientos.Total.ToString("C"),
                        movimientos.Fecha.ToShortDateString());
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !='.')
            {                
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtGasto.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtGasto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if (txtFechaInicial.Value.Date > txtFechaFinal.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFechaInicial.ResetText();
            }
        }

        private void txtFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (txtFechaInicial.Value.Date > txtFechaFinal.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFechaFinal.ResetText();
            }
        }

        private void txtGasto_TextChanged(object sender, EventArgs e)
        {
            int valor = 0;
            if (!int.TryParse(txtGasto.Text, out valor))
                txtGasto.Text = "";

        }
    }
}
