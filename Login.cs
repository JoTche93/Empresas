using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using TestLogin.App_code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TestLogin
{
    public partial class Login : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        

        Conexion scn;
        public Login()
        {
            InitializeComponent();
            scn = new Conexion();
            Barra.MouseDown += new MouseEventHandler(Barra_MouseDown);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = null;
            string[] rut = txtRut.Text.Split('-');

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = scn.Con;
                scn.Con.Open();
                SqlDataAdapter usuario = new SqlDataAdapter();
                usuario.SelectCommand = cmd;
                #region Paso 2 Llamada a Procedimiento Almacenado
                cmd.CommandText = "LoginUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion


                #region Paso 3 Entrega de Parametros
                SqlParameter parametro1 = cmd.Parameters.Add("@P_USU_RUT", SqlDbType.Int);
                parametro1.Value = int.Parse(rut[0]);
                SqlParameter parametro2 = cmd.Parameters.Add("@P_USU_PASS", SqlDbType.VarChar);
                parametro2.Value = txtPass.Text;

                #endregion
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    Administracion administracion = new Administracion();
                    administracion.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos, ingreselos nuevamente");
                    txtRut.Clear();
                    txtPass.Clear();
                }

                scn.Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registro registrar = new Registro();
            registrar.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
