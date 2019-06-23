namespace CapaPresentacion
{
    partial class UserPedidosPendientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPedidosPendientes));
            this.label1 = new System.Windows.Forms.Label();
            this.TablaPendientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adelanto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEntregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCargarDatos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(361, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS PENDIENTES";
            // 
            // TablaPendientes
            // 
            this.TablaPendientes.AllowUserToAddRows = false;
            this.TablaPendientes.AllowUserToDeleteRows = false;
            this.TablaPendientes.AllowUserToOrderColumns = true;
            this.TablaPendientes.AllowUserToResizeColumns = false;
            this.TablaPendientes.AllowUserToResizeRows = false;
            this.TablaPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaPendientes.BackgroundColor = System.Drawing.Color.White;
            this.TablaPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TablaPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(165)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Generado,
            this.Entrega,
            this.Cliente,
            this.Total,
            this.Descuento,
            this.Adelanto,
            this.Pendiente,
            this.Entregar});
            this.TablaPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablaPendientes.EnableHeadersVisualStyles = false;
            this.TablaPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(88)))));
            this.TablaPendientes.Location = new System.Drawing.Point(13, 185);
            this.TablaPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.TablaPendientes.Name = "TablaPendientes";
            this.TablaPendientes.ReadOnly = true;
            this.TablaPendientes.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(165)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.TablaPendientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPendientes.Size = new System.Drawing.Size(1081, 337);
            this.TablaPendientes.TabIndex = 54;
            this.TablaPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPendientes_CellContentClick);
            this.TablaPendientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPendientes_CellContentDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Generado
            // 
            this.Generado.HeaderText = "Generado";
            this.Generado.Name = "Generado";
            this.Generado.ReadOnly = true;
            // 
            // Entrega
            // 
            this.Entrega.HeaderText = "Entrega";
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Adelanto
            // 
            this.Adelanto.HeaderText = "Adelanto";
            this.Adelanto.Name = "Adelanto";
            this.Adelanto.ReadOnly = true;
            // 
            // Pendiente
            // 
            this.Pendiente.HeaderText = "Pendiente";
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.ReadOnly = true;
            // 
            // Entregar
            // 
            this.Entregar.HeaderText = "Entregar";
            this.Entregar.Name = "Entregar";
            this.Entregar.ReadOnly = true;
            this.Entregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Entregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEntregar
            // 
            this.btnEntregar.ActiveBorderThickness = 1;
            this.btnEntregar.ActiveCornerRadius = 20;
            this.btnEntregar.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnEntregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntregar.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnEntregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEntregar.BackColor = System.Drawing.Color.White;
            this.btnEntregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntregar.BackgroundImage")));
            this.btnEntregar.ButtonText = "Entregar";
            this.btnEntregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.ForeColor = System.Drawing.Color.Green;
            this.btnEntregar.IdleBorderThickness = 1;
            this.btnEntregar.IdleCornerRadius = 20;
            this.btnEntregar.IdleFillColor = System.Drawing.Color.White;
            this.btnEntregar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnEntregar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnEntregar.Location = new System.Drawing.Point(567, 631);
            this.btnEntregar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(241, 69);
            this.btnEntregar.TabIndex = 14;
            this.btnEntregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "<";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(13, 726);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(105, 68);
            this.bunifuThinButton22.TabIndex = 12;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = ">";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(989, 726);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(105, 68);
            this.bunifuThinButton21.TabIndex = 11;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.ActiveBorderThickness = 1;
            this.btnCargarDatos.ActiveCornerRadius = 20;
            this.btnCargarDatos.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnCargarDatos.ActiveForecolor = System.Drawing.Color.White;
            this.btnCargarDatos.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnCargarDatos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargarDatos.BackColor = System.Drawing.Color.White;
            this.btnCargarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarDatos.BackgroundImage")));
            this.btnCargarDatos.ButtonText = "Cargar Pedidos";
            this.btnCargarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.ForeColor = System.Drawing.Color.Green;
            this.btnCargarDatos.IdleBorderThickness = 1;
            this.btnCargarDatos.IdleCornerRadius = 20;
            this.btnCargarDatos.IdleFillColor = System.Drawing.Color.White;
            this.btnCargarDatos.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnCargarDatos.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnCargarDatos.Location = new System.Drawing.Point(296, 631);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(241, 69);
            this.btnCargarDatos.TabIndex = 10;
            this.btnCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.animated = false;
            this.btnCerrar.animationIterval = 10;
            this.btnCerrar.animationSpeed = 1;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.btnCerrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.LabelVisible = false;
            this.btnCerrar.LineProgressThickness = 4;
            this.btnCerrar.LineThickness = 3;
            this.btnCerrar.Location = new System.Drawing.Point(1044, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.btnCerrar.MaxValue = 100;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ProgressColor = System.Drawing.Color.LimeGreen;
            this.btnCerrar.Size = new System.Drawing.Size(55, 55);
            this.btnCerrar.TabIndex = 55;
            this.btnCerrar.Value = 100;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // UserPedidosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.TablaPendientes);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserPedidosPendientes";
            this.Size = new System.Drawing.Size(1112, 800);
            this.Load += new System.EventHandler(this.UserPedidosPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCargarDatos;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntregar;
        private System.Windows.Forms.DataGridView TablaPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adelanto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendiente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Entregar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar btnCerrar;
    }
}
