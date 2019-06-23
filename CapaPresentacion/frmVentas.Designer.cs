using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnAtras = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnCompletar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnQuitar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnQuitarOrden = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TablaVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCaracteristica = new System.Windows.Forms.ComboBox();
            this.lblCaracteristica = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPresentacion = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.verificadorFactura = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnAtras);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCircleProgressbar1);
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
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.ActiveBorderThickness = 1;
            this.btnAtras.ActiveCornerRadius = 20;
            this.btnAtras.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.ActiveForecolor = System.Drawing.Color.White;
            this.btnAtras.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.ButtonText = "Atras";
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.IdleBorderThickness = 1;
            this.btnAtras.IdleCornerRadius = 20;
            this.btnAtras.IdleFillColor = System.Drawing.Color.White;
            this.btnAtras.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAtras.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtras.Location = new System.Drawing.Point(7, 6);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(124, 50);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(571, 11);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(247, 40);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Venta Rapida";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 10;
            this.bunifuCircleProgressbar1.animationSpeed = 1;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 4;
            this.bunifuCircleProgressbar1.LineThickness = 3;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(1320, 6);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(54, 54);
            this.bunifuCircleProgressbar1.TabIndex = 9;
            this.bunifuCircleProgressbar1.Value = 100;
            this.bunifuCircleProgressbar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuCircleProgressbar1_MouseClick);
            // 
            // btnCompletar
            // 
            this.btnCompletar.ActiveBorderThickness = 1;
            this.btnCompletar.ActiveCornerRadius = 20;
            this.btnCompletar.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnCompletar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCompletar.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnCompletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCompletar.BackColor = System.Drawing.Color.White;
            this.btnCompletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompletar.BackgroundImage")));
            this.btnCompletar.ButtonText = "Completar";
            this.btnCompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompletar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.ForeColor = System.Drawing.Color.Green;
            this.btnCompletar.IdleBorderThickness = 1;
            this.btnCompletar.IdleCornerRadius = 20;
            this.btnCompletar.IdleFillColor = System.Drawing.Color.White;
            this.btnCompletar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnCompletar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnCompletar.Location = new System.Drawing.Point(579, 704);
            this.btnCompletar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(241, 66);
            this.btnCompletar.TabIndex = 1;
            this.btnCompletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(703, 110);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 30);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Producto";
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.White;
            this.panelVentas.Controls.Add(this.btnQuitar);
            this.panelVentas.Controls.Add(this.bunifuThinButton21);
            this.panelVentas.Controls.Add(this.btnQuitarOrden);
            this.panelVentas.Controls.Add(this.TablaVentas);
            this.panelVentas.Controls.Add(this.txtCaracteristica);
            this.panelVentas.Controls.Add(this.lblCaracteristica);
            this.panelVentas.Controls.Add(this.txtPresentacion);
            this.panelVentas.Controls.Add(this.txtProducto);
            this.panelVentas.Controls.Add(this.bunifuCustomLabel6);
            this.panelVentas.Controls.Add(this.verificadorFactura);
            this.panelVentas.Controls.Add(this.txtprecio);
            this.panelVentas.Controls.Add(this.bunifuCustomLabel5);
            this.panelVentas.Controls.Add(this.bunifuCustomLabel4);
            this.panelVentas.Controls.Add(this.btnAgregar);
            this.panelVentas.Controls.Add(this.btnCompletar);
            this.panelVentas.Controls.Add(this.bunifuCustomLabel2);
            this.panelVentas.Controls.Add(this.txtCantidad);
            this.panelVentas.Controls.Add(this.bunifuCustomLabel1);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVentas.Location = new System.Drawing.Point(0, 0);
            this.panelVentas.Margin = new System.Windows.Forms.Padding(4);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(1380, 788);
            this.panelVentas.TabIndex = 4;
            this.panelVentas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVentas_Paint);
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
            this.btnQuitar.Location = new System.Drawing.Point(1317, 363);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(55, 64);
            this.btnQuitar.TabIndex = 57;
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "-";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(1471, 569);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(55, 64);
            this.bunifuThinButton21.TabIndex = 56;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitarOrden
            // 
            this.btnQuitarOrden.ActiveBorderThickness = 1;
            this.btnQuitarOrden.ActiveCornerRadius = 20;
            this.btnQuitarOrden.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.btnQuitarOrden.ActiveForecolor = System.Drawing.Color.White;
            this.btnQuitarOrden.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnQuitarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarOrden.BackColor = System.Drawing.Color.White;
            this.btnQuitarOrden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitarOrden.BackgroundImage")));
            this.btnQuitarOrden.ButtonText = "--";
            this.btnQuitarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarOrden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarOrden.ForeColor = System.Drawing.Color.Green;
            this.btnQuitarOrden.IdleBorderThickness = 1;
            this.btnQuitarOrden.IdleCornerRadius = 20;
            this.btnQuitarOrden.IdleFillColor = System.Drawing.Color.White;
            this.btnQuitarOrden.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnQuitarOrden.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnQuitarOrden.Location = new System.Drawing.Point(1636, 598);
            this.btnQuitarOrden.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnQuitarOrden.Name = "btnQuitarOrden";
            this.btnQuitarOrden.Size = new System.Drawing.Size(61, 66);
            this.btnQuitarOrden.TabIndex = 55;
            this.btnQuitarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaVentas
            // 
            this.TablaVentas.AllowUserToAddRows = false;
            this.TablaVentas.AllowUserToDeleteRows = false;
            this.TablaVentas.AllowUserToOrderColumns = true;
            this.TablaVentas.AllowUserToResizeColumns = false;
            this.TablaVentas.AllowUserToResizeRows = false;
            this.TablaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaVentas.BackgroundColor = System.Drawing.Color.White;
            this.TablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(165)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Caracteristica,
            this.Column3,
            this.Total,
            this.Estado});
            this.TablaVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablaVentas.EnableHeadersVisualStyles = false;
            this.TablaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(88)))));
            this.TablaVentas.Location = new System.Drawing.Point(83, 203);
            this.TablaVentas.Margin = new System.Windows.Forms.Padding(4);
            this.TablaVentas.Name = "TablaVentas";
            this.TablaVentas.ReadOnly = true;
            this.TablaVentas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(165)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.TablaVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaVentas.Size = new System.Drawing.Size(1212, 337);
            this.TablaVentas.TabIndex = 54;
            this.TablaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaVentas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Presentacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Caracteristica
            // 
            this.Caracteristica.HeaderText = "Caracteristica";
            this.Caracteristica.Name = "Caracteristica";
            this.Caracteristica.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Precio Unitario";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCaracteristica.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaracteristica.FormattingEnabled = true;
            this.txtCaracteristica.Location = new System.Drawing.Point(403, 146);
            this.txtCaracteristica.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(281, 28);
            this.txtCaracteristica.TabIndex = 44;
            this.txtCaracteristica.SelectedIndexChanged += new System.EventHandler(this.txtCaracteristica_SelectedIndexChanged);
            // 
            // lblCaracteristica
            // 
            this.lblCaracteristica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCaracteristica.AutoSize = true;
            this.lblCaracteristica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCaracteristica.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristica.Location = new System.Drawing.Point(387, 110);
            this.lblCaracteristica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaracteristica.Name = "lblCaracteristica";
            this.lblCaracteristica.Size = new System.Drawing.Size(181, 30);
            this.lblCaracteristica.TabIndex = 43;
            this.lblCaracteristica.Text = "Caracteristica";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPresentacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.FormattingEnabled = true;
            this.txtPresentacion.Location = new System.Drawing.Point(83, 146);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(281, 28);
            this.txtPresentacion.TabIndex = 42;
            this.txtPresentacion.SelectedIndexChanged += new System.EventHandler(this.txtPresentacion_SelectedIndexChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProducto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.FormattingEnabled = true;
            this.txtProducto.Location = new System.Drawing.Point(708, 146);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(281, 28);
            this.txtProducto.TabIndex = 41;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(120, 567);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(208, 30);
            this.bunifuCustomLabel6.TabIndex = 16;
            this.bunifuCustomLabel6.Text = "Generar Factura";
            // 
            // verificadorFactura
            // 
            this.verificadorFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.verificadorFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.verificadorFactura.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.verificadorFactura.Checked = false;
            this.verificadorFactura.CheckedOnColor = System.Drawing.Color.ForestGreen;
            this.verificadorFactura.ForeColor = System.Drawing.Color.White;
            this.verificadorFactura.Location = new System.Drawing.Point(85, 567);
            this.verificadorFactura.Margin = new System.Windows.Forms.Padding(5);
            this.verificadorFactura.Name = "verificadorFactura";
            this.verificadorFactura.Size = new System.Drawing.Size(20, 20);
            this.verificadorFactura.TabIndex = 15;
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtprecio.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtprecio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtprecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(1127, 571);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(167, 27);
            this.txtprecio.TabIndex = 13;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(1048, 571);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(70, 30);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Total";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(67, 110);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(168, 30);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Presentacion";
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
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Location = new System.Drawing.Point(1245, 127);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(49, 55);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.BotonAgregarClick);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1012, 110);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(126, 30);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(1017, 148);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.MaximumSize = new System.Drawing.Size(153, 0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(153, 27);
            this.txtCantidad.TabIndex = 5;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 788);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panelVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCompletar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelVentas;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAtras;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private TextBox txtprecio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCheckbox verificadorFactura;
        private ComboBox txtProducto;
        private ComboBox txtPresentacion;
        private ComboBox txtCaracteristica;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCaracteristica;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuitarOrden;
        private DataGridView TablaVentas;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuitar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Caracteristica;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewCheckBoxColumn Estado;
    }
}