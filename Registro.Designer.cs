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
            pictureBox2 = new PictureBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(13, 108);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 0;
            label1.Text = "Rut:";
            // 
            // txtRut
            // 
            txtRut.BackColor = SystemColors.Window;
            txtRut.Location = new Point(95, 108);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(225, 23);
            txtRut.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 146);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(13, 146);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(95, 188);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 23);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(13, 188);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(93, 232);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(225, 23);
            txtDir.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(11, 232);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(93, 322);
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
            txtPass.Location = new Point(93, 271);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 23);
            txtPass.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(11, 271);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRut);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDir);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 378);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Magneto", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 19);
            label6.Name = "label6";
            label6.Size = new Size(252, 45);
            label6.TabIndex = 24;
            label6.Text = "EMPOWER";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(620, 378);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Registro";
            Text = "Form1";
            Load += Registro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Label label6;
    }
}
