namespace TelevisorObjetos
{
    partial class frmFormCompletar
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
            this.btnCrearTv = new System.Windows.Forms.Button();
            this.txtTVNombre = new System.Windows.Forms.TextBox();
            this.txtIdTV = new System.Windows.Forms.TextBox();
            this.txtTVDefinicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTVID = new System.Windows.Forms.Label();
            this.lblTVNombre = new System.Windows.Forms.Label();
            this.lblTVDefinicion = new System.Windows.Forms.Label();
            this.btnMostrarCaracteristicas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearTv
            // 
            this.btnCrearTv.Location = new System.Drawing.Point(398, 76);
            this.btnCrearTv.Name = "btnCrearTv";
            this.btnCrearTv.Size = new System.Drawing.Size(125, 68);
            this.btnCrearTv.TabIndex = 0;
            this.btnCrearTv.Text = "Crear TV";
            this.btnCrearTv.UseVisualStyleBackColor = true;
            this.btnCrearTv.Click += new System.EventHandler(this.btnCrearTv_Click);
            // 
            // txtTVNombre
            // 
            this.txtTVNombre.Location = new System.Drawing.Point(100, 104);
            this.txtTVNombre.Name = "txtTVNombre";
            this.txtTVNombre.Size = new System.Drawing.Size(100, 22);
            this.txtTVNombre.TabIndex = 1;
            // 
            // txtIdTV
            // 
            this.txtIdTV.Location = new System.Drawing.Point(100, 58);
            this.txtIdTV.Name = "txtIdTV";
            this.txtIdTV.Size = new System.Drawing.Size(100, 22);
            this.txtIdTV.TabIndex = 2;
            // 
            // txtTVDefinicion
            // 
            this.txtTVDefinicion.Location = new System.Drawing.Point(100, 149);
            this.txtTVDefinicion.Name = "txtTVDefinicion";
            this.txtTVDefinicion.Size = new System.Drawing.Size(100, 22);
            this.txtTVDefinicion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los valores del TV a crear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Definicion";
            // 
            // lblTVID
            // 
            this.lblTVID.AutoSize = true;
            this.lblTVID.Location = new System.Drawing.Point(81, 37);
            this.lblTVID.Name = "lblTVID";
            this.lblTVID.Size = new System.Drawing.Size(20, 16);
            this.lblTVID.TabIndex = 8;
            this.lblTVID.Text = "ID";
            // 
            // lblTVNombre
            // 
            this.lblTVNombre.AutoSize = true;
            this.lblTVNombre.Location = new System.Drawing.Point(81, 72);
            this.lblTVNombre.Name = "lblTVNombre";
            this.lblTVNombre.Size = new System.Drawing.Size(66, 16);
            this.lblTVNombre.TabIndex = 9;
            this.lblTVNombre.Text = "NOMBRE";
            // 
            // lblTVDefinicion
            // 
            this.lblTVDefinicion.AutoSize = true;
            this.lblTVDefinicion.Location = new System.Drawing.Point(81, 112);
            this.lblTVDefinicion.Name = "lblTVDefinicion";
            this.lblTVDefinicion.Size = new System.Drawing.Size(82, 16);
            this.lblTVDefinicion.TabIndex = 10;
            this.lblTVDefinicion.Text = "DEFINICION";
            // 
            // btnMostrarCaracteristicas
            // 
            this.btnMostrarCaracteristicas.Location = new System.Drawing.Point(398, 313);
            this.btnMostrarCaracteristicas.Name = "btnMostrarCaracteristicas";
            this.btnMostrarCaracteristicas.Size = new System.Drawing.Size(125, 73);
            this.btnMostrarCaracteristicas.TabIndex = 11;
            this.btnMostrarCaracteristicas.Text = "Mostrar TV";
            this.btnMostrarCaracteristicas.UseVisualStyleBackColor = true;
            this.btnMostrarCaracteristicas.Click += new System.EventHandler(this.btnMostrarCaracteristicas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTVNombre);
            this.groupBox1.Controls.Add(this.txtIdTV);
            this.groupBox1.Controls.Add(this.txtTVDefinicion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTVID);
            this.groupBox2.Controls.Add(this.lblTVNombre);
            this.groupBox2.Controls.Add(this.lblTVDefinicion);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 180);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // frmFormCompletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrarCaracteristicas);
            this.Controls.Add(this.btnCrearTv);
            this.Name = "frmFormCompletar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTv;
        private System.Windows.Forms.TextBox txtTVNombre;
        private System.Windows.Forms.TextBox txtIdTV;
        private System.Windows.Forms.TextBox txtTVDefinicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTVID;
        private System.Windows.Forms.Label lblTVNombre;
        private System.Windows.Forms.Label lblTVDefinicion;
        private System.Windows.Forms.Button btnMostrarCaracteristicas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

