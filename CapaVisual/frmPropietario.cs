using CapaNegocio;
using CapaNegocio.Entidades;
using CapaVisual.Validaciones;
using System.Windows.Forms;

namespace CapaVisual
{
    
    public partial class frmPropietario : Form
    { 
        // Declaración de objetos para manipular entidades y negocios de propietarios
        EPropietario EntidadPropietario = new EPropietario();
        NPropietario NegocioPropietario = new NPropietario();
        ValidacionesMetodos ValidarDatos = new ValidacionesMetodos();
        LimpiezaDatos LimpiarControladores = new LimpiezaDatos();



        internal void LimpiarTextBox()
        {
            LimpiarControladores.LimpiarControladoresPropietario(NombresTextBox, ApellidosTextBox, DNITextBox, TelefonoTextBox, CorreoTextBox, DireccionTextBox);
        }



        // Constructor del formulario
        public frmPropietario()
        {
            InitializeComponent();
            // Suscribir el evento TextChanged de los TextBox
            NombresTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            ApellidosTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            CorreoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            TelefonoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            DireccionTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            DNITextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // Inicialmente deshabilitar el botón
            GuardarPropietario.Enabled = false;
        }

        // Método para manejar cambios en TextBox y habilitar/deshabilitar botón
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Comprobar si todos los TextBox tienen texto
            GuardarPropietario.Enabled = !string.IsNullOrWhiteSpace(NombresTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(ApellidosTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(CorreoTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(TelefonoTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(DireccionTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(DNITextBox.Text);
        }

        // Manejar evento de clic en botón Guardar
        private void GuardarPropietario_Click(object sender, EventArgs e)
        {
            // Guardar la información del propietario
            try
            {
                EntidadPropietario.Dni = DNITextBox.Text;
                EntidadPropietario.Nombres = NombresTextBox.Text;
                EntidadPropietario.Apellidos = ApellidosTextBox.Text;
                EntidadPropietario.Correo = CorreoTextBox.Text;
                EntidadPropietario.Telefono = TelefonoTextBox.Text;
                EntidadPropietario.Direccion = DireccionTextBox.Text;

                var resultado = NegocioPropietario.CrearPropietario(EntidadPropietario);
                if (resultado)
                {
                    MessageBox.Show("Registro Creado con Exito");
                    LimpiarTextBox();
                }
                else
                    MessageBox.Show("No se Creo el Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        // Mostrar el formulario de modificación de propietario y ocultar este formulario
        private void ModificarPropietario_Click(object sender, EventArgs e)
        {
            frmModificarPropietario formuModificar = new frmModificarPropietario();
            formuModificar.Show();
            this.Hide();
        }

        // Métodos para validar entrada de datos en TextBox específicos según su contenido
        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e, NombresTextBox);
        }

        private void ApellidosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e, ApellidosTextBox);
        }

        private void DNITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, DNITextBox);
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, TelefonoTextBox);
        }

        private void CorreoTextBox_Leave(object sender, EventArgs e)
        {
            ValidarDatos.ValidarEmail(CorreoTextBox);
        }

        private void frmPropietario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}