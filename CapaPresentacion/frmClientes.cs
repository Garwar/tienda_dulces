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
    public partial class frmClientes : Form
    {
        DataTable dataTable;
        ServiciosCliente serviciosCliente = new ServiciosCliente();
        Validaciones validaciones = new Validaciones();
        public frmClientes()
        {
            InitializeComponent();
            txtTelefono.ShortcutsEnabled = false;
        }

        private void cargarAutocompletados(DataTable dataTable)
        {
            txtIdentificacionP.AutoCompleteCustomSource = cargarIdentificaciones(dataTable);
            txtIdentificacionP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIdentificacionP.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(añadirCliente(txtIdentificacion.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtFecha.Value));            
        }

        public string añadirCliente(string identificacion, string nombre, string direccion, string telefono, DateTime fecha)
        {
            try
            {
                if (validaciones.validarIdentificacion(identificacion) && validaciones.validarTelefono(telefono))
                {
                    Cliente cliente = new Cliente();
                    ServiciosCliente servicios = new ServiciosCliente();
                    cliente.Identificacion = identificacion;
                    cliente.Nombre = nombre;
                    cliente.Direccion = direccion;
                    cliente.Telefono = telefono;
                    cliente.fecha = fecha;
                    servicios.NuevoCliente(cliente, Cliente.Precios);
                    registrarPrecios(cliente);
                    Cliente.Precios.Clear();
                    return "Felicidades, Cliente agregado con exito.";
                }
                else
                    return "Lo sentimos. Ha ocurrido un error. Ingrese datos validos";                
            }
            catch (Exception)
            {
                return "Lo sentimos. Ha ocurrido un error.";
            }
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            frmAgregarPrecios agregar = new frmAgregarPrecios();                       
            agregar.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (validaciones.validarIdentificacion(txtIdentificacion.Text))
            {
                ServiciosCliente servicios = new ServiciosCliente();
                Cliente cliente = servicios.BuscarCliente(txtIdentificacion.Text);
                txtIdentificacion.Enabled = false;
                //btnPrecios.Enabled = false;
                txtFecha.Enabled = false;
                MapeoAForm(cliente);            
            }else
                MessageBox.Show("Ingrese datos validos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
        private void MapeoAForm(Cliente cliente)
        {
            if(cliente is null)
            {
                MessageBox.Show("Este cliente no esta en nuestra base de datos.");
            }
            else
            {
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
            }                     
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(modificarCliente(txtIdentificacion.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text));
        }

        public string modificarCliente(string identificacion, string nombre, string direccion, string telefono)
        {
            try
            {
                if (validaciones.validarTelefono(telefono))
                {
                    Cliente cliente = new Cliente();
                    ServiciosCliente servicios = new ServiciosCliente();
                    cliente.Nombre = txtNombre.Text;
                    cliente.Identificacion = txtIdentificacion.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Telefono = txtTelefono.Text;
                    servicios.ModificarCliente(cliente);
                    registrarPrecios(cliente);
                    return "Felicidades, Cliente modificado con exito.";
                }
                else
                    return "Lo sentimos. Ha ocurrido un error.";
            }
            catch (Exception)
            {
                return "Lo sentimos. Ha ocurrido un error.";
            }
        }
        void llenarDataGridView(DataGridView dataGridView, DataTable table)
        {
            dataTable = serviciosCliente.verListaDePrecios();
            limpiarDatagridView(tablaListaPrecios);
            foreach (DataRow tabla in dataTable.Rows)
            {
                tablaListaPrecios.Rows.Add(
                                        tabla["COD_CLIENTE"],
                                        tabla["nom_presentacion"],
                                        int.Parse(tabla["precio"].ToString()).ToString("C"));
            }
        }

        private void limpiarDatagridView(DataGridView dataGridView)
        {
            while (dataGridView.RowCount >= 1)
            {
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
            }
        }
        private void cargarClientes()
        {
            if (dataTable == null)
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar la lista de precios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                llenarDataGridView(tablaListaPrecios, dataTable);
            }
        }
        private void btnCargarPrecios_Click(object sender, EventArgs e)
        {
            cargarClientes();   
        }
        void llenarDataGridView(string id)
        {
            limpiarDatagridView(tablaListaPrecios);
            foreach (DataRow tabla in dataTable.Rows)
            {
                if ((tabla["COD_CLIENTE"]).Equals(id))
                {
                    tablaListaPrecios.Rows.Add(
                                        tabla["COD_CLIENTE"],
                                        tabla["nom_presentacion"],
                                        int.Parse(tabla["precio"].ToString()).ToString("C"));
                }
            }
        }
        private AutoCompleteStringCollection cargarIdentificaciones(DataTable dataTable)
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach (DataRow item in dataTable.Rows)
            {
                datos.Add(item["COD_CLIENTE"].ToString());
            }
            return datos;
        }
        private void btnConsultarPrecios_Click(object sender, EventArgs e)
        {            
            if (dataTable == null)
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar la lista de precios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrEmpty(txtIdentificacionP.Text) ||
                    !validaciones.validarIdentificacion(txtIdentificacionP.Text))
                {
                    MessageBox.Show("Escriba el nit del cliente a buscar");
                }
                else
                {
                    llenarDataGridView(txtIdentificacionP.Text.Trim());
                }
            }
        }

        public void registrarPrecios(Cliente cliente)
        {
            foreach(Producto p in Cliente.Precios)
            {
                serviciosCliente.NuevosPrecios(p, cliente);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dataTable = serviciosCliente.verListaDePrecios();
            cargarClientes();
            //tablaListaPrecios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //cargarAutocompletados(dataTable);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {
            if (txtFecha.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("No puede registrar un cliente en el futuro", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFecha.ResetText();
            }
        }
    }
}
