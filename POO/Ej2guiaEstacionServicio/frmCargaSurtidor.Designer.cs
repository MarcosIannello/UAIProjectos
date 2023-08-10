namespace Ej2guiaEstacionServicio
{
    partial class frmCargaSurtidor
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumSurtidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoNaftas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carga Surtidor";
            // 
            // txtNumSurtidor
            // 
            this.txtNumSurtidor.Location = new System.Drawing.Point(232, 126);
            this.txtNumSurtidor.Name = "txtNumSurtidor";
            this.txtNumSurtidor.Size = new System.Drawing.Size(100, 22);
            this.txtNumSurtidor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "num Surtidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacidad";
            // 
            // cbTipoNaftas
            // 
            this.cbTipoNaftas.FormattingEnabled = true;
            this.cbTipoNaftas.Location = new System.Drawing.Point(232, 187);
            this.cbTipoNaftas.Name = "cbTipoNaftas";
            this.cbTipoNaftas.Size = new System.Drawing.Size(121, 24);
            this.cbTipoNaftas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de nafta";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(232, 264);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 22);
            this.txtCapacidad.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cargar Nafta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCargaSurtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.cbTipoNaftas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumSurtidor);
            this.Controls.Add(this.label2);
            this.Name = "frmCargaSurtidor";
            this.Text = "frmCargaSurtidor";
            this.Load += new System.EventHandler(this.frmCargaSurtidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumSurtidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoNaftas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button button1;
    }
}