using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Servicios.CorreoServicios.ConstruccionCorreos
{
    internal class CVehiculo
    {
        
        CorreoServicios ServicioEnvio = new CorreoServicios();



        public void EnviarRegistroVehiculo(string destinatario, string nombres, string apellidos, string placa, string modelo, string color, int año, int cilindraje, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(destinatario))
            {
                Console.WriteLine("Advertencia: No se puede enviar el correo porque la dirección de destino está vacía.");
                return;
            }

            string asunto = "Bienvenido a nuestra plataforma";
            string cuerpo = $"Hola {nombres} {apellidos},\n\n" +
                          "Se ha registrado un nuevo vehículo a su nombre con los siguientes detalles:\n\n" +
                          $"Placa: {placa}\n" +
                          $"Modelo: {modelo}\n" +
                          $"Color: {color}\n" +
                          $"Año: {año}\n" +
                          $"Cilindraje: {cilindraje}\n" +
                          $"Valor: {valor}\n\n" +
                          "Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                          "Saludos,\n" +
                          "El equipo de COBROS-C.S.";

            ServicioEnvio.EnviarCorreo(destinatario, asunto, cuerpo);
        }



        public void EnviarModificacionVehiculo(string destinatario, string nombres, string apellidos, string placa, string modelo, string color, int año, int cilindraje, decimal valor)
        {
            string asunto = "Bienvenido a nuestra plataforma";
            string cuerpo = $"Hola {nombres} {apellidos},\n\n" +
                          $"Se han realizado las siguientes modificaciones a su vehículo con placa {placa}:\n\n" +
                          $"Modelo: {modelo}\n" +
                          $"Color: {color}\n" +
                          $"Año: {año}\n" +
                          $"Cilindraje: {cilindraje}\n" +
                          $"Valor: {valor}\n\n" +
                          "Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                          "Saludos,\n" +
                          "El equipo de COBROS-C.S.";

            ServicioEnvio.EnviarCorreo(destinatario, asunto, cuerpo);
        }



        public void EnviarEliminacionVehiculo(string destinatario, string nombres, string apellidos, string placa, string modelo, string color, int año, int cilindraje, decimal valor)
        {
            string asunto = "Cuenta de propietario eliminada";
            string cuerpo = $"Hola {nombres} {apellidos},\n\n" +
                          "Su vehículo con los siguientes detalles ha sido eliminado del registro:\n\n" +
                          $"Placa: {placa}\n" +
                          $"Modelo: {modelo}\n" +
                          $"Color: {color}\n" +
                          $"Año: {año}\n" +
                          $"Cilindraje: {cilindraje}\n" +
                          $"Valor: {valor}\n\n" +
                          "Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                          "Saludos,\n" +
                          "El equipo de COBROS-C.S.";

            ServicioEnvio.EnviarCorreo(destinatario, asunto, cuerpo);
        }
    }
}
