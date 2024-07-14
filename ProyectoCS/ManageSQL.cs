using System.Data;
using System.Data.SqlClient;
using ProyectoCS.Controlador;

namespace CapaDatos
{
    public class ManageSQL
    {
        private ConeccionSQL conn = new ConeccionSQL(); // Instancia de la clase ConeccionSQL para manejar la conexión a la base de datos.

        
        // Método para ejecutar sentencias SQL de tipo insert, update, delete (para uso proximo).
        public bool EjecutarSQL(string sql)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else return false;

        }

        // Método para ejecutar una sentencia SQL de tipo select y devuelve un DataTable (para uso proximo).
        public DataTable EjecutarSelect(string sql)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        // Método para ejecutar un procedimiento almacenado de tipo select y devuelve un DataTable (para uso proximo).
        public DataTable EjecutarSPselect(string nombre_sp)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }


        // Método para ejecutar un procedimiento almacenado de tipo select con parámetros y devuelve un DataTable.
        public DataTable ejecutaSP_Query(string nombre_sp, List<Parametros> lista)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            foreach (var parametro in lista)
            {
                command.Parameters.Add(parametro.Nombre, parametro.Tipo).Value = parametro.Valor;
            }
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        // Método para ejecutar un procedimiento almacenado de tipo insert, update o delete con parámetros.
        public bool ejecutaSP_NonQuery(string nombre_sp, List<Parametros> lista)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombre_sp;
            foreach (var parametro in lista)
            {
                command.Parameters.Add(parametro.Nombre, parametro.Tipo).Value = parametro.Valor;
            }
            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else return false;
        }

    }
}
