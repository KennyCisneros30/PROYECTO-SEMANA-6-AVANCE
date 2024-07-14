using System;
using System.Windows.Forms;
using CapaDatos.Interface;
using CapaDatos;
using CapaNegocio;
using ProyectoCS.Controlador;

namespace CapaVisual
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal());
        }
    }
}
