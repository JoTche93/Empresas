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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvDatos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(109, 259);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 16);
            txtPass.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(23, 259);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 20;
            label5.Text = "Contraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGray;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(23, 302);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 29);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDir
            // 
            txtDir.BackColor = Color.LightGray;
            txtDir.BorderStyle = BorderStyle.None;
            txtDir.Location = new Point(109, 219);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(225, 16);
            txtDir.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(23, 217);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 17;
            label4.Text = "Dirección:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(111, 176);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 16);
            txtApellido.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(23, 176);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 15;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(111, 134);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 16);
            txtNombre.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(23, 134);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // txtRut
            // 
            txtRut.BackColor = Color.LightGray;
            txtRut.BorderStyle = BorderStyle.None;
            txtRut.Enabled = false;
            txtRut.Location = new Point(111, 96);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(225, 16);
            txtRut.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(23, 95);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 11;
            label1.Text = "Rut:";
            // 
            // dvDatos
            // 
            dvDatos.AllowUserToOrderColumns = true;
            dvDatos.BackgroundColor = Color.LightGray;
            dvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvDatos.Location = new Point(380, 42);
            dvDatos.Margin = new Padding(3, 2, 3, 2);
            dvDatos.Name = "dvDatos";
            dvDatos.RowHeadersWidth = 51;
            dvDatos.Size = new Size(740, 235);
            dvDatos.TabIndex = 22;
            dvDatos.CellClick += dvDatos_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightGray;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(30, 41);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 29);
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
            btnEliminar.Location = new Point(133, 41);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 29);
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
            groupBox1.Location = new Point(2, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 336);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Magneto", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 19);
            label6.Name = "label6";
            label6.Size = new Size(252, 45);
            label6.TabIndex = 22;
            label6.Text = "EMPOWER";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSlateGray;
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Location = new Point(380, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(740, 96);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 38);
            panel1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(166, 16);
            label7.TabIndex = 27;
            label7.Text = "Empower Administración";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1039, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1081, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1123, 386);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dvDatos);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Administracion";
            Text = "Administracion";
            ((System.ComponentModel.ISupportInitialize)dvDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}