namespace CapaVisual
{
    partial class frmModificarVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarVehiculo));
            BuscarPlaca = new Button();
            GuardarV = new Button();
            EliminarVehiculo = new Button();
            MVPlacaBuscarTextBox = new TextBox();
            MVPlacaTextBox = new TextBox();
            MVValorTextBox = new TextBox();
            MVAñoTextBox = new TextBox();
            MVCilindrajeTextBox = new TextBox();
            MVModeloTextBox = new TextBox();
            MVColorTextBox = new TextBox();
            MVDNITextBox = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BuscarPlaca
            // 
            BuscarPlaca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarPlaca.Location = new Point(404, 20);
            BuscarPlaca.Name = "BuscarPlaca";
            BuscarPlaca.Size = new Size(100, 31);
            BuscarPlaca.TabIndex = 0;
            BuscarPlaca.Text = "Buscar";
            BuscarPlaca.UseVisualStyleBackColor = true;
            BuscarPlaca.Click += BuscarPlaca_Click;
            // 
            // GuardarV
            // 
            GuardarV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GuardarV.Location = new Point(184, 433);
            GuardarV.Name = "GuardarV";
            GuardarV.Size = new Size(137, 55);
            GuardarV.TabIndex = 1;
            GuardarV.Text = "Guargar Modificacion";
            GuardarV.UseVisualStyleBackColor = true;
            GuardarV.Click += GuardarV_Click;
            // 
            // EliminarVehiculo
            // 
            EliminarVehiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EliminarVehiculo.Location = new Point(368, 433);
            EliminarVehiculo.Name = "EliminarVehiculo";
            EliminarVehiculo.Size = new Size(137, 55);
            EliminarVehiculo.TabIndex = 2;
            EliminarVehiculo.Text = "Eliminar Vehiculo";
            EliminarVehiculo.UseVisualStyleBackColor = true;
            EliminarVehiculo.Click += EliminarVehiculo_Click;
            // 
            // MVPlacaBuscarTextBox
            // 
            MVPlacaBuscarTextBox.Location = new Point(259, 24);
            MVPlacaBuscarTextBox.Name = "MVPlacaBuscarTextBox";
            MVPlacaBuscarTextBox.Size = new Size(126, 23);
            MVPlacaBuscarTextBox.TabIndex = 3;
            MVPlacaBuscarTextBox.KeyPress += MVPlacaBuscarTextBox_KeyPress;
            // 
            // MVPlacaTextBox
            // 
            MVPlacaTextBox.Enabled = false;
            MVPlacaTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVPlacaTextBox.Location = new Point(80, 32);
            MVPlacaTextBox.Name = "MVPlacaTextBox";
            MVPlacaTextBox.ReadOnly = true;
            MVPlacaTextBox.Size = new Size(125, 23);
            MVPlacaTextBox.TabIndex = 4;
            // 
            // MVValorTextBox
            // 
            MVValorTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVValorTextBox.Location = new Point(80, 76);
            MVValorTextBox.Name = "MVValorTextBox";
            MVValorTextBox.Size = new Size(125, 23);
            MVValorTextBox.TabIndex = 5;
            MVValorTextBox.KeyPress += MVValorTextBox_KeyPress;
            // 
            // MVAñoTextBox
            // 
            MVAñoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVAñoTextBox.Location = new Point(80, 120);
            MVAñoTextBox.Name = "MVAñoTextBox";
            MVAñoTextBox.Size = new Size(125, 23);
            MVAñoTextBox.TabIndex = 6;
            MVAñoTextBox.KeyPress += MVAñoTextBox_KeyPress;
            // 
            // MVCilindrajeTextBox
            // 
            MVCilindrajeTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVCilindrajeTextBox.Location = new Point(80, 164);
            MVCilindrajeTextBox.Name = "MVCilindrajeTextBox";
            MVCilindrajeTextBox.Size = new Size(125, 23);
            MVCilindrajeTextBox.TabIndex = 7;
            MVCilindrajeTextBox.KeyPress += MVCilindrajeTextBox_KeyPress;
            // 
            // MVModeloTextBox
            // 
            MVModeloTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVModeloTextBox.Location = new Point(83, 33);
            MVModeloTextBox.Name = "MVModeloTextBox";
            MVModeloTextBox.Size = new Size(200, 23);
            MVModeloTextBox.TabIndex = 8;
            // 
            // MVColorTextBox
            // 
            MVColorTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVColorTextBox.Location = new Point(83, 77);
            MVColorTextBox.Name = "MVColorTextBox";
            MVColorTextBox.Size = new Size(125, 23);
            MVColorTextBox.TabIndex = 9;
            MVColorTextBox.KeyPress += MVColorTextBox_KeyPress;
            // 
            // MVDNITextBox
            // 
            MVDNITextBox.Enabled = false;
            MVDNITextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MVDNITextBox.Location = new Point(83, 42);
            MVDNITextBox.Name = "MVDNITextBox";
            MVDNITextBox.ReadOnly = true;
            MVDNITextBox.Size = new Size(175, 23);
            MVDNITextBox.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.RetrocerderIcon;
            pictureBox4.Location = new Point(12, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 22;
            label1.Text = "Ingresar Placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 35);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 23;
            label2.Text = "Placa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 36);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 24;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 80);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 25;
            label4.Text = "Color:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 167);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 26;
            label5.Text = "Cilindraje:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 79);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 27;
            label6.Text = "Valor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 123);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 28;
            label7.Text = "Año:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 45);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 29;
            label8.Text = "DNI:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MVCilindrajeTextBox);
            groupBox1.Controls.Add(MVAñoTextBox);
            groupBox1.Controls.Add(MVValorTextBox);
            groupBox1.Controls.Add(MVPlacaTextBox);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(49, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 211);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Vehículo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(MVColorTextBox);
            groupBox2.Controls.Add(MVModeloTextBox);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(49, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 123);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características del Vehículo";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(MVDNITextBox);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(360, 319);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 91);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Propietario del Vehículo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ModificarVehiculosIcon;
            pictureBox1.Location = new Point(404, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.MenuPrincipalIcon;
            pictureBox2.Location = new Point(642, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmModificarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(695, 511);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(MVPlacaBuscarTextBox);
            Controls.Add(EliminarVehiculo);
            Controls.Add(GuardarV);
            Controls.Add(BuscarPlaca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmModificarVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModificarVehiculo";
            FormClosing += frmModificarVehiculo_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BuscarPlaca;
        private Button GuardarV;
        private Button EliminarVehiculo;
        private TextBox MVPlacaBuscarTextBox;
        private TextBox MVPlacaTextBox;
        private TextBox MVValorTextBox;
        private TextBox MVAñoTextBox;
        private TextBox MVCilindrajeTextBox;
        private TextBox MVModeloTextBox;
        private TextBox MVColorTextBox;
        private TextBox MVDNITextBox;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}