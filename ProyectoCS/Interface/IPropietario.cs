using System.Data;

namespace CapaDatos.Interface
{
    public class IPropietario
    {
        private ManageSQL obj = new ManageSQL();

        // Método para insertar un propietario en la base de datos.
        public bool InsertarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            var listaParametros = new List<Parametros> // Lista de parámetros necesarios para la operación.
            { 
                // Creación de objetos Parametros con valores específicos.
                new() { Nombre = "dni", Tipo = SqlDbType.VarChar, Valor = dni },
                new() { Nombre = "nombres", Tipo = SqlDbType.VarChar, Valor = nombres },
                new() { Nombre = "apellidos", Tipo = SqlDbType.VarChar, Valor = apellidos },
                new() { Nombre = "correo", Tipo = SqlDbType.VarChar, Valor = correo },
                new() { Nombre = "telefono", Tipo = SqlDbType.VarChar, Valor = telefono },
                new() { Nombre = "direccion", Tipo = SqlDbType.VarChar, Valor = direccion }
            };

            return obj.ejecutaSP_NonQuery("InsertarPropietario", listaParametros);
        }

        // Método para modificar un propietario en la base de datos.
        public bool ModificarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            var listaParametros = new List<Parametros>
            {
                new() { Nombre = "dni", Tipo = SqlDbType.VarChar, Valor = dni },
                new() { Nombre = "nombres", Tipo = SqlDbType.VarChar, Valor = nombres },
                new() { Nombre = "apellidos", Tipo = SqlDbType.VarChar, Valor = apellidos },
                new() { Nombre = "correo", Tipo = SqlDbType.VarChar, Valor = correo },
                new() { Nombre = "telefono", Tipo = SqlDbType.VarChar, Valor = telefono },
                new() { Nombre = "direccion", Tipo = SqlDbType.VarChar, Valor = direccion }
            };
            return obj.ejecutaSP_NonQuery("ModificarPropietario", listaParametros);
        }

        // Método para eliminar un propietario de la base de datos.
        public bool EliminarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            var listaParametros = new List<Parametros>
            {
                new() { Nombre = "dni", Tipo = SqlDbType.VarChar, Valor = dni },
            };

            return obj.ejecutaSP_NonQuery("EliminarPropietario", listaParametros);
        }

        // Método para buscar un propietario por su DNI en la base de datos.
        public DataTable BuscarPropietarioPorDNI(string dni)
        {
            var listaParametros = new List<Parametros>
            {
                new() { Nombre = "dni", Tipo = SqlDbType.VarChar, Valor = dni }
            };

            return obj.ejecutaSP_Query("BuscarPropietarioPorDNI", listaParametros);
        }

    }
}
