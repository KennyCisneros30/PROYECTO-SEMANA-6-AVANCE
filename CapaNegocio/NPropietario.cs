using CapaDatos.Interface;
using System.Data;
using CapaNegocio.Entidades;
using CapaNegocio.Servicios.CorreoServicios.ConstruccionCorreos;

namespace CapaNegocio
{
    public class NPropietario
    {
        // Instancias de clases para interactuar con la capa de datos.
        private IPropietario obj_Propietario_datos = new IPropietario(); // Instancia de IPropietario para interactuar con la entidad Propietario en la capa de datos.
        private CPropietario EnvioCorreos = new CPropietario();

        // Método para crear un nuevo propietario.
        public bool CrearPropietario(EPropietario propietario)
        {
            try
            {
                // Llama al método de la capa de datos para insertar un nuevo propietario.
                bool resultado = obj_Propietario_datos.InsertarPropietario(propietario.Dni, propietario.Nombres, propietario.Apellidos, propietario.Correo, propietario.Telefono, propietario.Direccion);
                
                if (resultado)
                {
                    EnvioCorreos.EnviarRegistroPropietario(propietario.Correo, propietario.Nombres, propietario.Apellidos, propietario.Dni, propietario.Telefono, propietario.Direccion);
                }

                return resultado;

            }
            catch (Exception e)
            {
                throw new Exception("Error al Crear Registro de Propietario" + e.Message);
            }

        }

        // Método para actualizar los datos de un propietario existente.
        public bool ActualizarPropietario(EPropietario propietario)
        {
            try
            {
                // Llama al método de la capa de datos para modificar los datos de un propietario.
                bool resultado = obj_Propietario_datos.ModificarPropietario(propietario.Dni, propietario.Nombres, propietario.Apellidos, propietario.Correo, propietario.Telefono, propietario.Direccion);
                
                if (resultado)
                {
                    EnvioCorreos.EnviarModificacionPropietario(propietario.Correo, propietario.Nombres, propietario.Apellidos, propietario.Dni, propietario.Telefono, propietario.Direccion);
                }

                return resultado;

            }
            catch (Exception e)
            {
                throw new Exception("Error al Actualizar Registro de Propietario" + e.Message);
            }

        }

        // Método para eliminar un propietario existente.
        public bool Eliminar_Propietario(EPropietario propietario)
        {
            try
            {
                // Llama al método de la capa de datos para eliminar un propietario por su DNI.
                bool resultado = obj_Propietario_datos.EliminarPropietario(propietario.dni, propietario.nombres, propietario.apellidos, propietario.correo, propietario.telefono, propietario.direccion);
                
                if (resultado)
                {
                    EnvioCorreos.EnviarEliminacionPropietario(propietario.correo, propietario.nombres, propietario.apellidos, propietario.dni, propietario.telefono, propietario.direccion);
                }
                
                return resultado;
            }
            catch (Exception e)
            {
                throw new Exception("Error al Eliminar Propietario" + e.Message);
            }

        }

        // Método para buscar un propietario por su DNI.
        public DataTable Buscar_DNI(EPropietario propietario)
        {
            try
            {
                // Llama al método de la capa de datos para buscar un propietario por su DNI y devuelve un DataTable con los resultados.
                return obj_Propietario_datos.BuscarPropietarioPorDNI(propietario.dni);

            }
            catch (Exception e)
            {
                throw new Exception("Error al Buscar Propietario" + e.Message);
            }

        }
    }
}
