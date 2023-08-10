namespace Ej1GuiaPOO_Libreria
{
    partial class frmLibreria
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLibreria = new System.Windows.Forms.Label();
            this.gpCargaProductos = new System.Windows.Forms.GroupBox();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.txtPrecioProdu = new System.Windows.Forms.TextBox();
            this.txtCantProdu = new System.Windows.Forms.TextBox();
            this.txtNombreProdu = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCargaVentas = new System.Windows.Forms.GroupBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.txtcantVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClosegrid = new System.Windows.Forms.Button();
            this.gpCargaProductos.SuspendLayout();
            this.gbCargaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibreria
            // 
            this.lblLibreria.AutoSize = true;
            this.lblLibreria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibreria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLibreria.Location = new System.Drawing.Point(331, 9);
            this.lblLibreria.Name = "lblLibreria";
            this.lblLibreria.Size = new System.Drawing.Size(135, 41);
            this.lblLibreria.TabIndex = 0;
            this.lblLibreria.Text = "Libreria";
            // 
            // gpCargaProductos
            // 
            this.gpCargaProductos.Controls.Add(this.btnVerProductos);
            this.gpCargaProductos.Controls.Add(this.btnCargarProducto);
            this.gpCargaProductos.Controls.Add(this.txtPrecioProdu);
            this.gpCargaProductos.Controls.Add(this.txtCantProdu);
            this.gpCargaProductos.Controls.Add(this.txtNombreProdu);
            this.gpCargaProductos.Controls.Add(this.txtCodBarras);
            this.gpCargaProductos.Controls.Add(this.label4);
            this.gpCargaProductos.Controls.Add(this.label3);
            this.gpCargaProductos.Controls.Add(this.label2);
            this.gpCargaProductos.Controls.Add(this.label1);
            this.gpCargaProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpCargaProductos.Location = new System.Drawing.Point(12, 73);
            this.gpCargaProductos.Name = "gpCargaProductos";
            this.gpCargaProductos.Size = new System.Drawing.Size(217, 365);
            this.gpCargaProductos.TabIndex = 1;
            this.gpCargaProductos.TabStop = false;
            this.gpCargaProductos.Text = "CargaProductos";
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerProductos.Location = new System.Drawing.Point(56, 310);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(100, 23);
            this.btnVerProductos.TabIndex = 5;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerProductos.UseVisualStyleBackColor = false;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarProducto.Location = new System.Drawing.Point(56, 266);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(100, 23);
            this.btnCargarProducto.TabIndex = 5;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargarProducto.UseVisualStyleBackColor = false;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // txtPrecioProdu
            // 
            this.txtPrecioProdu.Location = new System.Drawing.Point(111, 200);
            this.txtPrecioProdu.Name = "txtPrecioProdu";
            this.txtPrecioProdu.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProdu.TabIndex = 4;
            // 
            // txtCantProdu
            // 
            this.txtCantProdu.Location = new System.Drawing.Point(110, 145);
            this.txtCantProdu.Name = "txtCantProdu";
            this.txtCantProdu.Size = new System.Drawing.Size(100, 20);
            this.txtCantProdu.TabIndex = 4;
            // 
            // txtNombreProdu
            // 
            this.txtNombreProdu.Location = new System.Drawing.Point(111, 94);
            this.txtNombreProdu.Name = "txtNombreProdu";
            this.txtNombreProdu.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProdu.TabIndex = 4;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(110, 46);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodBarras.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de barras";
            // 
            // gbCargaVentas
            // 
            this.gbCargaVentas.Controls.Add(this.txtSubtotal);
            this.gbCargaVentas.Controls.Add(this.btnCargarVenta);
            this.gbCargaVentas.Controls.Add(this.cbProductos);
            this.gbCargaVentas.Controls.Add(this.txtcantVenta);
            this.gbCargaVentas.Controls.Add(this.label5);
            this.gbCargaVentas.Controls.Add(this.label7);
            this.gbCargaVentas.Controls.Add(this.label6);
            this.gbCargaVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCargaVentas.Location = new System.Drawing.Point(546, 73);
            this.gbCargaVentas.Name = "gbCargaVentas";
            this.gbCargaVentas.Size = new System.Drawing.Size(236, 366);
            this.gbCargaVentas.TabIndex = 3;
            this.gbCargaVentas.TabStop = false;
            this.gbCargaVentas.Text = "Carga de ventas";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(116, 138);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 11;
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarVenta.Location = new System.Drawing.Point(71, 190);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(100, 23);
            this.btnCargarVenta.TabIndex = 5;
            this.btnCargarVenta.Text = "Cargar Venta";
            this.btnCargarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(116, 43);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(100, 21);
            this.cbProductos.TabIndex = 6;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // txtcantVenta
            // 
            this.txtcantVenta.Location = new System.Drawing.Point(116, 94);
            this.txtcantVenta.Name = "txtcantVenta";
            this.txtcantVenta.Size = new System.Drawing.Size(100, 20);
            this.txtcantVenta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad";
            // 
            // dataProductos
            // 
            this.dataProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad});
            this.dataProductos.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataProductos.Location = new System.Drawing.Point(235, 81);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            this.dataProductos.Size = new System.Drawing.Size(243, 357);
            this.dataProductos.TabIndex = 4;
            this.dataProductos.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnClosegrid
            // 
            this.btnClosegrid.BackColor = System.Drawing.Color.Transparent;
            this.btnClosegrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosegrid.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosegrid.ForeColor = System.Drawing.Color.Red;
            this.btnClosegrid.Location = new System.Drawing.Point(235, 52);
            this.btnClosegrid.Name = "btnClosegrid";
            this.btnClosegrid.Size = new System.Drawing.Size(38, 23);
            this.btnClosegrid.TabIndex = 5;
            this.btnClosegrid.Text = "X";
            this.btnClosegrid.UseVisualStyleBackColor = false;
            this.btnClosegrid.Click += new System.EventHandler(this.btnClosegrid_Click);
            // 
            // frmLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClosegrid);
            this.Controls.Add(this.gbCargaVentas);
            this.Controls.Add(this.gpCargaProductos);
            this.Controls.Add(this.lblLibreria);
            this.Controls.Add(this.dataProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLibreria";
            this.Load += new System.EventHandler(this.frmLibreria_Load);
            this.gpCargaProductos.ResumeLayout(false);
            this.gpCargaProductos.PerformLayout();
            this.gbCargaVentas.ResumeLayout(false);
            this.gbCargaVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibreria;
        private System.Windows.Forms.GroupBox gpCargaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.TextBox txtPrecioProdu;
        private System.Windows.Forms.TextBox txtCantProdu;
        private System.Windows.Forms.TextBox txtNombreProdu;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.GroupBox gbCargaVentas;
        private System.Windows.Forms.TextBox txtcantVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnClosegrid;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarVenta;
    }
}

