﻿namespace TestLogin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtRut = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnAceptar = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            Barra = new Panel();
            label5 = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // txtRut
            // 
            txtRut.BackColor = Color.LightGray;
            txtRut.BorderStyle = BorderStyle.None;
            txtRut.Location = new Point(121, 178);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.RightToLeft = RightToLeft.No;
            txtRut.Size = new Size(180, 16);
            txtRut.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(121, 232);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(180, 16);
            txtPass.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 209);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 6;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 155);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 5;
            label1.Text = "Rut:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(157, 98);
            label3.Name = "label3";
            label3.Size = new Size(111, 45);
            label3.TabIndex = 7;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LightGray;
            btnAceptar.FlatAppearance.BorderColor = Color.White;
            btnAceptar.FlatAppearance.BorderSize = 10;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(173, 267);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 27);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 53);
            label6.Name = "label6";
            label6.Size = new Size(222, 42);
            label6.TabIndex = 23;
            label6.Text = "EMPOWER";
            // 
            // Barra
            // 
            Barra.BackColor = Color.Teal;
            Barra.Controls.Add(label5);
            Barra.Controls.Add(btnMinimizar);
            Barra.Controls.Add(btnCerrar);
            Barra.Location = new Point(0, 0);
            Barra.Name = "Barra";
            Barra.Size = new Size(429, 38);
            Barra.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 27;
            label5.Text = "Empower";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(344, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 38);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 26;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(386, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 38);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 25;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 312);
            label4.Name = "label4";
            label4.Size = new Size(161, 16);
            label4.TabIndex = 25;
            label4.Text = "¿Registrar Nuevo Usuario?";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(75, 155);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(75, 209);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(425, 349);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(Barra);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtRut);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Opacity = 0.9D;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Barra.ResumeLayout(false);
            Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRut;
        private TextBox txtPass;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnAceptar;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel Barra;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label5;
    }
}