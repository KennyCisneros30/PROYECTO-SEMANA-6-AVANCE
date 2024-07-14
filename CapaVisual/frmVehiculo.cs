using CapaVisual.Validaciones;
using CapaNegocio;
using CapaNegocio.Entidades;
using System.Windows.Forms;
using CapaNegocio.Servicios.CorreoServicios;

namespace CapaVisual
{
    public partial class frmVehiculo : Form
    {
        // Declaración de objetos para manipular entidades y negocios de vehículos
        EVehiculo EntidadVehiculo = new EVehiculo();
        EPropietario EntidadPropietario = new EPropietario();
        NVehiculo NegocioVehiculo = new NVehiculo();
        ValidacionesMetodos ValidarDatos = new ValidacionesMetodos();
        LimpiezaDatos LimpiarControladores = new LimpiezaDatos();


        // Método para limpiar los controles de texto en el formulario frmVehiculos
        internal void LimpiarTextBox()
        {
            LimpiarControladores.LimpiarControladoresVehiculos(PlacaTextBox, ValorTextBox, AñoTextBox, CilindrajeTextBox, ModeloTextBox, ColorTextBox, DNITextBox);
        }



        // Constructor del formulario
        public frmVehiculo()
        {
            InitializeComponent();
            // Suscribir el evento TextChanged de los TextBox
            PlacaTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            ValorTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            AñoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            CilindrajeTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            ModeloTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            ColorTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            DNITextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // Inicialmente deshabilitar el botón
            GuardarVehiculo.Enabled = false;
        }

        // Método para manejar cambios en TextBox y habilitar/deshabilitar botón
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            TextBox textBox = sender as TextBox;
            int maxLength = textBox.MaxLength;

            // Comprobar si todos los TextBox tienen texto
            GuardarVehiculo.Enabled = !string.IsNullOrWhiteSpace(PlacaTextBox.Text) &&
                                      !string.IsNullOrWhiteSpace(ValorTextBox.Text) &&
                                      !string.IsNullOrWhiteSpace(AñoTextBox.Text) &&
                                      !string.IsNullOrWhiteSpace(CilindrajeTextBox.Text) &&
                                      !string.IsNullOrWhiteSpace(ModeloTextBox.Text) &&
                                      !string.IsNullOrWhiteSpace(ColorTextBox.Text) &&
                                      !string.IsNullOrWhiteSpace(DNITextBox.Text);
        }

        // Guardar la información del vehículo
        private void GuardarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del vehículo desde los controles de la interfaz
                EntidadVehiculo.Placa = PlacaTextBox.Text;
                EntidadVehiculo.Valor = decimal.Parse(ValorTextBox.Text);
                EntidadVehiculo.Año = int.Parse(AñoTextBox.Text);
                EntidadVehiculo.Cilindraje = int.Parse(CilindrajeTextBox.Text);
                EntidadVehiculo.Modelo = ModeloTextBox.Text;
                EntidadVehiculo.Color = ColorTextBox.Text;
                EntidadVehiculo.Dni_Propieatrio = DNITextBox.Text;
                EntidadVehiculo.Correo_Propietario = CorreoTextBox.Text;

                // Verificar si el correo está vacío antes de continuar
                if (string.IsNullOrWhiteSpace(EntidadVehiculo.Correo_Propietario))
                {
                    MessageBox.Show("El correo del propietario no puede estar vacío.");
                    return;
                }

                // Verificar si el DNI y correo del propietario existen en la base de datos
                var propietarioExistente = NegocioVehiculo.Verificar_DNIyCorreoExistente(EntidadVehiculo);

                if (propietarioExistente.Rows.Count > 0)
                {
                    // Si existe el propietario, obtener los datos del propietario
                    var propietario = new EPropietario
                    {
                        Dni = propietarioExistente.Rows[0]["DNI"].ToString(),
                        Correo = propietarioExistente.Rows[0]["CORREO"].ToString(),
                        Nombres = propietarioExistente.Rows[0]["NOMBRES"].ToString(),
                        Apellidos = propietarioExistente.Rows[0]["APELLIDOS"].ToString()
                    };

                    // Crear el vehículo
                    var resultado = NegocioVehiculo.CrearVehiculo(EntidadVehiculo, propietario);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito");
                        LimpiarTextBox();
                    }
                    else
                    {
                        MessageBox.Show("No se creó el registro.");
                    }
                }
                else
                {
                    MessageBox.Show("El DNI y/o correo proporcionados no existen en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar vehículo: {ex.Message}");
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuPrincipal formuPrincipal = new MenuPrincipal();
            formuPrincipal.Show();
            this.Hide();
        }

        private void ModificarVehiculo_Click(object sender, EventArgs e)
        {
            frmModificarVehiculo formuModificar = new frmModificarVehiculo();
            formuModificar.Show();
            this.Hide();
        }


        // Métodos para validar entrada de datos en TextBox específicos según su contenido
        private void ValorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, ValorTextBox);
        }

        private void AñoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumerosAños(e, AñoTextBox);
        }

        private void CilindrajeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, CilindrajeTextBox);
        }

        private void ColorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e, ColorTextBox);
        }

        private void DNITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, DNITextBox);
        }

        private void PlacaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumeroYLetras(e, PlacaTextBox);
        }

        private void frmVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
