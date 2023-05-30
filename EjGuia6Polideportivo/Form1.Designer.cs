namespace EjGuia6Polideportivo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvCanchas = new System.Windows.Forms.DataGridView();
            this.NumCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoNuevaCancha = new System.Windows.Forms.ComboBox();
            this.btnAltaCancha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCanchas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polideportivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaCancha);
            this.groupBox1.Controls.Add(this.cbTipoNuevaCancha);
            this.groupBox1.Location = new System.Drawing.Point(55, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AltaCancha";
            // 
            // gvCanchas
            // 
            this.gvCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCanchas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCancha,
            this.NombreCancha});
            this.gvCanchas.Location = new System.Drawing.Point(12, 235);
            this.gvCanchas.Name = "gvCanchas";
            this.gvCanchas.RowHeadersWidth = 51;
            this.gvCanchas.RowTemplate.Height = 24;
            this.gvCanchas.Size = new System.Drawing.Size(303, 245);
            this.gvCanchas.TabIndex = 2;
            // 
            // NumCancha
            // 
            this.NumCancha.HeaderText = "Num Cancha";
            this.NumCancha.MinimumWidth = 6;
            this.NumCancha.Name = "NumCancha";
            this.NumCancha.Width = 125;
            // 
            // NombreCancha
            // 
            this.NombreCancha.HeaderText = "Nombre Cancha";
            this.NombreCancha.MinimumWidth = 6;
            this.NombreCancha.Name = "NombreCancha";
            this.NombreCancha.Width = 125;
            // 
            // cbTipoNuevaCancha
            // 
            this.cbTipoNuevaCancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoNuevaCancha.FormattingEnabled = true;
            this.cbTipoNuevaCancha.Items.AddRange(new object[] {
            "Tenis",
            "Futbol5",
            "Futbol7",
            "Futbol11"});
            this.cbTipoNuevaCancha.Location = new System.Drawing.Point(42, 31);
            this.cbTipoNuevaCancha.Name = "cbTipoNuevaCancha";
            this.cbTipoNuevaCancha.Size = new System.Drawing.Size(121, 24);
            this.cbTipoNuevaCancha.TabIndex = 0;
            // 
            // btnAltaCancha
            // 
            this.btnAltaCancha.Location = new System.Drawing.Point(57, 81);
            this.btnAltaCancha.Name = "btnAltaCancha";
            this.btnAltaCancha.Size = new System.Drawing.Size(92, 23);
            this.btnAltaCancha.TabIndex = 1;
            this.btnAltaCancha.Text = "Alta Cancha";
            this.btnAltaCancha.UseVisualStyleBackColor = true;
            this.btnAltaCancha.Click += new System.EventHandler(this.btnAltaCancha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 652);
            this.Controls.Add(this.gvCanchas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCanchas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvCanchas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCancha;
        private System.Windows.Forms.Button btnAltaCancha;
        private System.Windows.Forms.ComboBox cbTipoNuevaCancha;
    }
}

