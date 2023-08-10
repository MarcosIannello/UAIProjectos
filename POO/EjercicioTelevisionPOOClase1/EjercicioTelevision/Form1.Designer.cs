namespace EjercicioTelevision
{
    partial class frmTelevision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelevision));
            this.pbOceanBackground = new System.Windows.Forms.PictureBox();
            this.btnPower = new System.Windows.Forms.Button();
            this.pnlControlRemoto = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolumenDown = new System.Windows.Forms.Button();
            this.btnVolumenUp = new System.Windows.Forms.Button();
            this.gbCanales = new System.Windows.Forms.GroupBox();
            this.btnCanalDown = new System.Windows.Forms.Button();
            this.btnCanalUP = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNetflix = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnAmazon = new System.Windows.Forms.Button();
            this.panelApps = new System.Windows.Forms.Panel();
            this.volumeBar = new System.Windows.Forms.ProgressBar();
            this.lblValorVolumen = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnCloseBrowser = new System.Windows.Forms.Button();
            this.lblCanal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOceanBackground)).BeginInit();
            this.pnlControlRemoto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCanales.SuspendLayout();
            this.panelApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbOceanBackground
            // 
            this.pbOceanBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOceanBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbOceanBackground.Image")));
            this.pbOceanBackground.Location = new System.Drawing.Point(0, 0);
            this.pbOceanBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbOceanBackground.Name = "pbOceanBackground";
            this.pbOceanBackground.Size = new System.Drawing.Size(933, 485);
            this.pbOceanBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOceanBackground.TabIndex = 1;
            this.pbOceanBackground.TabStop = false;
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.Transparent;
            this.btnPower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPower.BackgroundImage")));
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPower.Location = new System.Drawing.Point(4, 15);
            this.btnPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(41, 32);
            this.btnPower.TabIndex = 0;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // pnlControlRemoto
            // 
            this.pnlControlRemoto.BackColor = System.Drawing.Color.Gray;
            this.pnlControlRemoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControlRemoto.Controls.Add(this.groupBox2);
            this.pnlControlRemoto.Controls.Add(this.gbCanales);
            this.pnlControlRemoto.Controls.Add(this.btnHome);
            this.pnlControlRemoto.Controls.Add(this.btnPower);
            this.pnlControlRemoto.Location = new System.Drawing.Point(794, 13);
            this.pnlControlRemoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlControlRemoto.Name = "pnlControlRemoto";
            this.pnlControlRemoto.Size = new System.Drawing.Size(124, 458);
            this.pnlControlRemoto.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVolumenDown);
            this.groupBox2.Controls.Add(this.btnVolumenUp);
            this.groupBox2.Location = new System.Drawing.Point(4, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volumen";
            // 
            // btnVolumenDown
            // 
            this.btnVolumenDown.Location = new System.Drawing.Point(33, 62);
            this.btnVolumenDown.Name = "btnVolumenDown";
            this.btnVolumenDown.Size = new System.Drawing.Size(43, 23);
            this.btnVolumenDown.TabIndex = 1;
            this.btnVolumenDown.Text = "-";
            this.btnVolumenDown.UseVisualStyleBackColor = true;
            this.btnVolumenDown.Click += new System.EventHandler(this.btnVolumenDown_Click);
            // 
            // btnVolumenUp
            // 
            this.btnVolumenUp.Location = new System.Drawing.Point(32, 20);
            this.btnVolumenUp.Name = "btnVolumenUp";
            this.btnVolumenUp.Size = new System.Drawing.Size(44, 23);
            this.btnVolumenUp.TabIndex = 0;
            this.btnVolumenUp.Text = "+";
            this.btnVolumenUp.UseVisualStyleBackColor = true;
            this.btnVolumenUp.Click += new System.EventHandler(this.btnVolumenUp_Click);
            // 
            // gbCanales
            // 
            this.gbCanales.Controls.Add(this.btnCanalDown);
            this.gbCanales.Controls.Add(this.btnCanalUP);
            this.gbCanales.Location = new System.Drawing.Point(4, 62);
            this.gbCanales.Name = "gbCanales";
            this.gbCanales.Size = new System.Drawing.Size(113, 100);
            this.gbCanales.TabIndex = 1;
            this.gbCanales.TabStop = false;
            this.gbCanales.Text = "Canales";
            // 
            // btnCanalDown
            // 
            this.btnCanalDown.Location = new System.Drawing.Point(32, 71);
            this.btnCanalDown.Name = "btnCanalDown";
            this.btnCanalDown.Size = new System.Drawing.Size(44, 23);
            this.btnCanalDown.TabIndex = 4;
            this.btnCanalDown.Text = "-";
            this.btnCanalDown.UseVisualStyleBackColor = true;
            this.btnCanalDown.Click += new System.EventHandler(this.btnCanalDown_Click);
            // 
            // btnCanalUP
            // 
            this.btnCanalUP.Location = new System.Drawing.Point(33, 20);
            this.btnCanalUP.Name = "btnCanalUP";
            this.btnCanalUP.Size = new System.Drawing.Size(43, 23);
            this.btnCanalUP.TabIndex = 3;
            this.btnCanalUP.Text = "+";
            this.btnCanalUP.UseVisualStyleBackColor = true;
            this.btnCanalUP.Click += new System.EventHandler(this.btnCanalUP_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(37, 180);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNetflix
            // 
            this.btnNetflix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNetflix.BackgroundImage")));
            this.btnNetflix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNetflix.Location = new System.Drawing.Point(158, 0);
            this.btnNetflix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNetflix.Name = "btnNetflix";
            this.btnNetflix.Size = new System.Drawing.Size(106, 127);
            this.btnNetflix.TabIndex = 4;
            this.btnNetflix.UseVisualStyleBackColor = true;
            this.btnNetflix.Click += new System.EventHandler(this.btnNetflix_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoogle.BackgroundImage")));
            this.btnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoogle.ForeColor = System.Drawing.Color.Cyan;
            this.btnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoogle.Location = new System.Drawing.Point(271, 0);
            this.btnGoogle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(113, 127);
            this.btnGoogle.TabIndex = 4;
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnAmazon
            // 
            this.btnAmazon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAmazon.BackgroundImage")));
            this.btnAmazon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmazon.Location = new System.Drawing.Point(391, 0);
            this.btnAmazon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAmazon.Name = "btnAmazon";
            this.btnAmazon.Size = new System.Drawing.Size(118, 127);
            this.btnAmazon.TabIndex = 4;
            this.btnAmazon.UseVisualStyleBackColor = true;
            this.btnAmazon.Click += new System.EventHandler(this.btnAmazon_Click);
            // 
            // panelApps
            // 
            this.panelApps.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelApps.Controls.Add(this.btnNetflix);
            this.panelApps.Controls.Add(this.btnGoogle);
            this.panelApps.Controls.Add(this.btnAmazon);
            this.panelApps.Location = new System.Drawing.Point(0, 358);
            this.panelApps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelApps.Name = "panelApps";
            this.panelApps.Size = new System.Drawing.Size(666, 127);
            this.panelApps.TabIndex = 5;
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(0, 0);
            this.volumeBar.Maximum = 50;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(196, 10);
            this.volumeBar.TabIndex = 5;
            // 
            // lblValorVolumen
            // 
            this.lblValorVolumen.AutoSize = true;
            this.lblValorVolumen.BackColor = System.Drawing.Color.Transparent;
            this.lblValorVolumen.ForeColor = System.Drawing.Color.Lime;
            this.lblValorVolumen.Location = new System.Drawing.Point(86, 13);
            this.lblValorVolumen.Name = "lblValorVolumen";
            this.lblValorVolumen.Size = new System.Drawing.Size(0, 14);
            this.lblValorVolumen.TabIndex = 6;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(3, 16);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(784, 466);
            this.webBrowser.TabIndex = 7;
            // 
            // btnCloseBrowser
            // 
            this.btnCloseBrowser.ForeColor = System.Drawing.Color.Red;
            this.btnCloseBrowser.Location = new System.Drawing.Point(12, 35);
            this.btnCloseBrowser.Name = "btnCloseBrowser";
            this.btnCloseBrowser.Size = new System.Drawing.Size(26, 23);
            this.btnCloseBrowser.TabIndex = 8;
            this.btnCloseBrowser.Text = "x";
            this.btnCloseBrowser.UseVisualStyleBackColor = true;
            this.btnCloseBrowser.Click += new System.EventHandler(this.btnCloseBrowser_Click);
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.BackColor = System.Drawing.Color.Transparent;
            this.lblCanal.ForeColor = System.Drawing.Color.Lime;
            this.lblCanal.Location = new System.Drawing.Point(587, 48);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(0, 14);
            this.lblCanal.TabIndex = 9;
            // 
            // frmTelevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.btnCloseBrowser);
            this.Controls.Add(this.lblValorVolumen);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.pnlControlRemoto);
            this.Controls.Add(this.panelApps);
            this.Controls.Add(this.pbOceanBackground);
            this.Controls.Add(this.webBrowser);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTelevision";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Tv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOceanBackground)).EndInit();
            this.pnlControlRemoto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbCanales.ResumeLayout(false);
            this.panelApps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.PictureBox pbOceanBackground;
        private System.Windows.Forms.Panel pnlControlRemoto;
        private System.Windows.Forms.Button btnNetflix;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnAmazon;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelApps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVolumenDown;
        private System.Windows.Forms.Button btnVolumenUp;
        private System.Windows.Forms.GroupBox gbCanales;
        private System.Windows.Forms.Button btnCanalDown;
        private System.Windows.Forms.Button btnCanalUP;
        private System.Windows.Forms.ProgressBar volumeBar;
        private System.Windows.Forms.Label lblValorVolumen;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnCloseBrowser;
        private System.Windows.Forms.Label lblCanal;
    }
}

