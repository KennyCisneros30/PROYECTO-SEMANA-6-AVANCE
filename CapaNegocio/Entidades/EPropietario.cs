
namespace CapaNegocio.Entidades
{
    public class EPropietario
    {
        // Propiedades públicas para los atributos de un propietario.
        public int id;
        public string dni, nombres, apellidos, correo, telefono, direccion;

        // Constructor por defecto que inicializa los atributos con valores predeterminados.
        public EPropietario()
        {
            id = 0;
            dni = string.Empty;
            nombres = string.Empty;
            apellidos = string.Empty;
            correo = string.Empty;
            telefono = string.Empty;
            direccion = string.Empty;
        }


        // Propiedades de solo lectura y escritura para acceder a los atributos.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
