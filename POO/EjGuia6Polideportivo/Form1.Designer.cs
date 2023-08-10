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
            this.btnAltaCancha = new System.Windows.Forms.Button();
            this.cbTipoNuevaCancha = new System.Windows.Forms.ComboBox();
            this.gvCanchas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreJuez = new System.Windows.Forms.TextBox();
            this.btnAltaJuez = new System.Windows.Forms.Button();
            this.gridJuez = new System.Windows.Forms.DataGridView();
            this.alquilarCancha = new System.Windows.Forms.GroupBox();
            this.chkListJueces = new System.Windows.Forms.CheckedListBox();
            this.checkJueces = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroCancha = new System.Windows.Forms.TextBox();
            this.txtNombreCancha = new System.Windows.Forms.TextBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblhoras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecaudacionTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCanchas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJuez)).BeginInit();
            this.alquilarCancha.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polideportivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaCancha);
            this.groupBox1.Controls.Add(this.cbTipoNuevaCancha);
            this.groupBox1.Location = new System.Drawing.Point(173, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(160, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AltaCancha";
            // 
            // btnAltaCancha
            // 
            this.btnAltaCancha.Location = new System.Drawing.Point(43, 66);
            this.btnAltaCancha.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltaCancha.Name = "btnAltaCancha";
            this.btnAltaCancha.Size = new System.Drawing.Size(69, 19);
            this.btnAltaCancha.TabIndex = 1;
            this.btnAltaCancha.Text = "Alta Cancha";
            this.btnAltaCancha.UseVisualStyleBackColor = true;
            this.btnAltaCancha.Click += new System.EventHandler(this.btnAltaCancha_Click);
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
            this.cbTipoNuevaCancha.Location = new System.Drawing.Point(32, 25);
            this.cbTipoNuevaCancha.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoNuevaCancha.Name = "cbTipoNuevaCancha";
            this.cbTipoNuevaCancha.Size = new System.Drawing.Size(92, 21);
            this.cbTipoNuevaCancha.TabIndex = 0;
            // 
            // gvCanchas
            // 
            this.gvCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCanchas.Location = new System.Drawing.Point(20, 189);
            this.gvCanchas.Margin = new System.Windows.Forms.Padding(2);
            this.gvCanchas.Name = "gvCanchas";
            this.gvCanchas.RowHeadersWidth = 51;
            this.gvCanchas.RowTemplate.Height = 24;
            this.gvCanchas.Size = new System.Drawing.Size(467, 199);
            this.gvCanchas.TabIndex = 2;
            this.gvCanchas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCanchas_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombreJuez);
            this.groupBox2.Controls.Add(this.btnAltaJuez);
            this.groupBox2.Location = new System.Drawing.Point(862, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(229, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AltaJuez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtNombreJuez
            // 
            this.txtNombreJuez.Location = new System.Drawing.Point(95, 25);
            this.txtNombreJuez.Name = "txtNombreJuez";
            this.txtNombreJuez.Size = new System.Drawing.Size(120, 20);
            this.txtNombreJuez.TabIndex = 2;
            // 
            // btnAltaJuez
            // 
            this.btnAltaJuez.Location = new System.Drawing.Point(79, 66);
            this.btnAltaJuez.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltaJuez.Name = "btnAltaJuez";
            this.btnAltaJuez.Size = new System.Drawing.Size(69, 19);
            this.btnAltaJuez.TabIndex = 1;
            this.btnAltaJuez.Text = "Alta Juez";
            this.btnAltaJuez.UseVisualStyleBackColor = true;
            this.btnAltaJuez.Click += new System.EventHandler(this.btnAltaJuez_Click);
            // 
            // gridJuez
            // 
            this.gridJuez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJuez.Location = new System.Drawing.Point(785, 189);
            this.gridJuez.Margin = new System.Windows.Forms.Padding(2);
            this.gridJuez.Name = "gridJuez";
            this.gridJuez.RowHeadersWidth = 51;
            this.gridJuez.RowTemplate.Height = 24;
            this.gridJuez.Size = new System.Drawing.Size(383, 199);
            this.gridJuez.TabIndex = 2;
            // 
            // alquilarCancha
            // 
            this.alquilarCancha.Controls.Add(this.btnAlquilar);
            this.alquilarCancha.Controls.Add(this.chkListJueces);
            this.alquilarCancha.Controls.Add(this.checkJueces);
            this.alquilarCancha.Controls.Add(this.lblhoras);
            this.alquilarCancha.Controls.Add(this.label4);
            this.alquilarCancha.Controls.Add(this.label3);
            this.alquilarCancha.Controls.Add(this.txtHoras);
            this.alquilarCancha.Controls.Add(this.txtNroCancha);
            this.alquilarCancha.Controls.Add(this.txtNombreCancha);
            this.alquilarCancha.Location = new System.Drawing.Point(530, 83);
            this.alquilarCancha.Name = "alquilarCancha";
            this.alquilarCancha.Size = new System.Drawing.Size(218, 347);
            this.alquilarCancha.TabIndex = 3;
            this.alquilarCancha.TabStop = false;
            this.alquilarCancha.Text = "AlquilarCancha";
            // 
            // chkListJueces
            // 
            this.chkListJueces.FormattingEnabled = true;
            this.chkListJueces.Location = new System.Drawing.Point(49, 146);
            this.chkListJueces.Name = "chkListJueces";
            this.chkListJueces.Size = new System.Drawing.Size(120, 49);
            this.chkListJueces.TabIndex = 4;
            this.chkListJueces.Visible = false;
            // 
            // checkJueces
            // 
            this.checkJueces.AutoSize = true;
            this.checkJueces.Location = new System.Drawing.Point(59, 123);
            this.checkJueces.Name = "checkJueces";
            this.checkJueces.Size = new System.Drawing.Size(100, 17);
            this.checkJueces.TabIndex = 3;
            this.checkJueces.Text = "Agregar Jueces";
            this.checkJueces.UseVisualStyleBackColor = true;
            this.checkJueces.CheckedChanged += new System.EventHandler(this.checkJueces_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cancha";
            // 
            // txtNroCancha
            // 
            this.txtNroCancha.Location = new System.Drawing.Point(87, 66);
            this.txtNroCancha.Name = "txtNroCancha";
            this.txtNroCancha.Size = new System.Drawing.Size(35, 20);
            this.txtNroCancha.TabIndex = 0;
            // 
            // txtNombreCancha
            // 
            this.txtNombreCancha.Location = new System.Drawing.Point(87, 40);
            this.txtNombreCancha.Name = "txtNombreCancha";
            this.txtNombreCancha.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCancha.TabIndex = 0;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(71, 227);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(75, 23);
            this.btnAlquilar.TabIndex = 5;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(87, 92);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(35, 20);
            this.txtHoras.TabIndex = 0;
            // 
            // lblhoras
            // 
            this.lblhoras.AutoSize = true;
            this.lblhoras.Location = new System.Drawing.Point(37, 94);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(35, 13);
            this.lblhoras.TabIndex = 2;
            this.lblhoras.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recaudacion total";
            // 
            // txtRecaudacionTotal
            // 
            this.txtRecaudacionTotal.Location = new System.Drawing.Point(173, 416);
            this.txtRecaudacionTotal.Name = "txtRecaudacionTotal";
            this.txtRecaudacionTotal.Size = new System.Drawing.Size(100, 20);
            this.txtRecaudacionTotal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 530);
            this.Controls.Add(this.txtRecaudacionTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alquilarCancha);
            this.Controls.Add(this.gridJuez);
            this.Controls.Add(this.gvCanchas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCanchas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJuez)).EndInit();
            this.alquilarCancha.ResumeLayout(false);
            this.alquilarCancha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvCanchas;
        private System.Windows.Forms.Button btnAltaCancha;
        private System.Windows.Forms.ComboBox cbTipoNuevaCancha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAltaJuez;
        private System.Windows.Forms.TextBox txtNombreJuez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridJuez;
        private System.Windows.Forms.GroupBox alquilarCancha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroCancha;
        private System.Windows.Forms.TextBox txtNombreCancha;
        private System.Windows.Forms.CheckedListBox chkListJueces;
        private System.Windows.Forms.CheckBox checkJueces;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Label lblhoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecaudacionTotal;
    }
}

