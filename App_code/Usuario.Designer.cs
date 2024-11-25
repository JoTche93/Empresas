namespace TestLogin.App_code
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            Barra = new Panel();
            label7 = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            txtDir = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtPass = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Barra
            // 
            Barra.BackColor = Color.Teal;
            Barra.Controls.Add(label7);
            Barra.Controls.Add(btnMinimizar);
            Barra.Controls.Add(btnCerrar);
            Barra.Location = new Point(0, 0);
            Barra.Name = "Barra";
            Barra.Size = new Size(763, 38);
            Barra.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(125, 16);
            label7.TabIndex = 27;
            label7.Text = "Empower Usuarios";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(678, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 38);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 26;
            btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(720, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 38);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 25;
            btnCerrar.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(217, 44);
            label6.Name = "label6";
            label6.Size = new Size(222, 42);
            label6.TabIndex = 28;
            label6.Text = "EMPOWER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 229);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Elige una opción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(4, 129);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDir);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtApellido);
            panel1.Location = new Point(305, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 294);
            panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(0, 58);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 32;
            label5.Text = "Cerrar Sesión";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(673, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(87, 78);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 40);
            button1.Name = "button1";
            button1.Size = new Size(229, 48);
            button1.TabIndex = 34;
            button1.Text = "1. Ver/Editar Perfil.";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(6, 94);
            button2.Name = "button2";
            button2.Size = new Size(229, 48);
            button2.TabIndex = 35;
            button2.Text = "2. Historial de Actividades.";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 148);
            button3.Name = "button3";
            button3.Size = new Size(229, 48);
            button3.TabIndex = 36;
            button3.Text = "3. Configuración de Cuenta.";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGray;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(128, 248);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 25);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Actualizar Perfil";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(130, 40);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 13;
            label3.Text = "Nombre:";
            // 
            // txtDir
            // 
            txtDir.BackColor = Color.LightGray;
            txtDir.BorderStyle = BorderStyle.None;
            txtDir.Location = new Point(130, 166);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(225, 16);
            txtDir.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(130, 59);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 16);
            txtNombre.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(126, 147);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 17;
            label8.Text = "Dirección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(128, 93);
            label9.Name = "label9";
            label9.Size = new Size(64, 17);
            label9.TabIndex = 15;
            label9.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(130, 112);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 16);
            txtApellido.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(126, 200);
            label2.Name = "label2";
            label2.Size = new Size(145, 17);
            label2.TabIndex = 20;
            label2.Text = "Información Adicional";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(130, 219);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 16);
            txtPass.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 22;
            label1.Text = "Perfil";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(760, 428);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(Barra);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuario";
            Text = "Form1";
            Load += this.Usuario_Load;
            Barra.ResumeLayout(false);
            Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Barra;
        private Label label7;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Label label6;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label5;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnGuardar;
        private Label label3;
        private TextBox txtDir;
        private TextBox txtNombre;
        private Label label8;
        private Label label9;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtPass;
        private Label label2;
        private PictureBox pictureBox3;
    }
}