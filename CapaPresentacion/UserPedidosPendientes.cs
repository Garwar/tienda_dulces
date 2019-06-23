using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class UserPedidosPendientes : UserControl
    {
        List<Pedido> pedidosPendientes = new List<Pedido>();
        public UserPedidosPendientes()
        {
            InitializeComponent();
            TablaPendientes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            ServicioPedido servicio = new ServicioPedido();
            for (int i = 0; i < TablaPendientes.Rows.Count; i++)
            {
                bool entregado = Convert.ToBoolean(TablaPendientes["Entregar",i].Value);
                if (entregado == true)
                {
                    Pedido pedido = new Pedido();
                    pedido = pedidosPendientes.Find(x => x.Codigo ==
                    Convert.ToInt16(TablaPendientes.CurrentRow.Cells["Codigo"].Value.ToString()));                    
                    pedido.Estado = "Entregado";
                    string respuesta = servicio.ConfirmarPedido(pedido);
                    if (respuesta == "Existencias")
                    {
                        MessageBox.Show("Hay inconvenientes con los productos del pedido\n" +
                            "No hay productos suficientes", "Cuidado", MessageBoxButtons.OK,MessageBoxIcon.Error);                        
                    }
                    else
                    {
                        if (respuesta == "Error")
                        {
                            MessageBox.Show("Ha ocurrido un error interno del sistema", "Atencion",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            llenarDatagrid();
                            MessageBox.Show("El pedido se ha entregado con exito", "Informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void limpiarDatagridView(DataGridView dataGridView)
        {
            while (dataGridView.RowCount >= 1)
            {
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
            }
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            llenarDatagrid();
        }
        private void llenarDatagrid()
        {
            ServicioPedido servicio = new ServicioPedido();
            pedidosPendientes = servicio.ConsultarPorEstado("Pendiente");
            TablaPendientes.AutoGenerateColumns = false;
            if (pedidosPendientes==null ||pedidosPendientes.Count == 0)
            {
                MessageBox.Show("Por el momento no hay pedidos pendientes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                limpiarDatagridView(TablaPendientes);
                foreach (Pedido p in pedidosPendientes)
                {
                    TablaPendientes.Rows.Add(p.Codigo,
                        p.FechaGeneracion.Date.ToString("dd/MM/yyyy"),
                        p.FechaEntrega.Date.ToString("dd/MM/yyyy"),
                        p.Cliente,
                        p.Total.ToString("C"),
                        p.descuento.ToString("C"),
                        p.Adelanto.ToString("C"),
                        p.Pendiente.ToString("C"));
                }
            }                        
        }
        private void checkColumnDataGrid(DataGridViewCellEventArgs e, DataGridViewCheckBoxCell checkBoxCell)
        {
            if (Convert.ToBoolean(checkBoxCell.Value) == true)
            {
                checkBoxCell.Value = false;
                TablaPendientes.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                checkBoxCell.Value = true;
                TablaPendientes.Rows[e.RowIndex].Selected = true;
            }
        }
        private void TablaPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell checkEntregar = (DataGridViewCheckBoxCell)TablaPendientes.Rows[e.RowIndex].Cells["Entregar"];                      
                if (e.ColumnIndex == 8)
                {
                    checkColumnDataGrid(e,checkEntregar);
                }
            }            
        }

        private void TablaPendientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido = pedidosPendientes.Find(x => x.Codigo ==
            Convert.ToInt16(TablaPendientes.CurrentRow.Cells["Codigo"].Value.ToString()));
            frmPrincipal frm  = (frmPrincipal)this.FindForm();
            frmPedidos frmPedidos = new frmPedidos(pedido);
            frmPedidos.Show();
            frm.Hide();
        }

        private void UserPedidosPendientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
