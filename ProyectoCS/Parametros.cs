using System.Data;

namespace CapaDatos
{
    public class Parametros
    {

        public string? Nombre { get; set; }
        public SqlDbType Tipo { get; set; }
        public object? Valor { get; set; }

    }
}
