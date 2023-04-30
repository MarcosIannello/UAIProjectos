using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2guiaEstacionServicio
{
    public partial class frmCargaSurtidor : Form
    {
        public frmCargaSurtidor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsSurtidor surtidor = new clsSurtidor();

            surtidor.NumSurtidor = int.Parse(txtNumSurtidor.Text);

        }

        private void frmCargaSurtidor_Load(object sender, EventArgs e)
        {
            clsNafta naftas = new clsNafta();

            if (naftas.ListaNaftas != null)
            {
                cbTipoNaftas.DataSource = naftas.ListaNaftas;
            }
        }
    }
}
