namespace TestLogin
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            txtPass = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            txtDir = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtRut = new TextBox();
            label1 = new Label();
            dvDatos = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label7 = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvDatos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(125, 345);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 20);
            txtPass.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(26, 345);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 20;
            label5.Text = "Contraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGray;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(26, 403);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 39);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDir
            // 
            txtDir.BackColor = Color.LightGray;
            txtDir.BorderStyle = BorderStyle.None;
            txtDir.Location = new Point(125, 292);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(257, 20);
            txtDir.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(26, 289);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 17;
            label4.Text = "Dirección:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(127, 235);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(257, 20);
            txtApellido.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(26, 235);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 15;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(127, 179);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 20);
            txtNombre.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(26, 179);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // txtRut
            // 
            txtRut.BackColor = Color.LightGray;
            txtRut.BorderStyle = BorderStyle.None;
            txtRut.Enabled = false;
            txtRut.Location = new Point(127, 128);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(257, 20);
            txtRut.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(26, 127);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 11;
            label1.Text = "Rut:";
            // 
            // dvDatos
            // 
            dvDatos.AllowUserToOrderColumns = true;
            dvDatos.BackgroundColor = Color.LightGray;
            dvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvDatos.Location = new Point(434, 56);
            dvDatos.Name = "dvDatos";
            dvDatos.RowHeadersWidth = 51;
            dvDatos.Size = new Size(846, 313);
            dvDatos.TabIndex = 22;
            dvDatos.CellClick += dvDatos_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightGray;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(34, 55);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 39);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightGray;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(152, 55);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 39);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkCyan;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRut);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDir);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(-1, 56);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(429, 448);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 25);
            label6.Name = "label6";
            label6.Size = new Size(277, 54);
            label6.TabIndex = 22;
            label6.Text = "EMPOWER";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSlateGray;
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Location = new Point(434, 376);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(846, 128);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 51);
            panel1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(204, 19);
            label7.TabIndex = 27;
            label7.Text = "Empower Administración";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1187, 4);
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
            btnCerrar.Location = new Point(1235, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 51);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 25;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1283, 515);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dvDatos);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Administracion";
            Text = "Administracion";
            ((System.ComponentModel.ISupportInitialize)dvDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPass;
        private Label label5;
        private Button btnGuardar;
        private TextBox txtDir;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRut;
        private Label label1;
        private DataGridView dvDatos;
        private Button btnEditar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label7;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
    }
}