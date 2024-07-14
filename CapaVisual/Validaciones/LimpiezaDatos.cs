using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaVisual.Validaciones
{
    internal class LimpiezaDatos
    {

        // Método para limpiar los controles de texto en el formulario frmPropietario
        internal void LimpiarControladoresPropietario(TextBox nombresTextBox, TextBox apellidosTextBox, TextBox dniTextBox, TextBox telefonoTextBox, TextBox correoTextBox, TextBox direccionTextBox)
        {
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            dniTextBox.Text = "";
            telefonoTextBox.Text = "";
            correoTextBox.Text = "";
            direccionTextBox.Text = "";
        }

        // Método para limpiar los controles de texto en el formulario frmModificarPropietario
        internal void LimpiarControladoresMPropietario(TextBox nombresTextBox, TextBox apellidosTextBox, TextBox dniTextBox, TextBox telefonoTextBox, TextBox correoTextBox, TextBox direccionTextBox, TextBox buscarTextBox)
        {
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            dniTextBox.Text = "";
            telefonoTextBox.Text = "";
            correoTextBox.Text = "";
            direccionTextBox.Text = "";
            buscarTextBox.Text = "";
        }

        // Método para limpiar los controles de texto en el formulario frmVehiculos
        internal void LimpiarControladoresVehiculos(TextBox placaTextBox, TextBox valorTextBox, TextBox añoTextBox, TextBox cilindrajeTextBox, TextBox modeloTextBox, TextBox colorTextBox, TextBox dniTextBox)
        {
            placaTextBox.Text = "";
            valorTextBox.Text = "";
            añoTextBox.Text = "";
            cilindrajeTextBox.Text = "";
            modeloTextBox.Text = "";
            colorTextBox.Text = "";
            dniTextBox.Text = "";
        }

        // Método para limpiar los controles de texto en el formulario frmModificarVehiculo
        internal void LimpiarControladoresMVehiculos(TextBox placaTextBox, TextBox valorTextBox, TextBox añoTextBox, TextBox cilindrajeTextBox, TextBox modeloTextBox, TextBox colorTextBox, TextBox dniTextBox, TextBox buscarTextBox)
        {
            placaTextBox.Text = "";
            valorTextBox.Text = "";
            añoTextBox.Text = "";
            cilindrajeTextBox.Text = "";
            modeloTextBox.Text = "";
            colorTextBox.Text = "";
            dniTextBox.Text = "";
            buscarTextBox.Text = "";
        }

    }
}
