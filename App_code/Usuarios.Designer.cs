namespace TestLogin.App_code
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            Barra = new Panel();
            label7 = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            CerrarSesion = new PictureBox();
            a = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            panel3 = new Panel();
            btnGuardar = new Button();
            panel2 = new Panel();
            btnEditar = new Button();
            dvDatos = new DataGridView();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            txtRut = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtPass = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label8 = new Label();
            txtDir = new TextBox();
            Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CerrarSesion).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Barra
            // 
            Barra.BackColor = Color.Teal;
            Barra.Controls.Add(label7);
            Barra.Controls.Add(btnMinimizar);
            Barra.Controls.Add(btnCerrar);
            Barra.Location = new Point(0, 0);
            Barra.Margin = new Padding(3, 4, 3, 4);
            Barra.Name = "Barra";
            Barra.Size = new Size(1303, 51);
            Barra.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(0, 19);
            label7.TabIndex = 27;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1206, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 51);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 26;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click_1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1258, 0);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 51);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 25;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 74);
            label6.Name = "label6";
            label6.Size = new Size(277, 54);
            label6.TabIndex = 28;
            label6.Text = "EMPOWER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 26);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // CerrarSesion
            // 
            CerrarSesion.Image = (Image)resources.GetObject("CerrarSesion.Image");
            CerrarSesion.Location = new Point(33, 15);
            CerrarSesion.Margin = new Padding(3, 4, 3, 4);
            CerrarSesion.Name = "CerrarSesion";
            CerrarSesion.Size = new Size(47, 69);
            CerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            CerrarSesion.TabIndex = 32;
            CerrarSesion.TabStop = false;
            CerrarSesion.Click += CerrarSesion_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            a.Location = new Point(0, 88);
            a.Name = "a";
            a.Size = new Size(116, 23);
            a.TabIndex = 33;
            a.Text = "Cerrar Sesión";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(a);
            groupBox1.Controls.Add(CerrarSesion);
            groupBox1.Location = new Point(1174, 59);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(116, 128);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(dvDatos);
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(440, 195);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(850, 303);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGuardar);
            panel3.Location = new Point(128, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 69);
            panel3.TabIndex = 39;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.Location = new Point(0, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 69);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditar);
            panel2.Location = new Point(0, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 69);
            panel2.TabIndex = 38;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Location = new Point(0, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 69);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dvDatos
            // 
            dvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvDatos.Location = new Point(7, 84);
            dvDatos.Margin = new Padding(3, 4, 3, 4);
            dvDatos.Name = "dvDatos";
            dvDatos.RowHeadersWidth = 51;
            dvDatos.Size = new Size(837, 59);
            dvDatos.TabIndex = 32;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(65, 20);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(7, 33);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 0;
            label4.Text = "Perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(647, 93);
            label5.Name = "label5";
            label5.Size = new Size(251, 50);
            label5.TabIndex = 36;
            label5.Text = "Bienvenido";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtRut);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDir);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 513);
            panel1.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(12, 147);
            label9.Name = "label9";
            label9.Size = new Size(43, 23);
            label9.TabIndex = 37;
            label9.Text = "Rut:";
            // 
            // txtRut
            // 
            txtRut.BackColor = Color.LightGray;
            txtRut.BorderStyle = BorderStyle.None;
            txtRut.Enabled = false;
            txtRut.Location = new Point(107, 148);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(257, 20);
            txtRut.TabIndex = 38;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(109, 247);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(257, 20);
            txtApellido.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(8, 191);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 29;
            label2.Text = "Nombre:";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(107, 357);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 20);
            txtPass.TabIndex = 36;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(109, 191);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 20);
            txtNombre.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(8, 357);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 35;
            label1.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(8, 247);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 31;
            label3.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(8, 301);
            label8.Name = "label8";
            label8.Size = new Size(90, 23);
            label8.TabIndex = 33;
            label8.Text = "Dirección:";
            // 
            // txtDir
            // 
            txtDir.BackColor = Color.LightGray;
            txtDir.BorderStyle = BorderStyle.None;
            txtDir.Location = new Point(107, 304);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(257, 20);
            txtDir.TabIndex = 34;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1302, 513);
            Controls.Add(Barra);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Usuarios";
            Text = "Form1";
            Barra.ResumeLayout(false);
            Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CerrarSesion).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PictureBox CerrarSesion;
        private Label a;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dvDatos;
        private PictureBox pictureBox5;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button btnEditar;
        private Panel panel2;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtPass;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private Label label8;
        private TextBox txtDir;
        private Panel panel3;
        private Button btnGuardar;
        private Label label9;
        private TextBox txtRut;
    }
}