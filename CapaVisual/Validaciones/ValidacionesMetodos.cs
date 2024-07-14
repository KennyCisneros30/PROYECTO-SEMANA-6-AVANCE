using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CapaVisual.Validaciones
{
    internal class ValidacionesMetodos
    {
        ErrorProvider errorP = new ErrorProvider();


        private void MostrarErrorTemporal(TextBox txt, string mensaje)
        {
            errorP.SetError(txt, mensaje);

            // Crear un temporizador con un intervalo de tiempo breve
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // 5000 milisegundos = 5 segundos
            timer.Tick += (sender, args) =>
            {
                // Limpiar el error después de que pase el tiempo
                errorP.Clear();
                // Detener el temporizador
                timer.Stop();
                // Liberar recursos del temporizador
                timer.Dispose();
            };
            // Iniciar el temporizador
            timer.Start();
        }


        // Método para permitir solo letras en un TextBox
        public void SoloLetras(KeyPressEventArgs e, TextBox txt)
        {
            bool valida = ValidacionesEntradaDatos.soloLetras(e, txt);
            if (!valida)
            {
                MostrarErrorTemporal(txt, "Solo se permiten letras");
            }
            else
            {
                errorP.Clear();
            }
        }

        // Método para permitir solo números en un TextBox
        public void SoloNumeros(KeyPressEventArgs e, System.Windows.Forms.TextBox txt)
        {
            bool valida = ValidacionesEntradaDatos.SoloNumeros(e, txt);
            if (!valida)
            {
                MostrarErrorTemporal(txt, "Solo se permiten números de 10 dígitos");
            }

            else
            {
                errorP.Clear();
            }
        }

        // Método para validar un correo electrónico
        public void ValidarEmail(System.Windows.Forms.TextBox emailTextBox)
        {
            bool valido = ValidacionesEntradaDatos.validarEmail(emailTextBox.Text);
            if (!valido)
            {

                MostrarErrorTemporal(emailTextBox, "Correo electrónico no válido");

            }
            else
            {
                errorP.Clear();
            }
        }


        // Método para permitir solo números y letras en un TextBox
        public void NumeroYLetras(KeyPressEventArgs e, TextBox txt)
        {
            bool valida = ValidacionesEntradaDatos.NumerosYLetras(e, txt);
            if (!valida)
            {

                MostrarErrorTemporal(txt, "Solo se permiten 7 dígitos");

            }
            else
            {
                errorP.Clear();
            }
        }


        // Método para permitir solo números de 4 dígitos en un TextBox (para años)
        public void SoloNumerosAños(KeyPressEventArgs e, System.Windows.Forms.TextBox txt)
        {
            bool valida = ValidacionesEntradaDatos.SoloNumerosAños(e, txt);
            if (!valida)
            {

                MostrarErrorTemporal(txt, "Solo se permiten números de 4 dígitos");

            }

            else
            {
                errorP.Clear();
            }
        }



    }
}
