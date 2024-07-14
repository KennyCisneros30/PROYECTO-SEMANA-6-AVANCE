using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Servicios.CorreoServicios.ConstruccionCorreos
{
    internal class CPropietario
    {
        
        CorreoServicios ServicioEnvio = new CorreoServicios();



        public void EnviarRegistroPropietario(string destinatario, string nombres, string apellidos, string dni, string telefono, string direccion)
        {
            string asunto = "Bienvenido a nuestra plataforma";
            string cuerpo = $"Hola {nombres} {apellidos},\n\n" +
                          "Gracias por registrarte en nuestra plataforma. Aquí están tus detalles de registro:\n\n" +
                          $"DNI: {dni}\n" +
                          $"Teléfono: {telefono}\n" +
                          $"Dirección: {direccion}\n\n" +
                          "Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                          "Saludos,\n" +
                          "El equipo de COBROS-C.S.";

            ServicioEnvio.EnviarCorreo(destinatario, asunto, cuerpo);
        }



        public void EnviarModificacionPropietario(string destinatario, string nombres, string apellidos, string dni, string telefono, string direccion)
        {
            string asunto = "Detalles del propietario modificados";
            string cuerpo = $"Hola {nombres} {apellidos},\n\n" +
                          "Tus detalles han sido actualizados. Aquí están los nuevos detalles:\n\n" +
                          $"DNI: {dni}\n" +
                          $"Teléfono: {telefono}\n" +
                          $"Dirección: {direccion}\n\n" +
                          "Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                          "Saludos,\n" +
                          "El equipo de COBROS-C.S.";

            ServicioEnvio.EnviarCorreo(destinatario, asunto, cuerpo);
        }



        public void EnviarEliminacionPropietario(string destinatario, string nombres, string apellidos, string dni, string telefono, string direccion)
        {
            string asunto = "Cuenta de propietario eliminada";
            string cuerpo = $"Hola {nombres} {apellidos},\n\n" +
                          "Lamentamos informarte que tu cuenta ha sido eliminada de nuestra plataforma. Aquí están los detalles de tu cuenta:\n\n" +
                          $"DNI: {dni}\n" +
                          $"Teléfono: {telefono}\n" +
                          $"Dirección: {direccion}\n\n" +
                          "Si tienes alguna pregunta, no dudes en contactarnos.\n\n" +
                          "Saludos,\n" +
                          "El equipo de COBROS-C.S.";

            ServicioEnvio.EnviarCorreo(destinatario, asunto, cuerpo);
        }

    }
}
