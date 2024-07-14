using CapaNegocio;
using CapaVisual.Validaciones;
using CapaNegocio.Entidades;
using System.Data;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class frmModificarVehiculo : Form
    {
        // Declaración de objetos para manipular entidades y negocios de vehículos y propietarios
        EVehiculo EntidadVehiculo = new EVehiculo();
        EPropietario EntidadPropietario = new EPropietario();
        NVehiculo NegocioVehiculo = new NVehiculo();
        ValidacionesMetodos ValidarDatos = new ValidacionesMetodos();
        LimpiezaDatos LimpiarControladores = new LimpiezaDatos();


        // Método para limpiar los controles de texto en el formulario frmModificarVehiculo
        internal void LimpiarTextBox()
        {
            LimpiarControladores.LimpiarControladoresMVehiculos(MVPlacaTextBox, MVValorTextBox, MVAñoTextBox, MVCilindrajeTextBox, MVModeloTextBox, MVColorTextBox, MVDNITextBox, MVPlacaBuscarTextBox);
        }


        public frmModificarVehiculo()
        {
            InitializeComponent();
            // Suscribir el evento TextChanged de los TextBox
            MVPlacaTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVValorTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVAñoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVCilindrajeTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVModeloTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVColorTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVDNITextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // Inicialmente deshabilitar el botón
            GuardarV.Enabled = false;
            EliminarVehiculo.Enabled = false;
        }

        // Método para manejar cambios en TextBox y habilitar/deshabilitar botones
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Comprobar si todos los TextBox tienen texto
            GuardarV.Enabled = !string.IsNullOrWhiteSpace(MVPlacaTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVValorTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVAñoTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVCilindrajeTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVModeloTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVColorTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVDNITextBox.Text);
            EliminarVehiculo.Enabled = !string.IsNullOrWhiteSpace(MVPlacaTextBox.Text);
        }

        private void BuscarPlaca_Click(object sender, EventArgs e)
        {
            // Buscar información del vehículo según la placa proporcionada
            try
            {
                EntidadVehiculo.Placa = MVPlacaBuscarTextBox.Text;

                var resultado = NegocioVehiculo.Buscar_Placa(EntidadVehiculo);
                if (resultado.Rows.Count > 0)
                {
                    DataRow row = resultado.Rows[0];
                    MVPlacaTextBox.Text = row["PLACA"].ToString();
                    MVValorTextBox.Text = row["VALOR"].ToString();
                    MVAñoTextBox.Text = row["AÑO"].ToString();
                    MVCilindrajeTextBox.Text = row["CILINDRAJE"].ToString();
                    MVModeloTextBox.Text = row["MODELO"].ToString();
                    MVColorTextBox.Text = row["COLOR"].ToString();
                    MVDNITextBox.Text = row["DNI"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para la placa proporcionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Manejar evento de clic en botón Guardar

        private void GuardarV_Click(object sender, EventArgs e)
        {
            // Guardar la información modificada del vehículo
            try
            {
                EntidadVehiculo.Placa = MVPlacaTextBox.Text;
                EntidadVehiculo.Valor = decimal.Parse(MVValorTextBox.Text);
                EntidadVehiculo.Año = int.Parse(MVAñoTextBox.Text);
                EntidadVehiculo.Cilindraje = int.Parse(MVCilindrajeTextBox.Text);
                EntidadVehiculo.Modelo = MVModeloTextBox.Text;
                EntidadVehiculo.Color = MVColorTextBox.Text;

                int propietarioId = NegocioVehiculo.ObtenerID(MVDNITextBox.Text);
                EntidadVehiculo.Dni_Propieatrio =  Convert.ToString(propietarioId);

                var resultado = NegocioVehiculo.ActualizarVehiculo(EntidadVehiculo, EntidadPropietario);
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

        // Manejar evento de clic en botón Eliminar
        private void EliminarVehiculo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro de que desea eliminar este vehiculo?", "Eliminar Vehiculo"
                , botones, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    EntidadVehiculo.Placa = (MVPlacaTextBox.Text);
                    if (NegocioVehiculo.Eliminar_Vehiculo(EntidadVehiculo, EntidadPropietario))
                    {
                        MessageBox.Show("Registro Eliminado con Exito");
                        LimpiarTextBox();
                    }
                    else
                        MessageBox.Show("Registro No Pudo ser Eliminado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmVehiculo formuVehiculos = new frmVehiculo();
            formuVehiculos.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuPrincipal formuPrincipal = new MenuPrincipal();
            formuPrincipal.Show();
            this.Hide();
        }

        // Métodos para validar entrada de datos en TextBox específicos según su contenido
        private void MVValorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, MVValorTextBox);
        }

        private void MVAñoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumerosAños(e, MVAñoTextBox);
        }

        private void MVCilindrajeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e, MVCilindrajeTextBox);
        }

        private void MVColorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e, MVColorTextBox);
        }

        private void frmModificarVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MVPlacaBuscarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumeroYLetras(e, MVPlacaBuscarTextBox);
        }
    }
}
