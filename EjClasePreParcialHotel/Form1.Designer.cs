namespace EjClasePreParcialHotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinalizarReserva = new System.Windows.Forms.Button();
            this.txtDineroReserva = new System.Windows.Forms.TextBox();
            this.btnAgregarHuesped = new System.Windows.Forms.Button();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtApellidoHuesped = new System.Windows.Forms.TextBox();
            this.txtNombreHuesped = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoHabitaciones = new System.Windows.Forms.ComboBox();
            this.txtInicioEstadia = new System.Windows.Forms.TextBox();
            this.txtFinEstadia = new System.Windows.Forms.TextBox();
            this.cmbMesEstadia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAbonaTotal = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAbonaTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnFinalizarReserva);
            this.groupBox1.Controls.Add(this.txtDineroReserva);
            this.groupBox1.Controls.Add(this.btnAgregarHuesped);
            this.groupBox1.Controls.Add(this.txtFinEstadia);
            this.groupBox1.Controls.Add(this.txtInicioEstadia);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtApellidoHuesped);
            this.groupBox1.Controls.Add(this.txtNombreHuesped);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMesEstadia);
            this.groupBox1.Controls.Add(this.cmbTipoHabitaciones);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 724);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AltaReserva";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(38, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar Reserva";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarReserva
            // 
            this.btnFinalizarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizarReserva.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarReserva.Location = new System.Drawing.Point(38, 613);
            this.btnFinalizarReserva.Name = "btnFinalizarReserva";
            this.btnFinalizarReserva.Size = new System.Drawing.Size(238, 45);
            this.btnFinalizarReserva.TabIndex = 4;
            this.btnFinalizarReserva.Text = "Finalizar Reserva";
            this.btnFinalizarReserva.UseVisualStyleBackColor = false;
            this.btnFinalizarReserva.Click += new System.EventHandler(this.btnFinalizarReserva_Click);
            // 
            // txtDineroReserva
            // 
            this.txtDineroReserva.Location = new System.Drawing.Point(155, 527);
            this.txtDineroReserva.Name = "txtDineroReserva";
            this.txtDineroReserva.Size = new System.Drawing.Size(121, 22);
            this.txtDineroReserva.TabIndex = 3;
            this.txtDineroReserva.Text = "Dinero reserva";
            this.txtDineroReserva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDineroReserva_MouseClick);
            // 
            // btnAgregarHuesped
            // 
            this.btnAgregarHuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarHuesped.Location = new System.Drawing.Point(87, 348);
            this.btnAgregarHuesped.Name = "btnAgregarHuesped";
            this.btnAgregarHuesped.Size = new System.Drawing.Size(145, 29);
            this.btnAgregarHuesped.TabIndex = 1;
            this.btnAgregarHuesped.Text = "Agregar Huesped";
            this.btnAgregarHuesped.UseVisualStyleBackColor = false;
            this.btnAgregarHuesped.Click += new System.EventHandler(this.btnAgregarHuesped_Click);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(99, 311);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(121, 22);
            this.txtdni.TabIndex = 2;
            this.txtdni.Text = "DNI";
            this.txtdni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdni_MouseClick);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(99, 273);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 22);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.Text = "Edad";
            this.txtEdad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEdad_MouseClick);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(99, 231);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(121, 22);
            this.txtFechaNacimiento.TabIndex = 2;
            this.txtFechaNacimiento.Text = "Fecha Nacimiento";
            this.txtFechaNacimiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFechaNacimiento_MouseClick);
            // 
            // txtApellidoHuesped
            // 
            this.txtApellidoHuesped.Location = new System.Drawing.Point(99, 190);
            this.txtApellidoHuesped.Name = "txtApellidoHuesped";
            this.txtApellidoHuesped.Size = new System.Drawing.Size(121, 22);
            this.txtApellidoHuesped.TabIndex = 2;
            this.txtApellidoHuesped.Text = "Apellido";
            this.txtApellidoHuesped.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtApellidoHuesped_MouseClick);
            // 
            // txtNombreHuesped
            // 
            this.txtNombreHuesped.Location = new System.Drawing.Point(99, 148);
            this.txtNombreHuesped.Name = "txtNombreHuesped";
            this.txtNombreHuesped.Size = new System.Drawing.Size(121, 22);
            this.txtNombreHuesped.TabIndex = 2;
            this.txtNombreHuesped.Text = "Nombre";
            this.txtNombreHuesped.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNombreHuesped_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Habitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Huesped";
            // 
            // cmbTipoHabitaciones
            // 
            this.cmbTipoHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHabitaciones.FormattingEnabled = true;
            this.cmbTipoHabitaciones.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Triple",
            "Cuadruple"});
            this.cmbTipoHabitaciones.Location = new System.Drawing.Point(70, 66);
            this.cmbTipoHabitaciones.Name = "cmbTipoHabitaciones";
            this.cmbTipoHabitaciones.Size = new System.Drawing.Size(183, 24);
            this.cmbTipoHabitaciones.TabIndex = 0;
            // 
            // txtInicioEstadia
            // 
            this.txtInicioEstadia.Location = new System.Drawing.Point(99, 402);
            this.txtInicioEstadia.Name = "txtInicioEstadia";
            this.txtInicioEstadia.Size = new System.Drawing.Size(121, 22);
            this.txtInicioEstadia.TabIndex = 2;
            this.txtInicioEstadia.Text = "Inicio Estadia";
            this.txtInicioEstadia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtInicioEstadia_MouseClick);
            // 
            // txtFinEstadia
            // 
            this.txtFinEstadia.Location = new System.Drawing.Point(99, 443);
            this.txtFinEstadia.Name = "txtFinEstadia";
            this.txtFinEstadia.Size = new System.Drawing.Size(121, 22);
            this.txtFinEstadia.TabIndex = 2;
            this.txtFinEstadia.Text = "Fin Estadia";
            this.txtFinEstadia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFinEstadia_MouseClick);
            // 
            // cmbMesEstadia
            // 
            this.cmbMesEstadia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesEstadia.FormattingEnabled = true;
            this.cmbMesEstadia.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesEstadia.Location = new System.Drawing.Point(70, 484);
            this.cmbMesEstadia.Name = "cmbMesEstadia";
            this.cmbMesEstadia.Size = new System.Drawing.Size(183, 24);
            this.cmbMesEstadia.TabIndex = 0;
            this.cmbMesEstadia.SelectedValueChanged += new System.EventHandler(this.cmbMesEstadia_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pago Minimo $";
            // 
            // chkAbonaTotal
            // 
            this.chkAbonaTotal.AutoSize = true;
            this.chkAbonaTotal.Location = new System.Drawing.Point(111, 574);
            this.chkAbonaTotal.Name = "chkAbonaTotal";
            this.chkAbonaTotal.Size = new System.Drawing.Size(107, 20);
            this.chkAbonaTotal.TabIndex = 5;
            this.chkAbonaTotal.Text = "Abonar Total";
            this.chkAbonaTotal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 748);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarHuesped;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidoHuesped;
        private System.Windows.Forms.TextBox txtNombreHuesped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoHabitaciones;
        private System.Windows.Forms.Button btnFinalizarReserva;
        private System.Windows.Forms.TextBox txtDineroReserva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtFinEstadia;
        private System.Windows.Forms.TextBox txtInicioEstadia;
        private System.Windows.Forms.ComboBox cmbMesEstadia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAbonaTotal;
    }
}

