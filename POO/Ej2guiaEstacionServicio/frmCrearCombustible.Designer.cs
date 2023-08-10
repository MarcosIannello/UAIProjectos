namespace Ej2guiaEstacionServicio
{
    partial class frmCrearCombustible
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioNafta = new System.Windows.Forms.TextBox();
            this.btnCrearCombustible = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNombreCombustible = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga de combustible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Combustible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio por litro";
            // 
            // txtPrecioNafta
            // 
            this.txtPrecioNafta.Location = new System.Drawing.Point(161, 111);
            this.txtPrecioNafta.Name = "txtPrecioNafta";
            this.txtPrecioNafta.Size = new System.Drawing.Size(121, 22);
            this.txtPrecioNafta.TabIndex = 3;
            // 
            // btnCrearCombustible
            // 
            this.btnCrearCombustible.Location = new System.Drawing.Point(75, 186);
            this.btnCrearCombustible.Name = "btnCrearCombustible";
            this.btnCrearCombustible.Size = new System.Drawing.Size(133, 23);
            this.btnCrearCombustible.TabIndex = 4;
            this.btnCrearCombustible.Text = "Crear combustible";
            this.btnCrearCombustible.UseVisualStyleBackColor = true;
            this.btnCrearCombustible.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNombreCombustible);
            this.groupBox1.Controls.Add(this.txtPrecioNafta);
            this.groupBox1.Controls.Add(this.btnCrearCombustible);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(150, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbNombreCombustible
            // 
            this.cbNombreCombustible.FormattingEnabled = true;
            this.cbNombreCombustible.Items.AddRange(new object[] {
            "Normal",
            "Super",
            "Premium"});
            this.cbNombreCombustible.Location = new System.Drawing.Point(161, 50);
            this.cbNombreCombustible.Name = "cbNombreCombustible";
            this.cbNombreCombustible.Size = new System.Drawing.Size(121, 24);
            this.cbNombreCombustible.TabIndex = 5;
            // 
            // frmCrearCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearCombustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCombustible";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioNafta;
        private System.Windows.Forms.Button btnCrearCombustible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNombreCombustible;
    }
}