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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Estacionamiento = new System.Windows.Forms.Label();
            this.txtCantHoras = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.checkCamionGob = new System.Windows.Forms.CheckBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbEstacionamiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaEstaciona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCapacidadBaja = new System.Windows.Forms.TextBox();
            this.txtNombreEstacio = new System.Windows.Forms.TextBox();
            this.txtCapacidadAlta = new System.Windows.Forms.TextBox();
            this.gbIngreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
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
            this.gbIngreso.Location = new System.Drawing.Point(767, 36);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(555, 598);
            this.gbIngreso.TabIndex = 0;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehiculo";
            // 
            // Estacionamiento
            // 
            this.Estacionamiento.AutoSize = true;
            this.Estacionamiento.Location = new System.Drawing.Point(104, 79);
            this.Estacionamiento.Name = "Estacionamiento";
            this.Estacionamiento.Size = new System.Drawing.Size(107, 16);
            this.Estacionamiento.TabIndex = 3;
            this.Estacionamiento.Text = "Estacionamiento";
            // 
            // txtCantHoras
            // 
            this.txtCantHoras.Location = new System.Drawing.Point(233, 261);
            this.txtCantHoras.Name = "txtCantHoras";
            this.txtCantHoras.Size = new System.Drawing.Size(121, 22);
            this.txtCantHoras.TabIndex = 2;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(233, 197);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 22);
            this.txtPatente.TabIndex = 2;
            // 
            // checkCamionGob
            // 
            this.checkCamionGob.AutoSize = true;
            this.checkCamionGob.Location = new System.Drawing.Point(385, 141);
            this.checkCamionGob.Name = "checkCamionGob";
            this.checkCamionGob.Size = new System.Drawing.Size(70, 20);
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
            this.cmbVehiculo.Location = new System.Drawing.Point(233, 137);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(121, 24);
            this.cmbVehiculo.TabIndex = 0;
            // 
            // cmbEstacionamiento
            // 
            this.cmbEstacionamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacionamiento.FormattingEnabled = true;
            this.cmbEstacionamiento.Location = new System.Drawing.Point(233, 71);
            this.cmbEstacionamiento.Name = "cmbEstacionamiento";
            this.cmbEstacionamiento.Size = new System.Drawing.Size(121, 24);
            this.cmbEstacionamiento.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patente";
            // 
            // btnRegistrarIngreso
            // 
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(187, 338);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(155, 28);
            this.btnRegistrarIngreso.TabIndex = 4;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(46, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Establecimiento";
            // 
            // btnAltaEstaciona
            // 
            this.btnAltaEstaciona.Location = new System.Drawing.Point(187, 267);
            this.btnAltaEstaciona.Name = "btnAltaEstaciona";
            this.btnAltaEstaciona.Size = new System.Drawing.Size(108, 30);
            this.btnAltaEstaciona.TabIndex = 4;
            this.btnAltaEstaciona.Text = "Alta";
            this.btnAltaEstaciona.UseVisualStyleBackColor = true;
            this.btnAltaEstaciona.Click += new System.EventHandler(this.btnAltaEstaciona_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidad Baja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Capacidad alta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // txtCapacidadBaja
            // 
            this.txtCapacidadBaja.Location = new System.Drawing.Point(233, 197);
            this.txtCapacidadBaja.Name = "txtCapacidadBaja";
            this.txtCapacidadBaja.Size = new System.Drawing.Size(121, 22);
            this.txtCapacidadBaja.TabIndex = 2;
            // 
            // txtNombreEstacio
            // 
            this.txtNombreEstacio.Location = new System.Drawing.Point(233, 79);
            this.txtNombreEstacio.Name = "txtNombreEstacio";
            this.txtNombreEstacio.Size = new System.Drawing.Size(121, 22);
            this.txtNombreEstacio.TabIndex = 2;
            // 
            // txtCapacidadAlta
            // 
            this.txtCapacidadAlta.Location = new System.Drawing.Point(233, 145);
            this.txtCapacidadAlta.Name = "txtCapacidadAlta";
            this.txtCapacidadAlta.Size = new System.Drawing.Size(121, 22);
            this.txtCapacidadAlta.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIngreso);
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
    }
}

