using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket.Datos
{
    public class Conexion 
    {
        private SqlConnection connection;
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null; //referencia la propio entorno

        public Conexion()
        {
            this.Base = "Minimarket";
            this.Servidor = "localhost";
            this.Usuario = "sa";
            this.Clave = "123";
            this.Seguridad = false;

            string connectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
            if (Seguridad)
            {
                connectionString = connectionString + "Integrated Security = SSPI";
            }
            else
            {
                connectionString = connectionString + "User Id=" + this.Usuario + "; Password= " + this.Clave;
            }

            connection = new SqlConnection(connectionString);

        }
        public SqlConnection CrearConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();

                }
                 
            }
            catch (Exception ex)
            {

                connection = null;
            }
            return connection;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
