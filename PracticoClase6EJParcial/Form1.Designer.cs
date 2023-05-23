namespace PracticoClase6EJParcial
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
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Estacionamiento = new System.Windows.Forms.Label();
            this.txtCantHoras = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.checkCamionGob = new System.Windows.Forms.CheckBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbEstacionamiento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaEstaciona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEstacio = new System.Windows.Forms.TextBox();
            this.txtCapacidadAlta = new System.Windows.Forms.TextBox();
            this.txtCapacidadBaja = new System.Windows.Forms.TextBox();
            this.btnCargarEstacionamientos = new System.Windows.Forms.Button();
            this.gbIngreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.btnCargarEstacionamientos);
            this.gbIngreso.Controls.Add(this.btnRegistrarIngreso);
            this.gbIngreso.Controls.Add(this.label3);
            this.gbIngreso.Controls.Add(this.label2);
            this.gbIngreso.Controls.Add(this.label1);
            this.gbIngreso.Controls.Add(this.Estacionamiento);
            this.gbIngreso.Controls.Add(this.txtCantHoras);
            this.gbIngreso.Controls.Add(this.txtPatente);
            this.gbIngreso.Controls.Add(this.checkCamionGob);
            this.gbIngreso.Controls.Add(this.cmbVehiculo);
            this.gbIngreso.Controls.Add(this.cmbEstacionamiento);
            this.gbIngreso.Location = new System.Drawing.Point(575, 29);
            this.gbIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbIngreso.Size = new System.Drawing.Size(416, 486);
            this.gbIngreso.TabIndex = 0;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso";
            // 
            // btnRegistrarIngreso
            // 
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(157, 294);
            this.btnRegistrarIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(116, 23);
            this.btnRegistrarIngreso.TabIndex = 4;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = true;
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehiculo";
            // 
            // Estacionamiento
            // 
            this.Estacionamiento.AutoSize = true;
            this.Estacionamiento.Location = new System.Drawing.Point(84, 83);
            this.Estacionamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Estacionamiento.Name = "Estacionamiento";
            this.Estacionamiento.Size = new System.Drawing.Size(85, 13);
            this.Estacionamiento.TabIndex = 3;
            this.Estacionamiento.Text = "Estacionamiento";
            // 
            // txtCantHoras
            // 
            this.txtCantHoras.Location = new System.Drawing.Point(181, 231);
            this.txtCantHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantHoras.Name = "txtCantHoras";
            this.txtCantHoras.Size = new System.Drawing.Size(92, 20);
            this.txtCantHoras.TabIndex = 2;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(181, 179);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(92, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // checkCamionGob
            // 
            this.checkCamionGob.AutoSize = true;
            this.checkCamionGob.Location = new System.Drawing.Point(295, 134);
            this.checkCamionGob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkCamionGob.Name = "checkCamionGob";
            this.checkCamionGob.Size = new System.Drawing.Size(58, 17);
            this.checkCamionGob.TabIndex = 1;
            this.checkCamionGob.Text = "Estatal";
            this.checkCamionGob.UseVisualStyleBackColor = true;
            this.checkCamionGob.Visible = false;
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Items.AddRange(new object[] {
            "Moto",
            "Auto",
            "Camioneta",
            "Camion"});
            this.cmbVehiculo.Location = new System.Drawing.Point(181, 130);
            this.cmbVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(92, 21);
            this.cmbVehiculo.TabIndex = 0;
            // 
            // cmbEstacionamiento
            // 
            this.cmbEstacionamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacionamiento.FormattingEnabled = true;
            this.cmbEstacionamiento.Location = new System.Drawing.Point(181, 77);
            this.cmbEstacionamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstacionamiento.Name = "cmbEstacionamiento";
            this.cmbEstacionamiento.Size = new System.Drawing.Size(92, 21);
            this.cmbEstacionamiento.TabIndex = 0;
            this.cmbEstacionamiento.SelectedIndexChanged += new System.EventHandler(this.cmbEstacionamiento_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaEstaciona);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreEstacio);
            this.groupBox1.Controls.Add(this.txtCapacidadAlta);
            this.groupBox1.Controls.Add(this.txtCapacidadBaja);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(398, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Establecimiento";
            // 
            // btnAltaEstaciona
            // 
            this.btnAltaEstaciona.Location = new System.Drawing.Point(140, 217);
            this.btnAltaEstaciona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaEstaciona.Name = "btnAltaEstaciona";
            this.btnAltaEstaciona.Size = new System.Drawing.Size(81, 24);
            this.btnAltaEstaciona.TabIndex = 4;
            this.btnAltaEstaciona.Text = "Alta";
            this.btnAltaEstaciona.UseVisualStyleBackColor = true;
            this.btnAltaEstaciona.Click += new System.EventHandler(this.btnAltaEstaciona_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidad Baja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Capacidad alta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // txtNombreEstacio
            // 
            this.txtNombreEstacio.Location = new System.Drawing.Point(175, 64);
            this.txtNombreEstacio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreEstacio.Name = "txtNombreEstacio";
            this.txtNombreEstacio.Size = new System.Drawing.Size(92, 20);
            this.txtNombreEstacio.TabIndex = 2;
            // 
            // txtCapacidadAlta
            // 
            this.txtCapacidadAlta.Location = new System.Drawing.Point(175, 118);
            this.txtCapacidadAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCapacidadAlta.Name = "txtCapacidadAlta";
            this.txtCapacidadAlta.Size = new System.Drawing.Size(92, 20);
            this.txtCapacidadAlta.TabIndex = 2;
            // 
            // txtCapacidadBaja
            // 
            this.txtCapacidadBaja.Location = new System.Drawing.Point(175, 160);
            this.txtCapacidadBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCapacidadBaja.Name = "txtCapacidadBaja";
            this.txtCapacidadBaja.Size = new System.Drawing.Size(92, 20);
            this.txtCapacidadBaja.TabIndex = 2;
            // 
            // btnCargarEstacionamientos
            // 
            this.btnCargarEstacionamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCargarEstacionamientos.Location = new System.Drawing.Point(146, 18);
            this.btnCargarEstacionamientos.Name = "btnCargarEstacionamientos";
            this.btnCargarEstacionamientos.Size = new System.Drawing.Size(133, 39);
            this.btnCargarEstacionamientos.TabIndex = 5;
            this.btnCargarEstacionamientos.Text = "cargar Estacionamientos";
            this.btnCargarEstacionamientos.UseVisualStyleBackColor = false;
            this.btnCargarEstacionamientos.Visible = false;
            this.btnCargarEstacionamientos.Click += new System.EventHandler(this.btnCargarEstacionamientos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIngreso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.CheckBox checkCamionGob;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.ComboBox cmbEstacionamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Estacionamiento;
        private System.Windows.Forms.TextBox txtCantHoras;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaEstaciona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEstacio;
        private System.Windows.Forms.TextBox txtCapacidadAlta;
        private System.Windows.Forms.TextBox txtCapacidadBaja;
        private System.Windows.Forms.Button btnCargarEstacionamientos;
    }
}

