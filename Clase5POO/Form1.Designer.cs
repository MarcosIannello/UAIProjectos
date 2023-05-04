namespace Clase5POO
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
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.valor1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblResultadoSuma = new System.Windows.Forms.Label();
            this.lblResultadoresta = new System.Windows.Forms.Label();
            this.lblResultadoMultiplicar = new System.Windows.Forms.Label();
            this.lblResultadoDividir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(378, 141);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 0;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(378, 78);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(378, 209);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(100, 22);
            this.txtValor3.TabIndex = 0;
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(302, 84);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(49, 16);
            this.valor1.TabIndex = 1;
            this.valor1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor 3";
            // 
            // BtnRestar
            // 
            this.BtnRestar.Location = new System.Drawing.Point(264, 285);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(75, 23);
            this.BtnRestar.TabIndex = 2;
            this.BtnRestar.Text = "Restar";
            this.BtnRestar.UseVisualStyleBackColor = true;
            this.BtnRestar.Click += new System.EventHandler(this.BtnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(443, 285);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(656, 285);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(93, 285);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lblResultadoSuma
            // 
            this.lblResultadoSuma.AutoSize = true;
            this.lblResultadoSuma.Location = new System.Drawing.Point(77, 344);
            this.lblResultadoSuma.Name = "lblResultadoSuma";
            this.lblResultadoSuma.Size = new System.Drawing.Size(107, 16);
            this.lblResultadoSuma.TabIndex = 3;
            this.lblResultadoSuma.Text = "Resultado Suma";
            // 
            // lblResultadoresta
            // 
            this.lblResultadoresta.AutoSize = true;
            this.lblResultadoresta.Location = new System.Drawing.Point(246, 344);
            this.lblResultadoresta.Name = "lblResultadoresta";
            this.lblResultadoresta.Size = new System.Drawing.Size(108, 16);
            this.lblResultadoresta.TabIndex = 3;
            this.lblResultadoresta.Text = "Resultado Resta";
            // 
            // lblResultadoMultiplicar
            // 
            this.lblResultadoMultiplicar.AutoSize = true;
            this.lblResultadoMultiplicar.Location = new System.Drawing.Point(425, 344);
            this.lblResultadoMultiplicar.Name = "lblResultadoMultiplicar";
            this.lblResultadoMultiplicar.Size = new System.Drawing.Size(132, 16);
            this.lblResultadoMultiplicar.TabIndex = 3;
            this.lblResultadoMultiplicar.Text = "Resultado Multiplicar";
            // 
            // lblResultadoDividir
            // 
            this.lblResultadoDividir.AutoSize = true;
            this.lblResultadoDividir.Location = new System.Drawing.Point(641, 344);
            this.lblResultadoDividir.Name = "lblResultadoDividir";
            this.lblResultadoDividir.Size = new System.Drawing.Size(108, 16);
            this.lblResultadoDividir.TabIndex = 3;
            this.lblResultadoDividir.Text = "Resultado dividir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "EJERCICIO POLIMORFISMO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoDividir);
            this.Controls.Add(this.lblResultadoMultiplicar);
            this.Controls.Add(this.lblResultadoresta);
            this.Controls.Add(this.lblResultadoSuma);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lblResultadoSuma;
        private System.Windows.Forms.Label lblResultadoresta;
        private System.Windows.Forms.Label lblResultadoMultiplicar;
        private System.Windows.Forms.Label lblResultadoDividir;
        private System.Windows.Forms.Label label1;
    }
}

