﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11Guia
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        Hospital Hospital = new Hospital();
        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltas Altas= new frmAltas(Hospital);
            this.Hide();
            Altas.Show();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
