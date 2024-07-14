using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaVisual.Validaciones
{
    internal class ValidacionesEntradaDatos
    {
        // Método para permitir solo la entrada de números en un TextBox.
        internal static bool SoloNumeros(KeyPressEventArgs e, TextBox txtnum)
        {
            if (char.IsNumber(e.KeyChar) && txtnum.Text.Length < 10)
            {
                e.Handled = false; // Permite el ingreso del carácter.
                return true; // Indica que se permitió el ingreso de números.
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Permite caracteres de control como borrar.
                return true; // Indica que se permitió el ingreso de caracteres de control.

            }
            else
            {
                e.Handled = true; // Bloquea el ingreso del carácter.
                return false;
            }
        }

        // Método para permitir solo la entrada de números para años en un TextBox.
        internal static bool SoloNumerosAños(KeyPressEventArgs e, TextBox txtnum)
        {
            if (char.IsNumber(e.KeyChar) && txtnum.Text.Length < 4)
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        // Método para permitir la entrada de números y letras en un TextBox.
        internal static bool NumerosYLetras(KeyPressEventArgs e, TextBox txt)
        {
            if ((char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar)) && txt.Text.Length < 7)
            {
                e.Handled = false;
                return true; // Indica que se permitió el ingreso de números y letras.
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        // Método para permitir solo la entrada de letras en un TextBox.
        internal static bool soloLetras(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true; // Indica que se permitió el ingreso de letras.
            } 
            else if (char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        // Método para validar un correo electrónico.
        internal static bool validarEmail(string pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
