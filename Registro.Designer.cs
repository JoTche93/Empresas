namespace TestLogin
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtDir = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            txtPass = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(56, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 0;
            label1.Text = "Rut:";
            // 
            // txtRut
            // 
            txtRut.BackColor = Color.LightGray;
            txtRut.BorderStyle = BorderStyle.None;
            txtRut.Location = new Point(56, 47);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(257, 22);
            txtRut.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(56, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 22);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(56, 93);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(56, 189);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(257, 22);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(54, 164);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // txtDir
            // 
            txtDir.BackColor = Color.LightGray;
            txtDir.BorderStyle = BorderStyle.None;
            txtDir.Location = new Point(56, 261);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(257, 22);
            txtDir.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(51, 236);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGray;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(54, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 33);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(56, 332);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 22);
            txtPass.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(51, 307);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(1, 36);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(560, 579);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(13, 93);
            label8.Name = "label8";
            label8.Size = new Size(60, 23);
            label8.TabIndex = 28;
            label8.Text = "Volver";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 29);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtRut);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtDir);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(104, 137);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(349, 433);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro Nuevo Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 29);
            label6.Name = "label6";
            label6.Size = new Size(277, 54);
            label6.TabIndex = 24;
            label6.Text = "EMPOWER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, -20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 51);
            panel1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(155, 19);
            label7.TabIndex = 27;
            label7.Text = "Empower Registro";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(463, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 51);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 26;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(511, 0);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 51);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 25;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(561, 612);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Form1";
            Load += Registro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtRut;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtDir;
        private Label label4;
        private Button btnGuardar;
        private TextBox txtPass;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox4;
        private Label label8;
    }
}
