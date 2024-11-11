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
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dvDatos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(115, 228);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 23);
            txtPass.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 228);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 20;
            label5.Text = "Contraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 271);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(115, 189);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(225, 23);
            txtDir.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 189);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Dirección";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(117, 145);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 23);
            txtApellido.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 145);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 15;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 103);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 103);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // txtRut
            // 
            txtRut.Enabled = false;
            txtRut.Location = new Point(117, 65);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(225, 23);
            txtRut.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 11;
            label1.Text = "Rut:";
            // 
            // dvDatos
            // 
            dvDatos.AllowUserToOrderColumns = true;
            dvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvDatos.Location = new Point(382, 1);
            dvDatos.Margin = new Padding(3, 2, 3, 2);
            dvDatos.Name = "dvDatos";
            dvDatos.RowHeadersWidth = 51;
            dvDatos.Size = new Size(740, 235);
            dvDatos.TabIndex = 22;
            dvDatos.CellClick += dvDatos_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(6, 46);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(102, 46);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkOrange;
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
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 336);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Location = new Point(382, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(740, 100);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1123, 338);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dvDatos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Administracion";
            Text = "Administracion";
            ((System.ComponentModel.ISupportInitialize)dvDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
    }
}