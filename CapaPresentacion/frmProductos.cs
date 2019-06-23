
using System;
using System.Data;
using System.Windows.Forms;
using CapaLogica;
using Entidades;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        ServiciosProducto servicios = new ServiciosProducto();        
        List<string> presentaciones;
        List<string> caracteristicas;
        public frmProductos()
        {
            InitializeComponent();
            llenarPresentaciones();
            llenarCaracteristicas();
            tablaMovimientosProductos.AutoResizeColumn(5);
            tablaMovimientosProductos.AutoResizeColumn(6);
        }
        
        public void llenarPresentaciones()
        {
            presentaciones = servicios.VerPresentaciones();
            if (presentaciones != null)
            {
                for (int i = 0; i < presentaciones.Count; i++)
                {
                    txtPresentacion2.Items.Add(presentaciones[i]);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar las presentaciones", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuThinButton21.Enabled = false;
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
                bunifuThinButton21.Enabled = false;
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaracteristica.Text) || string.IsNullOrEmpty(txtPresentacion2.Text)||
                string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Debe seleccionar las opciones", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(añadirExistencias(txtProducto.Text, txtPresentacion2.Text, txtCaracteristica.Text, Convert.ToInt16(txtCantidad.Value)));                          
            }
        }
        
        public string añadirExistencias(string nombre, string presentacion, string caracteristica, int cantidad)
        {
            Producto producto = new Producto();
            ServiciosProducto servicios = new ServiciosProducto();
            producto.Nombre = nombre;
            producto.Presentacion = presentacion;
            producto.Caracteristica = caracteristica;
            producto.Cantidad = Convert.ToInt16(cantidad);
            try
            {
                Limpiar();
                return servicios.añadirExistencias(producto);
            }
            catch (Exception)
            {
                return "Ha habido un error, por favor\n revise bien la informacion.";
            }
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            cargarProductos();
            // TODO: esta línea de código carga datos en la tabla 'dulcesDB1.DataTable1' Puede moverla o quitarla según sea necesario.           
        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }

        private void Limpiar()
        {
            txtProducto.Text = "";
            txtPresentacion2.Text = "";
            txtCantidad.Value = 0;
            txtPrecio.Text = "0";
            Refresh();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }

        private void BotonCargarDatos_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }
        private void cargarProductos()
        {
            List<Producto> producto = servicios.VerProductos();
            TablaProductos.AutoGenerateColumns = false;
            if (producto != null || producto.Count != 0)
            {
                TablaProductos.Rows.Clear();
                foreach (Producto p in producto)
                {
                    TablaProductos.Rows.Add(p.Nombre, p.Presentacion, p.Caracteristica,
                        p.Cantidad, p.Vendidos, p.Precio);
                }
               
            }else
                MessageBox.Show("No hay productos por mostrar.","INFORMACION",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);           
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UserPresentaciones presentaciones = new UserPresentaciones();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(presentaciones);
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            UserConfigurarPresentaciones configurar = new UserConfigurarPresentaciones();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(configurar);
        }

        private void txtPresentacion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = servicios.VerPrecioPorPresentacion(txtPresentacion2.Text).ToString();
            txtProducto.Items.Clear();
            if (txtCaracteristica.Text != String.Empty)
            {
                List<string> productosPorPresentacion = servicios.verProductosPorConfiguracion(txtPresentacion2.Text, txtCaracteristica.Text);
                if (productosPorPresentacion != null)
                {
                    for (int i = 0; i < productosPorPresentacion.Count; i++)
                    {
                        txtProducto.Items.Add(productosPorPresentacion[i]);
                    }
                }
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtPresentacion2.Items.Clear();
            presentaciones = servicios.VerPresentaciones();
            if (presentaciones != null)
            {
                for (int i = 0; i < presentaciones.Count; i++)
                {
                    txtPresentacion2.Items.Add(presentaciones[i]);
                }
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCaracteristica_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtProducto.Items.Clear();
            if (txtPresentacion2.Text != String.Empty)
            {
                List<string> productosPorPresentacion = servicios.verProductosPorConfiguracion(txtPresentacion2.Text, txtCaracteristica.Text);
                if (productosPorPresentacion != null)
                {
                    for (int i = 0; i < productosPorPresentacion.Count; i++)
                    {
                        txtProducto.Items.Add(productosPorPresentacion[i]);
                    }
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = servicios.verMovimientosDeProducto();
            tablaMovimientosProductos.AutoGenerateColumns = false;
            if (dataTable != null && dataTable.Rows.Count != 0)
            {
                tablaMovimientosProductos.Rows.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime fecha = DateTime.Parse(row["FECHA"].ToString());
                    tablaMovimientosProductos.Rows.Add(fecha.ToString("dd/MM/yyyy"),
                        row["COD_PRODUCTO"], row["DESCRIPCION"], row["NOM_PRESENTACION"],
                        row["CARACTERISTICA"], row["ENTRADA"], row["SALIDA"]);
                }
            }
            else
            {
                MessageBox.Show("No hay productos por mostrar.", "INFORMACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
