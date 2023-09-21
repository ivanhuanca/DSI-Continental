using System.Data.SqlClient;
namespace Proyecto.Datos
{

    public class Conexion
    {

        private SqlConnection sqlConnection;
        private string BaseServidor;
        private string NombreBD;
        private string Usuario;
        private string Contrasena;
        private static Conexion conexion;
        private bool seguridad;

        public conexion()
        {
            this.BaseServidor = "localhost";
            this.NombreBD = "BD_MINI";
            this.Usuario = "sa";
            this.Contrasena = "";

            string conectionString = "Server= " + this.BaseServidor + "; Database = " + NombreBD + ";";
            
            if (seguridad)
            {
                conectionString = conectionString + "Integrated Security = SSPT;";
            }
            else
            {
                conectionString = conectionString + "User Id=" + this.Usuario + "; Password=" + this.Contrasena;
            }
            sqlConnection = new SqlConnection(conectionString);
        }
        public sqlConnection CrearConexion ()
        {
            try
            {
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
            }
            catch (Exception)
            {
                sqlConnection = null;
            }
            return sqlConnection;
        }
    }

}
