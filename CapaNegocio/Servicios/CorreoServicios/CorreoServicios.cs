using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Servicios.CorreoServicios
{
    public class CorreoServicios
    {
        public void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            if (string.IsNullOrWhiteSpace(destinatario))
            {
                throw new ArgumentException("El destinatario no puede estar vacío.", nameof(destinatario));
            }
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            {
                string remitente = "grupo6.cobross.a@gmail.com"; // Ingresa tu dirección de correo aquí
                string contraseña = "udduasrdkjobffqf"; // Ingresa tu contraseña aquí
                string nombreEmpresa = "Cobros-C.S."; // Ingresa nombre de la Empresa aqui

                client.Port = 587; // Puerto estándar para conexiones TLS
                client.Credentials = new System.Net.NetworkCredential(remitente, contraseña);
                client.EnableSsl = true; // Habilitar SSL/TLS

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(remitente, nombreEmpresa);
                mailMessage.To.Add(destinatario);
                mailMessage.Subject = asunto;
                mailMessage.Body = cuerpo;

                client.Send(mailMessage);
            }
        }
    }

}
