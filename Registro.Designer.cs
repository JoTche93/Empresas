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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Rut:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(117, 46);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(225, 23);
            txtRut.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 84);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(117, 126);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 23);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 126);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(115, 170);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(225, 23);
            txtDir.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 170);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(115, 260);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(115, 209);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 23);
            txtPass.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 209);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 399);
            Controls.Add(txtPass);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(txtDir);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtRut);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Registro";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
