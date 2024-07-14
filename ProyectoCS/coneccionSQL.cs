using System.Data.SqlClient;

namespace ProyectoCS.Controlador
{
    public class ConeccionSQL
    {
        private SqlConnection cadena_conexion = new SqlConnection("Data Source=DESKTOP-E25E87I;Initial Catalog=CS6-3;Integrated Security=True");

        // abrir conexion a la base de datos
        public SqlConnection AbrirConexion()
        {
            if (cadena_conexion.State == System.Data.ConnectionState.Closed)
                cadena_conexion.Open();
            return cadena_conexion;
        }

        // cerrar la conexion a la base de datos
        public SqlConnection CerrarConexion()
        {
            if (cadena_conexion.State == System.Data.ConnectionState.Open)
                cadena_conexion.Close();
            return cadena_conexion;

        }
    }
}
