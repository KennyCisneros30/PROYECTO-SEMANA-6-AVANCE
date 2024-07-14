
namespace CapaNegocio.Entidades
{
    public class EVehiculo
    {
        // Atributos públicos para los datos de un vehículo.
        public int id, año, cilindraje, idPropieatario;
        public string placa, modelo, color, dni_Propieatrio, correo_propietario;
        public decimal valor;

        // Constructor por defecto que inicializa los atributos con valores predeterminados.
        public EVehiculo()
        {
            id = 0;
            placa = string.Empty;
            decimal valor = 0m;
            modelo = string.Empty;
            color = string.Empty;
            año = 0;
            cilindraje = 0;
            dni_Propieatrio = string.Empty;
            correo_propietario = string.Empty;
            idPropieatario = 0;
        }
        

        // Propiedades de solo lectura y escritura para acceder a los atributos.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
        public int Cilindraje
        {
            get { return cilindraje; }
            set { cilindraje = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Dni_Propieatrio
        {
            get { return dni_Propieatrio; }
            set { dni_Propieatrio = value; }
        }
        public string Correo_Propietario
        {
            get { return correo_propietario; }
            set { correo_propietario = value; }
        }
        public int IdPropieatrio
        {
            get { return idPropieatario; }
            set { idPropieatario = value; }
        }
    }
}
