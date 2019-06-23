namespace CapaPresentacion
{
    partial class frmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescuento = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnular = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCaracteristica = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TablaPedidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnQuitar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtProducto = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPresentacion = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCargarPrecios = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAdelanto = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnAtras = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(519, 26);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(202, 29);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Fecha de entrega";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(56, 26);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(89, 29);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(61, 64);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(283, 26);
            this.txtCliente.TabIndex = 19;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFechaEntrega.CalendarTitleBackColor = System.Drawing.Color.DarkGreen;
            this.txtFechaEntrega.Location = new System.Drawing.Point(524, 64);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(281, 22);
            this.txtFechaEntrega.TabIndex = 20;
            this.txtFechaEntrega.ValueChanged += new System.EventHandler(this.txtFechaEntrega_ValueChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(964, 27);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(156, 29);
            this.bunifuCustomLabel6.TabIndex = 21;
            this.bunifuCustomLabel6.Text = "% Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(969, 62);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.MaximumSize = new System.Drawing.Size(153, 0);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(153, 26);
            this.txtDescuento.TabIndex = 22;
            this.txtDescuento.ValueChanged += new System.EventHandler(this.txtDescuento_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAnular);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.txtCaracteristica);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.TablaPedidos);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtPresentacion);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.btnCargarPrecios);
            this.panel1.Controls.Add(this.txtPendiente);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.txtAdelanto);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.txtFechaEntrega);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 722);
            this.panel1.TabIndex = 2;
            // 
            // btnAnular
            // 
            this.btnAnular.ActiveBorderThickness = 1;
            this.btnAnular.ActiveCornerRadius = 20;
            this.btnAnular.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnAnular.ActiveForecolor = System.Drawing.Color.White;
            this.btnAnular.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnAnular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnular.BackColor = System.Drawing.Color.White;
            this.btnAnular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnular.BackgroundImage")));
            this.btnAnular.ButtonText = "Anular";
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.Green;
            this.btnAnular.IdleBorderThickness = 1;
            this.btnAnular.IdleCornerRadius = 20;
            this.btnAnular.IdleFillColor = System.Drawing.Color.White;
            this.btnAnular.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnAnular.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnAnular.Location = new System.Drawing.Point(843, 647);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(241, 69);
            this.btnAnular.TabIndex = 63;
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ActiveBorderThickness = 1;
            this.btnModificar.ActiveCornerRadius = 20;
            this.btnModificar.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnModificar.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificar.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Green;
            this.btnModificar.IdleBorderThickness = 1;
            this.btnModificar.IdleCornerRadius = 20;
            this.btnModificar.IdleFillColor = System.Drawing.Color.White;
            this.btnModificar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnModificar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnModificar.Location = new System.Drawing.Point(329, 647);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(241, 69);
            this.btnModificar.TabIndex = 62;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaracteristica.FormattingEnabled = true;
            this.txtCaracteristica.Location = new System.Drawing.Point(356, 134);
            this.txtCaracteristica.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(281, 28);
            this.txtCaracteristica.TabIndex = 61;
            this.txtCaracteristica.SelectedIndexChanged += new System.EventHandler(this.txtCaracteristica_SelectedIndexChanged);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(351, 102);
            this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(159, 29);
            this.bunifuCustomLabel11.TabIndex = 60;
            this.bunifuCustomLabel11.Text = "Caracteristica";
            // 
            // TablaPedidos
            // 
            this.TablaPedidos.AllowUserToAddRows = false;
            this.TablaPedidos.AllowUserToDeleteRows = false;
            this.TablaPedidos.AllowUserToOrderColumns = true;
            this.TablaPedidos.AllowUserToResizeColumns = false;
            this.TablaPedidos.AllowUserToResizeRows = false;
            this.TablaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaPedidos.BackgroundColor = System.Drawing.Color.White;
            this.TablaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TablaPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(165)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Caracteristica,
            this.dataGridViewTextBoxColumn3,
            this.Precio_Unitario,
            this.Estado});
            this.TablaPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablaPedidos.EnableHeadersVisualStyles = false;
            this.TablaPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(88)))));
            this.TablaPedidos.Location = new System.Drawing.Point(61, 173);
            this.TablaPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.TablaPedidos.Name = "TablaPedidos";
            this.TablaPedidos.ReadOnly = true;
            this.TablaPedidos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(165)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.TablaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPedidos.Size = new System.Drawing.Size(1212, 337);
            this.TablaPedidos.TabIndex = 59;
            this.TablaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPedidos_CellClick);
            this.TablaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPedidos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Presentacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Caracteristica
            // 
            this.Caracteristica.HeaderText = "Caracteristica";
            this.Caracteristica.Name = "Caracteristica";
            this.Caracteristica.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnQuitar
            // 
            this.btnQuitar.ActiveBorderThickness = 1;
            this.btnQuitar.ActiveCornerRadius = 20;
            this.btnQuitar.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnQuitar.ActiveForecolor = System.Drawing.Color.White;
            this.btnQuitar.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.BackgroundImage")));
            this.btnQuitar.ButtonText = "-";
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Green;
            this.btnQuitar.IdleBorderThickness = 1;
            this.btnQuitar.IdleCornerRadius = 20;
            this.btnQuitar.IdleFillColor = System.Drawing.Color.White;
            this.btnQuitar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnQuitar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnQuitar.Location = new System.Drawing.Point(1305, 315);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(55, 64);
            this.btnQuitar.TabIndex = 58;
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.FormattingEnabled = true;
            this.txtProducto.Location = new System.Drawing.Point(653, 133);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(281, 28);
            this.txtProducto.TabIndex = 44;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(964, 101);
            this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(109, 29);
            this.bunifuCustomLabel10.TabIndex = 43;
            this.bunifuCustomLabel10.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(969, 135);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.MaximumSize = new System.Drawing.Size(153, 0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(153, 26);
            this.txtCantidad.TabIndex = 42;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.FormattingEnabled = true;
            this.txtPresentacion.Location = new System.Drawing.Point(61, 134);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(281, 28);
            this.txtPresentacion.TabIndex = 41;
            this.txtPresentacion.SelectedIndexChanged += new System.EventHandler(this.txtPresentacion_SelectedIndexChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(56, 102);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(154, 29);
            this.bunifuCustomLabel9.TabIndex = 40;
            this.bunifuCustomLabel9.Text = "Presentacion";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(649, 102);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(110, 29);
            this.bunifuCustomLabel8.TabIndex = 31;
            this.bunifuCustomLabel8.Text = "Producto";
            // 
            // btnCargarPrecios
            // 
            this.btnCargarPrecios.ActiveBorderThickness = 1;
            this.btnCargarPrecios.ActiveCornerRadius = 20;
            this.btnCargarPrecios.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnCargarPrecios.ActiveForecolor = System.Drawing.Color.White;
            this.btnCargarPrecios.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnCargarPrecios.BackColor = System.Drawing.Color.White;
            this.btnCargarPrecios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarPrecios.BackgroundImage")));
            this.btnCargarPrecios.ButtonText = "...";
            this.btnCargarPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPrecios.ForeColor = System.Drawing.Color.Green;
            this.btnCargarPrecios.IdleBorderThickness = 1;
            this.btnCargarPrecios.IdleCornerRadius = 20;
            this.btnCargarPrecios.IdleFillColor = System.Drawing.Color.White;
            this.btnCargarPrecios.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnCargarPrecios.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnCargarPrecios.Location = new System.Drawing.Point(356, 48);
            this.btnCargarPrecios.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCargarPrecios.Name = "btnCargarPrecios";
            this.btnCargarPrecios.Size = new System.Drawing.Size(49, 55);
            this.btnCargarPrecios.TabIndex = 30;
            this.btnCargarPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargarPrecios.Click += new System.EventHandler(this.btnCargarPrecios_Click);
            // 
            // txtPendiente
            // 
            this.txtPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPendiente.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtPendiente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPendiente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendiente.Enabled = false;
            this.txtPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.Location = new System.Drawing.Point(1103, 599);
            this.txtPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(170, 26);
            this.txtPendiente.TabIndex = 29;
            this.txtPendiente.Text = "0";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(961, 600);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(123, 29);
            this.bunifuCustomLabel7.TabIndex = 28;
            this.bunifuCustomLabel7.Text = "Pendiente";
            // 
            // txtAdelanto
            // 
            this.txtAdelanto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdelanto.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtAdelanto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAdelanto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAdelanto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdelanto.Location = new System.Drawing.Point(1103, 563);
            this.txtAdelanto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdelanto.Name = "txtAdelanto";
            this.txtAdelanto.Size = new System.Drawing.Size(170, 26);
            this.txtAdelanto.TabIndex = 27;
            this.txtAdelanto.Text = "0";
            this.txtAdelanto.TextChanged += new System.EventHandler(this.txtAdelanto_TextChanged);
            this.txtAdelanto.Enter += new System.EventHandler(this.txtAdelanto_Enter);
            this.txtAdelanto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdelanto_KeyPress);
            this.txtAdelanto.Leave += new System.EventHandler(this.txtAdelanto_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(961, 565);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(108, 29);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Adelanto";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1103, 528);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 26);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(961, 529);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 29);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "Total";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "+";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Location = new System.Drawing.Point(1224, 114);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(49, 55);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Completar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Green;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 20;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnRegistrar.Location = new System.Drawing.Point(584, 647);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(241, 69);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnAtras);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.btnCerrar);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LimeGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1380, 66);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnAtras
            // 
            this.btnAtras.ActiveBorderThickness = 1;
            this.btnAtras.ActiveCornerRadius = 20;
            this.btnAtras.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.ActiveForecolor = System.Drawing.Color.White;
            this.btnAtras.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.ButtonText = "Atras";
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.IdleBorderThickness = 1;
            this.btnAtras.IdleCornerRadius = 20;
            this.btnAtras.IdleFillColor = System.Drawing.Color.White;
            this.btnAtras.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAtras.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.Location = new System.Drawing.Point(7, 6);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(119, 50);
            this.btnAtras.TabIndex = 23;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(623, 11);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(141, 39);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Pedidos";
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
            this.btnCerrar.Location = new System.Drawing.Point(1320, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.btnCerrar.MaxValue = 100;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ProgressColor = System.Drawing.Color.White;
            this.btnCerrar.Size = new System.Drawing.Size(55, 55);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Value = 100;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar btnCerrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker txtFechaEntrega;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCargarPrecios;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtPendiente;
        public System.Windows.Forms.TextBox txtAdelanto;
        public System.Windows.Forms.NumericUpDown txtDescuento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox txtPresentacion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private System.Windows.Forms.ComboBox txtProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuitar;
        private System.Windows.Forms.DataGridView TablaPedidos;
        private System.Windows.Forms.ComboBox txtCaracteristica;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnular;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAtras;
    }
}