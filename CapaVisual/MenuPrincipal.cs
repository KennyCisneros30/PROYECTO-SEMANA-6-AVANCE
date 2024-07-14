namespace CapaVisual
{
    public partial class MenuPrincipal : Form
    {
        // Constructor del formulario
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Mostrar el formulario de propietario y ocultar el menú principal
        private void button1_Click(object sender, EventArgs e)
        {
            frmPropietario formuPropietario = new frmPropietario();
            formuPropietario.Show();
            this.Hide();
        }

        // Mostrar el formulario de vehículos y ocultar el menú principal
        private void button3_Click(object sender, EventArgs e)
        {
            frmVehiculo formuVehiculos = new frmVehiculo();
            formuVehiculos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensaje = "Este programa fue realizado para ser presentado como proyecto de Construcción de Software del curso MA6-3 por parte del Grupo F:\n\n" +
                             "- Armijos Moreira Kenneth Fernando\n\n" +
                             "- Cisneros Alcivar Kenny Geampiere (LÍDER)\n\n" +
                             "- Mendoza Mendoza Cesar Oscar\n\n" +
                             "- Sánchez Marcillo Angelo Paul\n\n" +
                             "- Solís Salazar Alejandro Sebastian\n\n" +
                             "- Yagual Alarcón Mariana de Jesús";
            MessageBox.Show(mensaje, "Información del Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
