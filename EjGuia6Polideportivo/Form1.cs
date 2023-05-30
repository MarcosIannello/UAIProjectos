using BibliotecaClasesPolideportivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjGuia6Polideportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Polideportivo polideportivo = new Polideportivo();
        int contadorCanchas;
        int contadorJueces;
        bool listadoJueces=false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaCancha_Click(object sender, EventArgs e)
        {
            contadorCanchas++;
            switch (cbTipoNuevaCancha.Text)
            {
                case "Tenis":
                    Cancha canchaT = new Cancha();
                    canchaT.Nombre = cbTipoNuevaCancha.Text;
                    canchaT.NumCancha = contadorCanchas;
                    canchaT.ValorXHora = 200;
                    canchaT.CantidadVecesAlquiladas = 0;
                    canchaT.Ocupada = false;
                    polideportivo.TotalCanchas.Add(canchaT);
                    break;

                case "Futbol5":
                    Cancha canchaF5 = new Cancha();
                    canchaF5.Nombre = cbTipoNuevaCancha.Text;
                    canchaF5.NumCancha += contadorCanchas;
                    canchaF5.ValorXHora = 500;
                    canchaF5.CantidadVecesAlquiladas = 0;
                    canchaF5.Ocupada = false;
                    polideportivo.TotalCanchas.Add(canchaF5);
                    break;

                case "Futbol7":
                    Cancha canchaF7 = new Cancha();
                    canchaF7.Nombre = cbTipoNuevaCancha.Text;
                    canchaF7.NumCancha = contadorCanchas;
                    canchaF7.ValorXHora = 650;
                    canchaF7.CantidadVecesAlquiladas = 0;
                    canchaF7.Ocupada = false;
                    polideportivo.TotalCanchas.Add(canchaF7);
                    break;

                case "Futbol11":
                    Cancha canchaF11 = new Cancha();
                    canchaF11.Nombre = cbTipoNuevaCancha.Text;
                    canchaF11.NumCancha = contadorCanchas;
                    canchaF11.ValorXHora = 800;
                    canchaF11.CantidadVecesAlquiladas = 0;
                    canchaF11.Ocupada = false;
                    polideportivo.TotalCanchas.Add(canchaF11);
                    break;
            }
            cargarGridView();
        }
        public void cargarGridView()
        {
            gvCanchas.DataSource = null;
            gvCanchas.DataSource = polideportivo.TotalCanchas;
        }

        private void btnAltaJuez_Click(object sender, EventArgs e)
        {
            contadorJueces++;
            Juez juez = new Juez();

            juez.NombreCompleto = txtNombreJuez.Text;
            juez.Legajo = contadorJueces;
            juez.PartidosDirigidos = 0;
            juez.Recaudado = 0;
            polideportivo.Jueces.Add(juez);
            cargarGridJuez();
        }

        public void cargarGridJuez()
        {
            gridJuez.DataSource = null;
            gridJuez.DataSource = polideportivo.Jueces;
        }

        private void checkJueces_CheckedChanged(object sender, EventArgs e)
        {
            if (listadoJueces == false)
            {
                chkListJueces.Visible = true;
                listadoJueces = true;
                cargarJueces();
            }
            else
            {
                chkListJueces.Visible = false;
                listadoJueces = false;
            }
            
        }

        Cancha temp;

        private void gvCanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (Cancha)gvCanchas.Rows[e.RowIndex].DataBoundItem;
            txtNombreCancha.Text = temp.Nombre;
            txtNroCancha.Text = temp.NumCancha.ToString();
        }

        public void cargarJueces()
        {
            chkListJueces.DataSource = null;
            chkListJueces.DataSource = polideportivo.Jueces;
            chkListJueces.DisplayMember = "NombreCompleto";
            filtrarJueces();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            string canchaXAlquilar = txtNombreCancha.Text;
            int numCanchaXAlquilar = int.Parse(txtNroCancha.Text);

            foreach(Cancha cancha in polideportivo.TotalCanchas)
            {
                if(cancha.NumCancha == numCanchaXAlquilar && cancha.Nombre == canchaXAlquilar)
                {
                    cancha.CantidadVecesAlquiladas++;
                    cancha.Ocupada = true;
                    polideportivo.RecaudacionTotal += cancha.ValorXHora * int.Parse(txtHoras.Text);
                    cargarGridView();
                }
            }

            txtRecaudacionTotal.Text = polideportivo.RecaudacionTotal.ToString();
        }

        //lo deje aca para filtrar jueces en nueva lista y mostrar solo los disponibles cuando se alquila una cancha

        List<Juez> juecesDisponibles;
        public void filtrarJueces()
        {
           foreach(Juez juez in polideportivo.Jueces)
           {
                if(juez.Ocupado == true)
                {
                    juecesDisponibles.Add(juez);
                }
           }
        }
    }
}
