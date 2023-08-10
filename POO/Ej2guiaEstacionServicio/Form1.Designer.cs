namespace Ej2guiaEstacionServicio
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFormParent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedirectCargaNafta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedirectGenerarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedirectCrearSurtidor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedirectRecargaSurtidor = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFormParent,
            this.btnRedirectCargaNafta,
            this.btnRedirectGenerarVenta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFormParent
            // 
            this.MenuFormParent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRedirectCrearSurtidor,
            this.btnRedirectRecargaSurtidor});
            this.MenuFormParent.Name = "MenuFormParent";
            this.MenuFormParent.Size = new System.Drawing.Size(76, 26);
            this.MenuFormParent.Text = "Surtidor";
            this.MenuFormParent.Click += new System.EventHandler(this.cargaSurtidorToolStripMenuItem_Click);
            // 
            // btnRedirectCargaNafta
            // 
            this.btnRedirectCargaNafta.Name = "btnRedirectCargaNafta";
            this.btnRedirectCargaNafta.Size = new System.Drawing.Size(148, 26);
            this.btnRedirectCargaNafta.Text = "Carga combustible";
            this.btnRedirectCargaNafta.Click += new System.EventHandler(this.cargaToolStripMenuItem_Click);
            // 
            // btnRedirectGenerarVenta
            // 
            this.btnRedirectGenerarVenta.Name = "btnRedirectGenerarVenta";
            this.btnRedirectGenerarVenta.Size = new System.Drawing.Size(115, 26);
            this.btnRedirectGenerarVenta.Text = "Generar venta";
            // 
            // btnRedirectCrearSurtidor
            // 
            this.btnRedirectCrearSurtidor.Name = "btnRedirectCrearSurtidor";
            this.btnRedirectCrearSurtidor.Size = new System.Drawing.Size(224, 26);
            this.btnRedirectCrearSurtidor.Text = "Crear Surtidor";
            this.btnRedirectCrearSurtidor.Click += new System.EventHandler(this.btnRedirectCrearSurtidor_Click);
            // 
            // btnRedirectRecargaSurtidor
            // 
            this.btnRedirectRecargaSurtidor.Name = "btnRedirectRecargaSurtidor";
            this.btnRedirectRecargaSurtidor.Size = new System.Drawing.Size(224, 26);
            this.btnRedirectRecargaSurtidor.Text = "Recargar Surtidor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFormParent;
        private System.Windows.Forms.ToolStripMenuItem btnRedirectCargaNafta;
        private System.Windows.Forms.ToolStripMenuItem btnRedirectGenerarVenta;
        private System.Windows.Forms.ToolStripMenuItem btnRedirectCrearSurtidor;
        private System.Windows.Forms.ToolStripMenuItem btnRedirectRecargaSurtidor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

