using CapaNegocio;
using CapaVisual.Validaciones;
using CapaNegocio.Entidades;
using System.Data;
namespace CapaVisual
{
    // Declaración de objetos y variables
    public partial class frmModificarPropietario : Form
    {
        EPropietario EntidadPropietario = new EPropietario();
        NPropietario NegocioPropietario = new NPropietario();
        ValidacionesMetodos ValidarDatos = new ValidacionesMetodos();
        LimpiezaDatos LimpiarControladores = new LimpiezaDatos();


        // Método para limpiar los controles de texto en el formulario frmModificarPropietario
        internal void LimpiarTextBox()
        {
            LimpiarControladores.LimpiarControladoresMPropietario(MNombresTextBox, MApellidosTextBox, MDNITextBox, MTelefonoTextBox, MCorreoTextBox, MDireccionTextBox, MBuscarTextBox);
        }


        public frmModificarPropietario()
        {
            InitializeComponent();
            // Suscribir el evento TextChanged de los TextBox
            MNombresTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MApellidosTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MCorreoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MTelefonoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MDireccionTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MDNITextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // Inicialmente deshabilitar el botón
            GuardarM.Enabled = false;
            EliminarPropietario.Enabled = false;
        }

        // Evento que se dispara cuando cambia el texto en algún TextBox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Comprobar si todos los TextBox tienen texto
            GuardarM.Enabled = !string.IsNullOrWhiteSpace(MNombresTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MApellidosTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MCorreoTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MTelefonoTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MDireccionTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MDNITextBox.Text);
            EliminarPropietario.Enabled = !string.IsNullOrWhiteSpace(MNombresTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MApellidosTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MCorreoTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MTelefonoTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MDireccionTextBox.Text) &&
                                         !string.IsNullOrWhiteSpace(MDNITextBox.Text);
        }

        // Evento que se dispara al hacer clic en el botón BuscarDNI
        private void BuscarDNI_Click(object sender, EventArgs e)
        {
            // Lógica para buscar un propietario por DNI
            try
            {
                EntidadPropietario.Dni = MBuscarTextBox.Text;

                var resultado = NegocioPropietario.Buscar_DNI(EntidadPropietario);
                if (resultado.Rows.Count > 0)
                {
                    DataRow row = resultado.Rows[0];
                    MDNITextBox.Text = row["DNI"].ToString();
                    MNombresTextBox.Text = row["Nombres"].ToString();
                    MApellidosTextBox.Text = row["Apellidos"].ToString();
                    MCorreoTextBox.Text = row["Correo"].ToString();
                    MTelefonoTextBox.Text = row["Telefono"].ToString();
                    MDireccionTextBox.Text = row["Direccion"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para los nombres y apellidos proporcionados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Evento que se dispara al hacer clic en el botón GuardarM
        private void GuardarM_Click(object sender, EventArgs e)
        {
            // Lógica para guardar los cambios de un propietario
            try
            {
                EntidadPropietario.Dni = MDNITextBox.Text;
                EntidadPropietario.Nombres = MNombresTextBox.Text;
                EntidadPropietario.Apellidos = MApellidosTextBox.Text;
                EntidadPropietario.Correo = MCorreoTextBox.Text;
                EntidadPropietario.Telefono = MTelefonoTextBox.Text;
                EntidadPropietario.Direccion = MDireccionTextBox.Text;

                var resultado = NegocioPropietario.ActualizarPropietario(EntidadPropietario);
                if (resultado)
                {
                    MessageBox.Show("Registro Modificado con Exito");
                    LimpiarTextBox();
                }
                else
                    MessageBox.Show("No se Modifico el Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Evento que se dispara al hacer clic en el botón EliminarPropietario
        private void EliminarPropietario_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un propietario
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro de que desea eliminar este cliente?", "Eliminar Cliente"
                , botones, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    EntidadPropietario.Dni = MDNITextBox.Text;

                    if (NegocioPropietario.Eliminar_Propietario(EntidadPropietario))
                    {
                        MessageBox.Show("Registro Eliminado con Exito");
                        LimpiarTextBox();
                    }
                    else
                        MessageBox.Show("Registro No Pudo ser Eliminado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // métodos y eventos que manejan la interacción del usuario en el formulario de Modificar Propietario
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPropietario formuPropietario = new frmPropietario();
            formuPropietario.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuPrincipal formuPrincipal = new MenuPrincipal();
            formuPrincipal.Show();
            this.Hide();
        }

        private void MNombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e, MNombresTextBox);
        }

        private void MApellidosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e, MApellidosTextBox);
        }

        private void MCorreoTextBox_Leave(object sender, EventArgs e)
        {
            ValidarDatos.ValidarEmail(MCorreoTextBox);
        }

        private void MTelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, MTelefonoTextBox);
        }

        private void MBuscarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, MBuscarTextBox);
        }

        private void frmModificarPropietario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}