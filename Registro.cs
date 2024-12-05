using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using TestLogin.App_code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TestLogin
{
    public partial class Registro : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        Conexion scn;
        public Registro()
        {
            InitializeComponent();
            scn = new Conexion();
            Barra.MouseDown += new MouseEventHandler(Barra_MouseDown);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string[] rut = txtRut.Text.Split('-');

                cmd.Connection = scn.Con;
                scn.Con.Open();

                cmd.CommandText = "RegistroUsuario";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro1 = cmd.Parameters.Add("@P_USU_RUT", SqlDbType.Int);
                parametro1.Value = int.Parse(rut[0]);

                SqlParameter parametro2 = cmd.Parameters.Add("@P_USU_DV", SqlDbType.VarChar);
                parametro2.Value = rut[1];

                SqlParameter parametro3 = cmd.Parameters.Add("@P_USU_NOMBRE", SqlDbType.VarChar);
                parametro3.Value = txtNombre.Text;

                SqlParameter parametro4 = cmd.Parameters.Add("@P_USU_APELLIDO", SqlDbType.VarChar);
                parametro4.Value = txtApellido.Text;

                SqlParameter parametro5 = cmd.Parameters.Add("@P_USU_DIRECCION", SqlDbType.VarChar);
                parametro5.Value = txtDir.Text;

                SqlParameter parametro6 = cmd.Parameters.Add("@P_USU_PASS", SqlDbType.VarChar);
                parametro6.Value = txtPass.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Agregado Exitosamente");

                scn.Con.Close();

                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login Logear = new Login();
            Logear.Show();
            this.Hide();
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
