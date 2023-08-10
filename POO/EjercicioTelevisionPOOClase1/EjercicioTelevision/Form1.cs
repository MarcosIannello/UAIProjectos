using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTelevision
{
    public partial class frmTelevision : Form
    {
        public frmTelevision()
        {
            InitializeComponent();
        }

        bool encendida = false;
        bool appsDisplay = false;
        int volumen = 0;
        bool tv = false;
        int canal = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            esconderComponentes();
            
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if(encendida == false)
            {
                encendida = true;
                mostrarComponentes();

            }
            else
            {
                MessageBox.Show("Apagando Televisor");
                encendida = false;
                esconderComponentes();
            }
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (encendida == true && appsDisplay == false)
            {
                panelApps.Visible=true;
                appsDisplay = true;
                
            } else if (encendida == true && appsDisplay == true)
            {
                panelApps.Visible = false;
                appsDisplay=false;
            } else
            {
                MessageBox.Show("La Televisión está apagada");
            }
        }

        private void btnCanalUP_Click(object sender, EventArgs e)
        {
            if (encendida == true && canal >= 0)
            {
                canal+=50;
                lblCanal.Text = $"Canal {canal}";
                lblCanal.Show();
            }else if (encendida == true && canal == 100)
            {
                canal = 0;
                lblCanal.Text = $"Canal {canal}";
                lblCanal.Show();
            }
            else
            {
                MessageBox.Show("Encienda el televisor porfavor");
            }
        }

        private void btnVolumenUp_Click(object sender, EventArgs e)
        {
            if (encendida == true && volumen <50)
            {
                volumen++;
                volumeBar.Value = volumen;
                volumeBar.Show();
                lblValorVolumen.Show();
                lblValorVolumen.Text = volumen.ToString();

            }else if(encendida == true && volumen == 50)
            {
                MessageBox.Show("Volumen maximo alcanzado");
                volumen = 50;
                volumeBar.Value = volumen;
                volumeBar.Show();

                lblValorVolumen.Show();
                lblValorVolumen.Text=volumen.ToString();
            }else
            {
                MessageBox.Show("Por favor encienda el televisor");
            }
        }

        private void btnVolumenDown_Click(object sender, EventArgs e)
        {
            if (encendida == true && volumen > 0)
            {
                volumen--;
                volumeBar.Value = volumen;
                volumeBar.Show();
                lblValorVolumen.Show();
                lblValorVolumen.Text = volumen.ToString();
            }
            else if(encendida == true && volumen == 0)
            {
                volumen = 0;
                MessageBox.Show("No puede bajar mas el volumen");
            }else
            {
                MessageBox.Show("Encienda el televisor porfavor!");
            }

            
        }

        private void btnNetflix_Click(object sender, EventArgs e)
        {
            webBrowser.Show();
            webBrowser.BringToFront();
            btnCloseBrowser.Show();
            btnCloseBrowser.BringToFront();
            webBrowser.Navigate("https://www.netflix.com/browse");
        }

        private void btnCloseBrowser_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
            webBrowser.Hide();
            btnCloseBrowser.Hide();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            webBrowser.Show();
            webBrowser.BringToFront();
            btnCloseBrowser.Show();
            btnCloseBrowser.BringToFront();
            webBrowser.Navigate("https://www.google.com.ar/");
        }

        private void btnAmazon_Click(object sender, EventArgs e)
        {
            webBrowser.Show();
            webBrowser.BringToFront();
            btnCloseBrowser.Show();
            btnCloseBrowser.BringToFront();
            
            
            webBrowser.Navigate("https://play.hbomax.com/");
        }

        private void esconderComponentes()
        {
            pbOceanBackground.Hide();
            panelApps.Hide();
            volumeBar.Hide();
            lblValorVolumen.Hide();
            webBrowser.Hide();
            btnCloseBrowser.Hide();
            lblCanal.Hide();
            btnCanalDown.Hide();
            btnCanalUP.Hide();
            btnVolumenDown.Hide();
            btnVolumenUp.Hide();
            btnHome.Hide();
        }

        public void mostrarComponentes()
        {
            btnCanalDown.Show();
            btnCanalUP.Show();
            btnVolumenDown.Show();
            btnVolumenUp.Show();
            btnHome.Show();
            pbOceanBackground.Visible = true;
        }

        private void btnCanalDown_Click(object sender, EventArgs e)
        {
            if (encendida == true && canal > 0)
            {
                canal--;
                lblCanal.Text = $"Canal {canal}";
                lblCanal.Show();
            }else if (encendida == true && canal == 0)
            {
                MessageBox.Show("El canal que intenta acceder no existe");
            }
        }
    }
}
