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
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(90, 105);
            this.txtNombrePersona.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(92, 20);
            this.txtNombrePersona.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(90, 183);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(92, 20);
            this.txtEdad.TabIndex = 0;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(90, 147);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(92, 20);
            this.txtLegajo.TabIndex = 0;
            // 
            // cbgenero
            // 
            this.cbgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgenero.FormattingEnabled = true;
            this.cbgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbgenero.Location = new System.Drawing.Point(90, 223);
            this.cbgenero.Margin = new System.Windows.Forms.Padding(2);
            this.cbgenero.Name = "cbgenero";
            this.cbgenero.Size = new System.Drawing.Size(92, 21);
            this.cbgenero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "CARGA PERSONAS";
            // 
            // btnCargarPersona
            // 
            this.btnCargarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPersona.Location = new System.Drawing.Point(90, 275);
            this.btnCargarPersona.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarPersona.Name = "btnCargarPersona";
            this.btnCargarPersona.Size = new System.Drawing.Size(91, 32);
            this.btnCargarPersona.TabIndex = 4;
            this.btnCargarPersona.Text = "Cargar";
            this.btnCargarPersona.UseVisualStyleBackColor = true;
            this.btnCargarPersona.Click += new System.EventHandler(this.btnCargarPersona_Click);
            // 
            // GridPersonas
            // 
            this.GridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPersonas.Location = new System.Drawing.Point(376, -2);
            this.GridPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.GridPersonas.Name = "GridPersonas";
            this.GridPersonas.RowHeadersWidth = 51;
            this.GridPersonas.RowTemplate.Height = 24;
            this.GridPersonas.Size = new System.Drawing.Size(470, 365);
            this.GridPersonas.TabIndex = 5;
            this.GridPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPersonas_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mujeres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total";
            // 
            // txtHombres
            // 
            this.txtHombres.Location = new System.Drawing.Point(306, 109);
            this.txtHombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtHombres.Name = "txtHombres";
            this.txtHombres.Size = new System.Drawing.Size(36, 20);
            this.txtHombres.TabIndex = 7;
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(306, 145);
            this.txtMujeres.Margin = new System.Windows.Forms.Padding(2);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.Size = new System.Drawing.Size(36, 20);
            this.txtMujeres.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(306, 185);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(36, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(438, 388);
            this.lstNombres.Margin = new System.Windows.Forms.Padding(2);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(91, 147);
            this.lstNombres.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nombres";
            // 
            // btnEnlazar
            // 
            this.btnEnlazar.Location = new System.Drawing.Point(90, 333);
            this.btnEnlazar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnlazar.Name = "btnEnlazar";
            this.btnEnlazar.Size = new System.Drawing.Size(91, 30);
            this.btnEnlazar.TabIndex = 10;
            this.btnEnlazar.Text = "Enlazar";
            this.btnEnlazar.UseVisualStyleBackColor = true;
            this.btnEnlazar.Click += new System.EventHandler(this.btnEnlazar_Click);
            // 
            // lstEdad
            // 
            this.lstEdad.FormattingEnabled = true;
            this.lstEdad.Location = new System.Drawing.Point(579, 388);
            this.lstEdad.Margin = new System.Windows.Forms.Padding(2);
            this.lstEdad.Name = "lstEdad";
            this.lstEdad.Size = new System.Drawing.Size(91, 147);
            this.lstEdad.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 372);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Edad";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(256, 230);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 42);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightGreen;
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(256, 277);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 42);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(842, 552);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbgenero);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombrePersona);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label5;
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
    }
}

