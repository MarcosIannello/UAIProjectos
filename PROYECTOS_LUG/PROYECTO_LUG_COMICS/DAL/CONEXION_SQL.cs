using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionSQL
    {
        public string _conexion;

        public ConexionSQL()
        {
            this._conexion = "Data Source=.;Initial Catalog=FACULTAD;Integrated Security=True";
        }

        public SqlConnection Open()
        {
            SqlConnection conexion = new SqlConnection(_conexion);

            conexion.Open();

            return conexion;

        }

        public void Close(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
