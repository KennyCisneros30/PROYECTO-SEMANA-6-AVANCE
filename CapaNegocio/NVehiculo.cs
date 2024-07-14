using System.Data;
using CapaDatos.Interface;
using CapaDatos;
using CapaNegocio.Entidades;
using CapaNegocio.Servicios.CorreoServicios.ConstruccionCorreos;

namespace CapaNegocio
{
    public class NVehiculo
    {
        // Instancias de clases para interactuar con la capa de datos.
        private IVehiculo obj_Vehiculo_datos = new IVehiculo(); // Instancia de IVehiculo para interactuar con la entidad Vehiculo en la capa de datos.
        private CVehiculo EnvioCorreos = new CVehiculo();

        // Método para crear un nuevo vehículo.
        public bool CrearVehiculo(EVehiculo vehiculo, EPropietario propietario)
        {
            try
            {
                // Verificar si el correo está vacío antes de intentar insertar el vehículo
                if (string.IsNullOrWhiteSpace(vehiculo.correo_propietario))
                {
                    throw new ArgumentException("El correo del propietario no puede estar vacío.");
                }

                // Llama al método de la capa de datos para insertar un nuevo vehículo
                bool resultado = obj_Vehiculo_datos.InsertarVehiculo(vehiculo.placa, vehiculo.valor, vehiculo.año, vehiculo.cilindraje, vehiculo.modelo, vehiculo.color, vehiculo.dni_Propieatrio, vehiculo.correo_propietario);

                if (resultado)
                {
                    // Verificar nuevamente si el correo está vacío antes de enviar el correo
                    if (!string.IsNullOrWhiteSpace(propietario.correo))
                    {
                        EnvioCorreos.EnviarRegistroVehiculo(propietario.correo, propietario.nombres, propietario.apellidos, vehiculo.placa, vehiculo.modelo, vehiculo.color, vehiculo.año, vehiculo.cilindraje, vehiculo.valor);
                    }
                    else
                    {
                        // Loguear una advertencia o manejar el caso de correo vacío según sea necesario
                        Console.WriteLine("Advertencia: No se pudo enviar el correo porque la dirección está vacía.");
                    }
                }

                return resultado;
            }
            catch (Exception e)
            {
                throw new Exception("Error al Crear Registro del Vehículo: " + e.Message);
            }
        }

        // Método para actualizar los datos de un vehículo existente.
        public bool ActualizarVehiculo(EVehiculo vehiculo, EPropietario propietario)
        {
            try
            {

                // Llama al método de la capa de datos para modificar los datos de un vehículo.
                bool resultado = obj_Vehiculo_datos.ModificarVehiculo(vehiculo.placa, vehiculo.valor, vehiculo.año, vehiculo.cilindraje, vehiculo.modelo, vehiculo.color, Convert.ToInt32(vehiculo.dni_Propieatrio));

                if (resultado)
                {
                    EnvioCorreos.EnviarModificacionVehiculo(propietario.correo, propietario.nombres, propietario.apellidos, vehiculo.placa, vehiculo.modelo, vehiculo.color, vehiculo.año, vehiculo.cilindraje, vehiculo.valor);
                }

                return resultado;

            }
            catch (Exception e)
            {
                throw new Exception("Error al Actualizar Registro de Vehiculos" + e.Message);
            }

        }

        // Método para eliminar un vehículo existente.
        public bool Eliminar_Vehiculo(EVehiculo vehiculo, EPropietario propietario)
        {
            try
            {

                // Llama al método de la capa de datos para eliminar un vehículo por su placa.
                bool resultado = obj_Vehiculo_datos.EliminarVehiculo(vehiculo.placa);

                if (resultado)
                {
                    EnvioCorreos.EnviarEliminacionVehiculo(propietario.correo, propietario.nombres, propietario.apellidos, vehiculo.placa, vehiculo.modelo, vehiculo.color, vehiculo.año, vehiculo.cilindraje, vehiculo.valor);
                }

                return resultado;

            }
            catch (Exception e)
            {
                throw new Exception("Error al Eliminar Vehiculo" + e.Message);
            }

        }

        // Método para buscar un vehículo por su placa.
        public DataTable Buscar_Placa(EVehiculo vehiculo)
        {
            try
            {
                // Llama al método de la capa de datos para buscar un vehículo por su placa y devuelve un DataTable con los resultados.
                return obj_Vehiculo_datos.BuscarVehiculoPorPlaca(vehiculo.placa);

            }
            catch (Exception e)
            {
                throw new Exception("Error al Buscar Vehiculo" + e.Message);
            }

        }

        // Método para verificar la existencia de un propietario por su DNI.
        public DataTable Verificar_DNIyCorreoExistente(EVehiculo vehiculo)
        {
            try
            {
                // Llama al método de la capa de datos para verificar la existencia de un propietario por su DNI y correo, y devuelve un DataTable con los resultados.
                return obj_Vehiculo_datos.VerificarDNIyCorreoExistente(vehiculo.Dni_Propieatrio, vehiculo.Correo_Propietario);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al buscar propietario: {e.Message}");
            }
        }


        // Método para obtener el ID de un propietario por su DNI.
        public int ObtenerID(string dni)
        {
            var propietario = new NPropietario(); // Instancia de la clase NPropietario para interactuar con la capa de negocios de propietarios.
            var resultado = propietario.Buscar_DNI(new EPropietario { Dni = dni });

            // Verifica si se encontró un propietario con el DNI especificado.
            if (resultado.Rows.Count > 0)
            {
                return Convert.ToInt32(resultado.Rows[0]["ID"]); // Devuelve el ID del propietario encontrado.
            }
            else
            {
                throw new Exception("Propietario no encontrado");
            }
        }

    }
}
