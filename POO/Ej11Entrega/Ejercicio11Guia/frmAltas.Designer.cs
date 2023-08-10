namespace Ejercicio11Guia
{
    partial class frmAltas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.chkMedico = new System.Windows.Forms.CheckBox();
            this.txtCoberturaMedica = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gpPersonalMedico = new System.Windows.Forms.GroupBox();
            this.cmbNumTurnos = new System.Windows.Forms.ComboBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnVerListPacientes = new System.Windows.Forms.Button();
            this.btnVerListMedicos = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.txtTurnosDisponibles = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpPersonalMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.chkMedico);
            this.groupBox1.Controls.Add(this.txtCoberturaMedica);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.gpPersonalMedico);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(140, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(74, 308);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // chkMedico
            // 
            this.chkMedico.AutoSize = true;
            this.chkMedico.Location = new System.Drawing.Point(26, 149);
            this.chkMedico.Name = "chkMedico";
            this.chkMedico.Size = new System.Drawing.Size(105, 17);
            this.chkMedico.TabIndex = 2;
            this.chkMedico.Text = "Personal Medico";
            this.chkMedico.UseVisualStyleBackColor = true;
            this.chkMedico.CheckedChanged += new System.EventHandler(this.chkMedico_CheckedChanged);
            // 
            // txtCoberturaMedica
            // 
            this.txtCoberturaMedica.Location = new System.Drawing.Point(115, 111);
            this.txtCoberturaMedica.Name = "txtCoberturaMedica";
            this.txtCoberturaMedica.Size = new System.Drawing.Size(100, 20);
            this.txtCoberturaMedica.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 70);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // gpPersonalMedico
            // 
            this.gpPersonalMedico.Controls.Add(this.cmbNumTurnos);
            this.gpPersonalMedico.Controls.Add(this.txtTarifa);
            this.gpPersonalMedico.Controls.Add(this.cmbEspecialidad);
            this.gpPersonalMedico.Controls.Add(this.label4);
            this.gpPersonalMedico.Controls.Add(this.label5);
            this.gpPersonalMedico.Controls.Add(this.label3);
            this.gpPersonalMedico.Location = new System.Drawing.Point(39, 172);
            this.gpPersonalMedico.Name = "gpPersonalMedico";
            this.gpPersonalMedico.Size = new System.Drawing.Size(152, 113);
            this.gpPersonalMedico.TabIndex = 2;
            this.gpPersonalMedico.TabStop = false;
            this.gpPersonalMedico.Visible = false;
            // 
            // cmbNumTurnos
            // 
            this.cmbNumTurnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumTurnos.FormattingEnabled = true;
            this.cmbNumTurnos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumTurnos.Location = new System.Drawing.Point(89, 86);
            this.cmbNumTurnos.Name = "cmbNumTurnos";
            this.cmbNumTurnos.Size = new System.Drawing.Size(41, 21);
            this.cmbNumTurnos.TabIndex = 1;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(52, 61);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(78, 20);
            this.txtTarifa.TabIndex = 2;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Pediatria",
            "Obstetricia",
            "Oncologia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(9, 31);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Turnos por Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Especialidad";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarifa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CoberturaMedica";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(393, 45);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(395, 150);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // btnVerListPacientes
            // 
            this.btnVerListPacientes.Location = new System.Drawing.Point(420, 16);
            this.btnVerListPacientes.Name = "btnVerListPacientes";
            this.btnVerListPacientes.Size = new System.Drawing.Size(84, 23);
            this.btnVerListPacientes.TabIndex = 3;
            this.btnVerListPacientes.Text = "Ver Pacientes";
            this.btnVerListPacientes.UseVisualStyleBackColor = true;
            this.btnVerListPacientes.Click += new System.EventHandler(this.btnVerListPacientes_Click);
            // 
            // btnVerListMedicos
            // 
            this.btnVerListMedicos.Location = new System.Drawing.Point(510, 16);
            this.btnVerListMedicos.Name = "btnVerListMedicos";
            this.btnVerListMedicos.Size = new System.Drawing.Size(84, 23);
            this.btnVerListMedicos.TabIndex = 3;
            this.btnVerListMedicos.Text = "Ver Medicos";
            this.btnVerListMedicos.UseVisualStyleBackColor = true;
            this.btnVerListMedicos.Click += new System.EventHandler(this.btnVerListMedicos_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(420, 213);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(103, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "OrdenarMedicos";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Location = new System.Drawing.Point(557, 215);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(97, 13);
            this.lblTurnos.TabIndex = 5;
            this.lblTurnos.Text = "Turnos Disponibles";
            this.lblTurnos.Visible = false;
            // 
            // txtTurnosDisponibles
            // 
            this.txtTurnosDisponibles.Location = new System.Drawing.Point(660, 213);
            this.txtTurnosDisponibles.Name = "txtTurnosDisponibles";
            this.txtTurnosDisponibles.Size = new System.Drawing.Size(100, 20);
            this.txtTurnosDisponibles.TabIndex = 6;
            this.txtTurnosDisponibles.Visible = false;
            // 
            // frmAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTurnosDisponibles);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnVerListMedicos);
            this.Controls.Add(this.btnVerListPacientes);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmAltas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAltas_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpPersonalMedico.ResumeLayout(false);
            this.gpPersonalMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMedico;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpPersonalMedico;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNumTurnos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCoberturaMedica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnVerListPacientes;
        private System.Windows.Forms.Button btnVerListMedicos;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.TextBox txtTurnosDisponibles;
    }
}