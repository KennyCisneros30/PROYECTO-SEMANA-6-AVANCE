namespace CapaVisual
{
    partial class frmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculo));
            GuardarVehiculo = new Button();
            PlacaTextBox = new TextBox();
            ValorTextBox = new TextBox();
            AñoTextBox = new TextBox();
            CilindrajeTextBox = new TextBox();
            ModeloTextBox = new TextBox();
            ColorTextBox = new TextBox();
            DNITextBox = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ModificarVehiculo = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            CorreoTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GuardarVehiculo
            // 
            GuardarVehiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GuardarVehiculo.Location = new Point(184, 417);
            GuardarVehiculo.Name = "GuardarVehiculo";
            GuardarVehiculo.Size = new Size(137, 55);
            GuardarVehiculo.TabIndex = 0;
            GuardarVehiculo.Text = "Guardar Vehiculo";
            GuardarVehiculo.UseVisualStyleBackColor = true;
            GuardarVehiculo.Click += GuardarVehiculo_Click;
            // 
            // PlacaTextBox
            // 
            PlacaTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PlacaTextBox.Location = new Point(80, 32);
            PlacaTextBox.Name = "PlacaTextBox";
            PlacaTextBox.Size = new Size(125, 23);
            PlacaTextBox.TabIndex = 1;
            PlacaTextBox.KeyPress += PlacaTextBox_KeyPress;
            // 
            // ValorTextBox
            // 
            ValorTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ValorTextBox.Location = new Point(80, 77);
            ValorTextBox.Name = "ValorTextBox";
            ValorTextBox.Size = new Size(125, 23);
            ValorTextBox.TabIndex = 2;
            ValorTextBox.KeyPress += ValorTextBox_KeyPress;
            // 
            // AñoTextBox
            // 
            AñoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AñoTextBox.Location = new Point(80, 122);
            AñoTextBox.Name = "AñoTextBox";
            AñoTextBox.Size = new Size(125, 23);
            AñoTextBox.TabIndex = 3;
            AñoTextBox.KeyPress += AñoTextBox_KeyPress;
            // 
            // CilindrajeTextBox
            // 
            CilindrajeTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CilindrajeTextBox.Location = new Point(80, 167);
            CilindrajeTextBox.Name = "CilindrajeTextBox";
            CilindrajeTextBox.Size = new Size(125, 23);
            CilindrajeTextBox.TabIndex = 4;
            CilindrajeTextBox.Tag = "";
            CilindrajeTextBox.KeyPress += CilindrajeTextBox_KeyPress;
            // 
            // ModeloTextBox
            // 
            ModeloTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ModeloTextBox.Location = new Point(83, 33);
            ModeloTextBox.Name = "ModeloTextBox";
            ModeloTextBox.Size = new Size(200, 23);
            ModeloTextBox.TabIndex = 5;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ColorTextBox.Location = new Point(83, 78);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 23);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.KeyPress += ColorTextBox_KeyPress;
            // 
            // DNITextBox
            // 
            DNITextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DNITextBox.Location = new Point(83, 42);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(175, 23);
            DNITextBox.TabIndex = 7;
            DNITextBox.KeyPress += DNITextBox_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.RetrocerderIcon;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 19;
            label1.Text = "Placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 85);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 20;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 125);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 21;
            label3.Text = "Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 170);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 22;
            label4.Text = "Cilindraje:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 36);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 23;
            label5.Text = "Modelo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 81);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 24;
            label6.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 45);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 25;
            label7.Text = "DNI:";
            // 
            // ModificarVehiculo
            // 
            ModificarVehiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ModificarVehiculo.Location = new Point(368, 427);
            ModificarVehiculo.Name = "ModificarVehiculo";
            ModificarVehiculo.Size = new Size(137, 55);
            ModificarVehiculo.TabIndex = 26;
            ModificarVehiculo.Text = "Modificar Vehiculo";
            ModificarVehiculo.UseVisualStyleBackColor = true;
            ModificarVehiculo.Click += ModificarVehiculo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CilindrajeTextBox);
            groupBox1.Controls.Add(AñoTextBox);
            groupBox1.Controls.Add(ValorTextBox);
            groupBox1.Controls.Add(PlacaTextBox);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(38, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 211);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Vehículo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(ColorTextBox);
            groupBox2.Controls.Add(ModeloTextBox);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(38, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 123);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Características del Vehículo";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CorreoTextBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(DNITextBox);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(349, 303);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 117);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Propietario del Vehículo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IngresoVehiculosIcon;
            pictureBox1.Location = new Point(368, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // CorreoTextBox
            // 
            CorreoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CorreoTextBox.Location = new Point(83, 85);
            CorreoTextBox.Name = "CorreoTextBox";
            CorreoTextBox.Size = new Size(175, 23);
            CorreoTextBox.TabIndex = 26;
            // 
            // frmVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(691, 494);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ModificarVehiculo);
            Controls.Add(pictureBox2);
            Controls.Add(GuardarVehiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Vehículos";
            FormClosing += frmVehiculos_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void DNITextBeyPress1(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button GuardarVehiculo;
        private TextBox PlacaTextBox;
        private TextBox ValorTextBox;
        private TextBox AñoTextBox;
        private TextBox CilindrajeTextBox;
        private TextBox ModeloTextBox;
        private TextBox ColorTextBox;
        private TextBox DNITextBox;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ModificarVehiculo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private TextBox CorreoTextBox;
    }
}