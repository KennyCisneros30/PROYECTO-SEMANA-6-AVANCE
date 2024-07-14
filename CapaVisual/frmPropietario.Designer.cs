namespace CapaVisual
{
    partial class frmPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropietario));
            GuardarPropietario = new Button();
            ApellidosTextBox = new TextBox();
            TelefonoTextBox = new TextBox();
            DNITextBox = new TextBox();
            NombresTextBox = new TextBox();
            CorreoTextBox = new TextBox();
            DireccionTextBox = new TextBox();
            NombresLabel = new Label();
            ApellidosLabel = new Label();
            DNILabel = new Label();
            CorreoLabel = new Label();
            TelefonoLabel = new Label();
            DireccionLabel = new Label();
            ModificarPropietario = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // GuardarPropietario
            // 
            GuardarPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GuardarPropietario.Location = new Point(434, 251);
            GuardarPropietario.Name = "GuardarPropietario";
            GuardarPropietario.Size = new Size(137, 55);
            GuardarPropietario.TabIndex = 0;
            GuardarPropietario.Text = "Guardar Propietario";
            GuardarPropietario.UseVisualStyleBackColor = true;
            GuardarPropietario.Click += GuardarPropietario_Click;
            // 
            // ApellidosTextBox
            // 
            ApellidosTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ApellidosTextBox.Location = new Point(78, 70);
            ApellidosTextBox.Name = "ApellidosTextBox";
            ApellidosTextBox.Size = new Size(250, 23);
            ApellidosTextBox.TabIndex = 1;
            ApellidosTextBox.KeyPress += ApellidosTextBox_KeyPress;
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TelefonoTextBox.Location = new Point(81, 73);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(175, 23);
            TelefonoTextBox.TabIndex = 2;
            TelefonoTextBox.KeyPress += TelefonoTextBox_KeyPress;
            // 
            // DNITextBox
            // 
            DNITextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DNITextBox.Location = new Point(78, 112);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(175, 23);
            DNITextBox.TabIndex = 3;
            DNITextBox.KeyPress += DNITextBox_KeyPress;
            // 
            // NombresTextBox
            // 
            NombresTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NombresTextBox.Location = new Point(78, 32);
            NombresTextBox.Name = "NombresTextBox";
            NombresTextBox.Size = new Size(250, 23);
            NombresTextBox.TabIndex = 4;
            NombresTextBox.KeyPress += NombresTextBox_KeyPress;
            // 
            // CorreoTextBox
            // 
            CorreoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CorreoTextBox.Location = new Point(81, 35);
            CorreoTextBox.Name = "CorreoTextBox";
            CorreoTextBox.Size = new Size(250, 23);
            CorreoTextBox.TabIndex = 5;
            CorreoTextBox.Leave += CorreoTextBox_Leave;
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DireccionTextBox.Location = new Point(81, 110);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(250, 23);
            DireccionTextBox.TabIndex = 6;
            // 
            // NombresLabel
            // 
            NombresLabel.AutoSize = true;
            NombresLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NombresLabel.Location = new Point(6, 35);
            NombresLabel.Name = "NombresLabel";
            NombresLabel.Size = new Size(61, 15);
            NombresLabel.TabIndex = 7;
            NombresLabel.Text = "Nombres:";
            // 
            // ApellidosLabel
            // 
            ApellidosLabel.AutoSize = true;
            ApellidosLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ApellidosLabel.Location = new Point(6, 73);
            ApellidosLabel.Name = "ApellidosLabel";
            ApellidosLabel.Size = new Size(60, 15);
            ApellidosLabel.TabIndex = 8;
            ApellidosLabel.Text = "Apellidos:";
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DNILabel.Location = new Point(6, 115);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(32, 15);
            DNILabel.TabIndex = 9;
            DNILabel.Text = "DNI:";
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CorreoLabel.Location = new Point(6, 38);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(48, 15);
            CorreoLabel.TabIndex = 10;
            CorreoLabel.Text = "Correo:";
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TelefonoLabel.Location = new Point(6, 76);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new Size(59, 15);
            TelefonoLabel.TabIndex = 11;
            TelefonoLabel.Text = "Teléfono:";
            // 
            // DireccionLabel
            // 
            DireccionLabel.AutoSize = true;
            DireccionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DireccionLabel.Location = new Point(6, 113);
            DireccionLabel.Name = "DireccionLabel";
            DireccionLabel.Size = new Size(63, 15);
            DireccionLabel.TabIndex = 12;
            DireccionLabel.Text = "Dirección:";
            // 
            // ModificarPropietario
            // 
            ModificarPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ModificarPropietario.Location = new Point(434, 326);
            ModificarPropietario.Name = "ModificarPropietario";
            ModificarPropietario.Size = new Size(137, 53);
            ModificarPropietario.TabIndex = 13;
            ModificarPropietario.Text = "Modificar Propietario";
            ModificarPropietario.UseVisualStyleBackColor = true;
            ModificarPropietario.Click += ModificarPropietario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NombresLabel);
            groupBox1.Controls.Add(DNILabel);
            groupBox1.Controls.Add(ApellidosLabel);
            groupBox1.Controls.Add(DNITextBox);
            groupBox1.Controls.Add(NombresTextBox);
            groupBox1.Controls.Add(ApellidosTextBox);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(38, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 156);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CorreoLabel);
            groupBox2.Controls.Add(TelefonoLabel);
            groupBox2.Controls.Add(DireccionLabel);
            groupBox2.Controls.Add(CorreoTextBox);
            groupBox2.Controls.Add(TelefonoTextBox);
            groupBox2.Controls.Add(DireccionTextBox);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(38, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 177);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Contacto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UserIcon;
            pictureBox1.Location = new Point(391, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.RetrocerderIcon;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmPropietario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(611, 413);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ModificarPropietario);
            Controls.Add(GuardarPropietario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPropietario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Propietarios";
            FormClosing += frmPropietario_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button GuardarPropietario;
        private TextBox ApellidosTextBox;
        private TextBox TelefonoTextBox;
        private TextBox DNITextBox;
        private TextBox NombresTextBox;
        private TextBox CorreoTextBox;
        private TextBox DireccionTextBox;
        private Label NombresLabel;
        private Label ApellidosLabel;
        private Label DNILabel;
        private Label CorreoLabel;
        private Label TelefonoLabel;
        private Label DireccionLabel;
        private Button ModificarPropietario;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}