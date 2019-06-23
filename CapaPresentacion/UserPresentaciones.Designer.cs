namespace CapaPresentacion
{
    partial class UserPresentaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPresentaciones));
            this.lblPrecio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(333, 63);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(230, 31);
            this.lblPrecio.TabIndex = 42;
            this.lblPrecio.Text = "Precio por Unidad";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPresentacion.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtPresentacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.Location = new System.Drawing.Point(40, 97);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(189, 26);
            this.txtPresentacion.TabIndex = 41;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(33, 63);
            this.lblPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(173, 31);
            this.lblPresentacion.TabIndex = 40;
            this.lblPresentacion.Text = "Presentacion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPrecio.AutoCompleteCustomSource.AddRange(new string[] {
            "Enero",
            "Sabor a coco - Pequeño"});
            this.txtPrecio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPrecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(340, 97);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(189, 26);
            this.txtPrecio.TabIndex = 43;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
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
            this.btnRegistrar.ButtonText = "Registrar Presentacion";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Green;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 20;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.ForestGreen;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.btnRegistrar.Location = new System.Drawing.Point(196, 212);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(207, 69);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // UserPresentaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserPresentaciones";
            this.Size = new System.Drawing.Size(913, 650);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserPresentaciones_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrecio;
        private System.Windows.Forms.TextBox txtPresentacion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPresentacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
    }
}
