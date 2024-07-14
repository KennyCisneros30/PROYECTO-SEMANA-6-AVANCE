namespace CapaVisual
{
    partial class frmModificarPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarPropietario));
            BuscarDNI = new Button();
            GuardarM = new Button();
            EliminarPropietario = new Button();
            MBuscarTextBox = new TextBox();
            MApellidosTextBox = new TextBox();
            MDNITextBox = new TextBox();
            MDireccionTextBox = new TextBox();
            MNombresTextBox = new TextBox();
            MCorreoTextBox = new TextBox();
            MTelefonoTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // BuscarDNI
            // 
            BuscarDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarDNI.Location = new Point(428, 20);
            BuscarDNI.Name = "BuscarDNI";
            BuscarDNI.Size = new Size(100, 31);
            BuscarDNI.TabIndex = 0;
            BuscarDNI.Text = "Buscar";
            BuscarDNI.UseVisualStyleBackColor = true;
            BuscarDNI.Click += BuscarDNI_Click;
            // 
            // GuardarM
            // 
            GuardarM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GuardarM.Location = new Point(456, 277);
            GuardarM.Name = "GuardarM";
            GuardarM.Size = new Size(137, 55);
            GuardarM.TabIndex = 1;
            GuardarM.Text = "Guardar Modificación";
            GuardarM.UseVisualStyleBackColor = true;
            GuardarM.Click += GuardarM_Click;
            // 
            // EliminarPropietario
            // 
            EliminarPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EliminarPropietario.Location = new Point(456, 369);
            EliminarPropietario.Name = "EliminarPropietario";
            EliminarPropietario.Size = new Size(137, 55);
            EliminarPropietario.TabIndex = 2;
            EliminarPropietario.Text = "Eliminar Propietario";
            EliminarPropietario.UseVisualStyleBackColor = true;
            EliminarPropietario.Click += EliminarPropietario_Click;
            // 
            // MBuscarTextBox
            // 
            MBuscarTextBox.Location = new Point(259, 24);
            MBuscarTextBox.Name = "MBuscarTextBox";
            MBuscarTextBox.Size = new Size(150, 23);
            MBuscarTextBox.TabIndex = 3;
            MBuscarTextBox.KeyPress += MBuscarTextBox_KeyPress;
            // 
            // MApellidosTextBox
            // 
            MApellidosTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MApellidosTextBox.Location = new Point(72, 84);
            MApellidosTextBox.Name = "MApellidosTextBox";
            MApellidosTextBox.Size = new Size(250, 23);
            MApellidosTextBox.TabIndex = 4;
            MApellidosTextBox.KeyPress += MApellidosTextBox_KeyPress;
            // 
            // MDNITextBox
            // 
            MDNITextBox.Enabled = false;
            MDNITextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MDNITextBox.Location = new Point(72, 126);
            MDNITextBox.Name = "MDNITextBox";
            MDNITextBox.ReadOnly = true;
            MDNITextBox.Size = new Size(175, 23);
            MDNITextBox.TabIndex = 5;
            // 
            // MDireccionTextBox
            // 
            MDireccionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MDireccionTextBox.Location = new Point(76, 122);
            MDireccionTextBox.Name = "MDireccionTextBox";
            MDireccionTextBox.Size = new Size(250, 23);
            MDireccionTextBox.TabIndex = 6;
            // 
            // MNombresTextBox
            // 
            MNombresTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MNombresTextBox.Location = new Point(72, 39);
            MNombresTextBox.Name = "MNombresTextBox";
            MNombresTextBox.Size = new Size(250, 23);
            MNombresTextBox.TabIndex = 7;
            MNombresTextBox.KeyPress += MNombresTextBox_KeyPress;
            // 
            // MCorreoTextBox
            // 
            MCorreoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MCorreoTextBox.Location = new Point(76, 36);
            MCorreoTextBox.Name = "MCorreoTextBox";
            MCorreoTextBox.Size = new Size(250, 23);
            MCorreoTextBox.TabIndex = 8;
            MCorreoTextBox.Leave += MCorreoTextBox_Leave;
            // 
            // MTelefonoTextBox
            // 
            MTelefonoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MTelefonoTextBox.Location = new Point(76, 80);
            MTelefonoTextBox.Name = "MTelefonoTextBox";
            MTelefonoTextBox.Size = new Size(175, 23);
            MTelefonoTextBox.TabIndex = 9;
            MTelefonoTextBox.KeyPress += MTelefonoTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 10;
            label1.Text = "Ingresar DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 43);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 12;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 39);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 13;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 83);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 125);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 15;
            label6.Text = "Direccion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 129);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 16;
            label7.Text = "DNI:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MNombresTextBox);
            groupBox1.Controls.Add(MDNITextBox);
            groupBox1.Controls.Add(MApellidosTextBox);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(49, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 171);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(MTelefonoTextBox);
            groupBox2.Controls.Add(MCorreoTextBox);
            groupBox2.Controls.Add(MDireccionTextBox);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(49, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 166);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Contacto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ModificarIcon;
            pictureBox1.Location = new Point(410, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.RetrocerderIcon;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.MenuPrincipalIcon;
            pictureBox3.Location = new Point(633, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // frmModificarPropietario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(686, 452);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(MBuscarTextBox);
            Controls.Add(EliminarPropietario);
            Controls.Add(GuardarM);
            Controls.Add(BuscarDNI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmModificarPropietario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Propietarios";
            FormClosing += frmModificarPropietario_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BuscarDNI;
        private Button GuardarM;
        private Button EliminarPropietario;
        private TextBox MBuscarTextBox;
        private TextBox MApellidosTextBox;
        private TextBox MDNITextBox;
        private TextBox MDireccionTextBox;
        private TextBox MNombresTextBox;
        private TextBox MCorreoTextBox;
        private TextBox MTelefonoTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}