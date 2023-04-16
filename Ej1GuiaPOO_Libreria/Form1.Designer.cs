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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtNombreProdu = new System.Windows.Forms.TextBox();
            this.txtCantProdu = new System.Windows.Forms.TextBox();
            this.txtPrecioProdu = new System.Windows.Forms.TextBox();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.gpCargaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibreria
            // 
            this.lblLibreria.AutoSize = true;
            this.lblLibreria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibreria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLibreria.Location = new System.Drawing.Point(324, 9);
            this.lblLibreria.Name = "lblLibreria";
            this.lblLibreria.Size = new System.Drawing.Size(135, 41);
            this.lblLibreria.TabIndex = 0;
            this.lblLibreria.Text = "Libreria";
            // 
            // gpCargaProductos
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de barras";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
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
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(110, 46);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodBarras.TabIndex = 4;
            // 
            // txtNombreProdu
            // 
            this.txtNombreProdu.Location = new System.Drawing.Point(111, 94);
            this.txtNombreProdu.Name = "txtNombreProdu";
            this.txtNombreProdu.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProdu.TabIndex = 4;
            // 
            // txtCantProdu
            // 
            this.txtCantProdu.Location = new System.Drawing.Point(110, 145);
            this.txtCantProdu.Name = "txtCantProdu";
            this.txtCantProdu.Size = new System.Drawing.Size(100, 20);
            this.txtCantProdu.TabIndex = 4;
            // 
            // txtPrecioProdu
            // 
            this.txtPrecioProdu.Location = new System.Drawing.Point(111, 200);
            this.txtPrecioProdu.Name = "txtPrecioProdu";
            this.txtPrecioProdu.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProdu.TabIndex = 4;
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
            // 
            // frmLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpCargaProductos);
            this.Controls.Add(this.lblLibreria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}

