namespace Parcial1Resuelto2
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
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoEmp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAltaEmp = new System.Windows.Forms.Button();
            this.gridAuxiliares = new System.Windows.Forms.DataGridView();
            this.gridModelos = new System.Windows.Forms.DataGridView();
            this.gridPublicitarios = new System.Windows.Forms.DataGridView();
            this.gridPresentador = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpEvent = new System.Windows.Forms.TextBox();
            this.txtTipoEmpEvent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.btnCargaEvento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuxiliares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicitarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresentador)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaEmp);
            this.groupBox1.Controls.Add(this.txtNombreEmp);
            this.groupBox1.Controls.Add(this.cmbTipoEmp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AltaEmpleado";
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(111, 35);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Completo";
            // 
            // cmbTipoEmp
            // 
            this.cmbTipoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmp.FormattingEnabled = true;
            this.cmbTipoEmp.Items.AddRange(new object[] {
            "Auxiliar",
            "Modelo",
            "Publicitario",
            "Presentador"});
            this.cmbTipoEmp.Location = new System.Drawing.Point(45, 80);
            this.cmbTipoEmp.Name = "cmbTipoEmp";
            this.cmbTipoEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEmp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Empleado";
            // 
            // btnAltaEmp
            // 
            this.btnAltaEmp.Location = new System.Drawing.Point(70, 122);
            this.btnAltaEmp.Name = "btnAltaEmp";
            this.btnAltaEmp.Size = new System.Drawing.Size(75, 23);
            this.btnAltaEmp.TabIndex = 3;
            this.btnAltaEmp.Text = "Alta Empleado";
            this.btnAltaEmp.UseVisualStyleBackColor = true;
            this.btnAltaEmp.Click += new System.EventHandler(this.btnAltaEmp_Click);
            // 
            // gridAuxiliares
            // 
            this.gridAuxiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuxiliares.Location = new System.Drawing.Point(261, 12);
            this.gridAuxiliares.Name = "gridAuxiliares";
            this.gridAuxiliares.Size = new System.Drawing.Size(240, 150);
            this.gridAuxiliares.TabIndex = 1;
            this.gridAuxiliares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAuxiliares_CellContentClick);
            // 
            // gridModelos
            // 
            this.gridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModelos.Location = new System.Drawing.Point(519, 12);
            this.gridModelos.Name = "gridModelos";
            this.gridModelos.Size = new System.Drawing.Size(240, 150);
            this.gridModelos.TabIndex = 1;
            // 
            // gridPublicitarios
            // 
            this.gridPublicitarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublicitarios.Location = new System.Drawing.Point(261, 177);
            this.gridPublicitarios.Name = "gridPublicitarios";
            this.gridPublicitarios.Size = new System.Drawing.Size(240, 150);
            this.gridPublicitarios.TabIndex = 1;
            // 
            // gridPresentador
            // 
            this.gridPresentador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPresentador.Location = new System.Drawing.Point(519, 177);
            this.gridPresentador.Name = "gridPresentador";
            this.gridPresentador.Size = new System.Drawing.Size(240, 150);
            this.gridPresentador.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargaEvento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHorasTrabajadas);
            this.groupBox2.Controls.Add(this.txtTipoEmpEvent);
            this.groupBox2.Controls.Add(this.txtNombreEmpEvent);
            this.groupBox2.Location = new System.Drawing.Point(25, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CargaEvento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo";
            // 
            // txtNombreEmpEvent
            // 
            this.txtNombreEmpEvent.Location = new System.Drawing.Point(111, 32);
            this.txtNombreEmpEvent.Name = "txtNombreEmpEvent";
            this.txtNombreEmpEvent.ReadOnly = true;
            this.txtNombreEmpEvent.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpEvent.TabIndex = 1;
            // 
            // txtTipoEmpEvent
            // 
            this.txtTipoEmpEvent.Location = new System.Drawing.Point(111, 76);
            this.txtTipoEmpEvent.Name = "txtTipoEmpEvent";
            this.txtTipoEmpEvent.ReadOnly = true;
            this.txtTipoEmpEvent.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEmpEvent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo emp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horas Trabajadas";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(111, 113);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabajadas.TabIndex = 1;
            // 
            // btnCargaEvento
            // 
            this.btnCargaEvento.Location = new System.Drawing.Point(45, 212);
            this.btnCargaEvento.Name = "btnCargaEvento";
            this.btnCargaEvento.Size = new System.Drawing.Size(108, 23);
            this.btnCargaEvento.TabIndex = 3;
            this.btnCargaEvento.Text = "Carga Evento";
            this.btnCargaEvento.UseVisualStyleBackColor = true;
            this.btnCargaEvento.Click += new System.EventHandler(this.btnCargaEvento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridPresentador);
            this.Controls.Add(this.gridModelos);
            this.Controls.Add(this.gridPublicitarios);
            this.Controls.Add(this.gridAuxiliares);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuxiliares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicitarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresentador)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaEmp;
        private System.Windows.Forms.ComboBox cmbTipoEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.DataGridView gridAuxiliares;
        private System.Windows.Forms.DataGridView gridModelos;
        private System.Windows.Forms.DataGridView gridPublicitarios;
        private System.Windows.Forms.DataGridView gridPresentador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargaEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtTipoEmpEvent;
        private System.Windows.Forms.TextBox txtNombreEmpEvent;
    }
}

