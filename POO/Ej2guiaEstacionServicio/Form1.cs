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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearCombustible frm = new frmCrearCombustible();

            //frm.MdiParent = this;

            frm.Show();

            this.Hide();
        }

        private void cargaSurtidorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRedirectCrearSurtidor_Click(object sender, EventArgs e)
        {
            frmCargaSurtidor frm = new frmCargaSurtidor();
            frm.Show();
            this.Hide();

        }
    }
}
