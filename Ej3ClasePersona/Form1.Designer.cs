namespace Ej3ClasePersona
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
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.cbgenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarPersona = new System.Windows.Forms.Button();
            this.GridPersonas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHombres = new System.Windows.Forms.TextBox();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEnlazar = new System.Windows.Forms.Button();
            this.lstEdad = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.TextBox();
            this.btnExiApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(123, 205);
            this.txtNombrePersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(121, 22);
            this.txtNombrePersona.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(123, 255);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 22);
            this.txtEdad.TabIndex = 0;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(123, 153);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(29, 22);
            this.txtLegajo.TabIndex = 0;
            // 
            // cbgenero
            // 
            this.cbgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgenero.FormattingEnabled = true;
            this.cbgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbgenero.Location = new System.Drawing.Point(123, 304);
            this.cbgenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbgenero.Name = "cbgenero";
            this.cbgenero.Size = new System.Drawing.Size(121, 24);
            this.cbgenero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genero";
            // 
            // btnCargarPersona
            // 
            this.btnCargarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPersona.Location = new System.Drawing.Point(123, 368);
            this.btnCargarPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarPersona.Name = "btnCargarPersona";
            this.btnCargarPersona.Size = new System.Drawing.Size(121, 39);
            this.btnCargarPersona.TabIndex = 4;
            this.btnCargarPersona.Text = "Cargar";
            this.btnCargarPersona.UseVisualStyleBackColor = true;
            this.btnCargarPersona.Click += new System.EventHandler(this.btnCargarPersona_Click);
            // 
            // GridPersonas
            // 
            this.GridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPersonas.Location = new System.Drawing.Point(540, -2);
            this.GridPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridPersonas.Name = "GridPersonas";
            this.GridPersonas.RowHeadersWidth = 51;
            this.GridPersonas.RowTemplate.Height = 24;
            this.GridPersonas.Size = new System.Drawing.Size(583, 449);
            this.GridPersonas.TabIndex = 5;
            this.GridPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPersonas_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mujeres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total";
            // 
            // txtHombres
            // 
            this.txtHombres.Location = new System.Drawing.Point(411, 164);
            this.txtHombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHombres.Name = "txtHombres";
            this.txtHombres.Size = new System.Drawing.Size(47, 22);
            this.txtHombres.TabIndex = 7;
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(411, 208);
            this.txtMujeres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.Size = new System.Drawing.Size(47, 22);
            this.txtMujeres.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(411, 258);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(47, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 16;
            this.lstNombres.Location = new System.Drawing.Point(584, 478);
            this.lstNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(120, 180);
            this.lstNombres.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nombres";
            // 
            // btnEnlazar
            // 
            this.btnEnlazar.Location = new System.Drawing.Point(123, 440);
            this.btnEnlazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnlazar.Name = "btnEnlazar";
            this.btnEnlazar.Size = new System.Drawing.Size(121, 37);
            this.btnEnlazar.TabIndex = 10;
            this.btnEnlazar.Text = "Enlazar";
            this.btnEnlazar.UseVisualStyleBackColor = true;
            this.btnEnlazar.Click += new System.EventHandler(this.btnEnlazar_Click);
            // 
            // lstEdad
            // 
            this.lstEdad.FormattingEnabled = true;
            this.lstEdad.ItemHeight = 16;
            this.lstEdad.Location = new System.Drawing.Point(772, 478);
            this.lstEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEdad.Name = "lstEdad";
            this.lstEdad.Size = new System.Drawing.Size(120, 180);
            this.lstEdad.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(799, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Edad";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Location = new System.Drawing.Point(344, 313);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 52);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightGreen;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(344, 371);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 52);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(169, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.titulo.Location = new System.Drawing.Point(12, 37);
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Size = new System.Drawing.Size(520, 57);
            this.titulo.TabIndex = 13;
            this.titulo.Text = "CARGA DE PERSONAS";
            this.titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExiApp
            // 
            this.btnExiApp.BackColor = System.Drawing.Color.White;
            this.btnExiApp.ForeColor = System.Drawing.Color.Red;
            this.btnExiApp.Location = new System.Drawing.Point(17, 8);
            this.btnExiApp.Name = "btnExiApp";
            this.btnExiApp.Size = new System.Drawing.Size(75, 23);
            this.btnExiApp.TabIndex = 14;
            this.btnExiApp.Text = "X";
            this.btnExiApp.UseVisualStyleBackColor = false;
            this.btnExiApp.Click += new System.EventHandler(this.btnExiApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1123, 679);
            this.Controls.Add(this.btnExiApp);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEnlazar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstEdad);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMujeres);
            this.Controls.Add(this.txtHombres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GridPersonas);
            this.Controls.Add(this.btnCargarPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbgenero);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombrePersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox cbgenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarPersona;
        private System.Windows.Forms.DataGridView GridPersonas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHombres;
        private System.Windows.Forms.TextBox txtMujeres;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEnlazar;
        private System.Windows.Forms.ListBox lstEdad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Button btnExiApp;
    }
}

