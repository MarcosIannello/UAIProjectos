using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoLugComics
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cn;

        public void Conectar()
        {
            cn = new SqlConnection();

            cn.ConnectionString = "Data Source=.;Initial Catalog=FACULTAD;Integrated Security=True";

            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            Conectar();

            bool resultado;

            SqlCommand cmd = new SqlCommand("VALIDAR_USUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOMBRE_USUARIO", nombreUsuario.ToUpper());
            cmd.Parameters.AddWithValue("@PASSWORD", contraseña);

            SqlParameter ResultadoParam = new SqlParameter("@RESULTADO", SqlDbType.Bit);

            ResultadoParam.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(ResultadoParam);

            cmd.ExecuteNonQuery();

            resultado = Convert.ToBoolean(ResultadoParam.Value);

            Desconectar();

            return resultado;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var userName = txtUsername.Text;
            var password = txtPassword.Text;   
            var resultado = ValidarUsuario(userName, password);
            if (resultado)
            {
                MessageBox.Show($"Bienvenido al sistema {userName}");
                frmHome Home = new frmHome();
                Home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalidas!");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse frmRegistrarse = new frmRegistrarse();
            frmRegistrarse.Show();
            this.Hide();
        }
    }
}
