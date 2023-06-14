using ClasesParcial1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1Resuelto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();
        private void btnAltaEmp_Click(object sender, EventArgs e)
        {
            switch (cmbTipoEmp.Text)
            {
                case "Auxiliar":
                    auxiliar aux = new auxiliar();
                    aux.NombreCompleto = txtNombreEmp.Text;
                    aux.TipoEmp = cmbTipoEmp.Text;
                    empresa.Auxiliares.Add(aux);
                    break;
                case "Modelo":
                    Modelo mod = new Modelo();
                    mod.NombreCompleto = txtNombreEmp.Text;
                    mod.TipoEmp = cmbTipoEmp.Text;
                    empresa.Modelos.Add(mod);
                    break;
                case "Presentador":
                    Presentador presentador = new Presentador();
                    presentador.NombreCompleto = txtNombreEmp.Text;
                    presentador.TipoEmp = cmbTipoEmp.Text;
                    empresa.Presentadores.Add(presentador);
                    break;
                case "Publicitario":
                    Publicitario publicitario = new Publicitario();
                    publicitario.NombreCompleto= txtNombreEmp.Text;
                    publicitario.TipoEmp = cmbTipoEmp.Text;
                    empresa.Publicitarios.Add(publicitario);
                    break;
            }

            cargarGrids();
        }

        public void cargarGrids()
        {
            gridAuxiliares.DataSource = null;
            gridModelos.DataSource = null;
            gridPresentador.DataSource = null;
            gridPublicitarios.DataSource = null;

            gridAuxiliares.DataSource = empresa.Auxiliares;
            gridModelos.DataSource = empresa.Modelos;
            gridPresentador.DataSource = empresa.Presentadores;
            gridPublicitarios.DataSource = empresa.Publicitarios;
        }

        private void btnCargaEvento_Click(object sender, EventArgs e)
        {

        }

        private void gridAuxiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
