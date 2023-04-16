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
            this.txtListProducts = new System.Windows.Forms.RichTextBox();
            this.gpCargaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibreria
            // 
            this.lblLibreria.AutoSize = true;
            this.lblLibreria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibreria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLibreria.Location = new System.Drawing.Point(432, 11);
            this.lblLibreria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibreria.Name = "lblLibreria";
            this.lblLibreria.Size = new System.Drawing.Size(170, 54);
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
            this.gpCargaProductos.Location = new System.Drawing.Point(16, 90);
            this.gpCargaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gpCargaProductos.Name = "gpCargaProductos";
            this.gpCargaProductos.Padding = new System.Windows.Forms.Padding(4);
            this.gpCargaProductos.Size = new System.Drawing.Size(289, 449);
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
            this.btnVerProductos.Location = new System.Drawing.Point(75, 381);
            this.btnVerProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(133, 28);
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
            this.btnCargarProducto.Location = new System.Drawing.Point(75, 327);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(133, 28);
            this.btnCargarProducto.TabIndex = 5;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargarProducto.UseVisualStyleBackColor = false;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // txtPrecioProdu
            // 
            this.txtPrecioProdu.Location = new System.Drawing.Point(148, 246);
            this.txtPrecioProdu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProdu.Name = "txtPrecioProdu";
            this.txtPrecioProdu.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioProdu.TabIndex = 4;
            // 
            // txtCantProdu
            // 
            this.txtCantProdu.Location = new System.Drawing.Point(147, 178);
            this.txtCantProdu.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantProdu.Name = "txtCantProdu";
            this.txtCantProdu.Size = new System.Drawing.Size(132, 22);
            this.txtCantProdu.TabIndex = 4;
            // 
            // txtNombreProdu
            // 
            this.txtNombreProdu.Location = new System.Drawing.Point(148, 116);
            this.txtNombreProdu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProdu.Name = "txtNombreProdu";
            this.txtNombreProdu.Size = new System.Drawing.Size(132, 22);
            this.txtNombreProdu.TabIndex = 4;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(147, 57);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(132, 22);
            this.txtCodBarras.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de barras";
            // 
            // txtListProducts
            // 
            this.txtListProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtListProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtListProducts.Location = new System.Drawing.Point(341, 90);
            this.txtListProducts.Name = "txtListProducts";
            this.txtListProducts.Size = new System.Drawing.Size(132, 449);
            this.txtListProducts.TabIndex = 2;
            this.txtListProducts.Text = "";
            this.txtListProducts.Visible = false;
            // 
            // frmLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtListProducts);
            this.Controls.Add(this.gpCargaProductos);
            this.Controls.Add(this.lblLibreria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLibreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLibreria";
            this.Load += new System.EventHandler(this.frmLibreria_Load);
            this.gpCargaProductos.ResumeLayout(false);
            this.gpCargaProductos.PerformLayout();
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
        private System.Windows.Forms.RichTextBox txtListProducts;
    }
}

