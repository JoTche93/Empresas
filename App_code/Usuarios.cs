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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TestLogin.App_code
{
    public partial class Usuarios : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;



        Conexion scn;
        DataTable dtUsuario = new DataTable();
        int indice = 0;
        int rut = 0;

        public Usuarios()
        {
            InitializeComponent();
            scn = new Conexion();
            ObtenerListado(-1);
            Barra.MouseDown += new MouseEventHandler(Barra_MouseDown);
        }

        private void ButtonPerfil_Click(object sender, EventArgs e)
        {

        }
        private void ObtenerListado(int rut)
        {
            dtUsuario.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = scn.Con;
                scn.Con.Open();
                SqlDataAdapter usuario = new SqlDataAdapter();
                usuario.SelectCommand = cmd;

                #region Paso 2 Llamada a Procedimiento Almacenado
                cmd.CommandText = "ListarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Paso 3 Entrega de Parametros
                SqlParameter parametro1 = cmd.Parameters.Add("@P_USU_RUT", SqlDbType.Int);
                parametro1.Value = rut; ;
                #endregion

                #region Paso 4 Ejecutar Query
                usuario.Fill(dtUsuario);
                dvDatos.DataSource = dtUsuario;
                #endregion
                scn.Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                DataRow datos = dtUsuario.Rows[indice];

                rut = Convert.ToInt32(datos["USU_RUT"].ToString());
                txtRut.Text = datos["USU_RUT"].ToString() + "-" + datos["USU_DV"].ToString();
                txtNombre.Text = datos["USU_NOMBRE"].ToString();
                txtApellido.Text = datos["USU_APELLIDO"].ToString();
                txtDir.Text = datos["USU_DIRECCION"].ToString();
                txtPass.Text = datos["USU_PASS"].ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                DataRow datos = dtUsuario.Rows[indice];

                rut = Convert.ToInt32(datos["USU_RUT"].ToString());

                Eliminar(rut);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila.");
            }
        }

        private void dvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
        private void Eliminar(int rutUsu)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = scn.Con;
            scn.Con.Open();

            cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            #region Paso 3 Entrega de Parametros
            SqlParameter parametro1 = cmd.Parameters.Add("@P_USU_RUT", SqlDbType.Int);
            parametro1.Value = rutUsu; ;
            #endregion

            cmd.ExecuteNonQuery();

            MessageBox.Show("Eliminado Exitosamente");

            scn.Con.Close();
            rut = 0;
            ObtenerListado(-1);
        }
        private void limpiar()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDir.Clear();
            txtPass.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rut > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    string[] rut2 = txtRut.Text.Split('-');

                    cmd.Connection = scn.Con;
                    scn.Con.Open();

                    cmd.CommandText = "EditarUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter parametro1 = cmd.Parameters.Add("@P_USU_RUT", SqlDbType.Int);
                    parametro1.Value = int.Parse(rut2[0]);

                    SqlParameter parametro2 = cmd.Parameters.Add("@P_USU_DV", SqlDbType.VarChar);
                    parametro2.Value = rut2[1];

                    SqlParameter parametro3 = cmd.Parameters.Add("@P_USU_NOMBRE", SqlDbType.VarChar);
                    parametro3.Value = txtNombre.Text;

                    SqlParameter parametro4 = cmd.Parameters.Add("@P_USU_APELLIDO", SqlDbType.VarChar);
                    parametro4.Value = txtApellido.Text;

                    SqlParameter parametro5 = cmd.Parameters.Add("@P_USU_DIRECCION", SqlDbType.VarChar);
                    parametro5.Value = txtDir.Text;

                    SqlParameter parametro6 = cmd.Parameters.Add("@P_USU_PASS", SqlDbType.VarChar);
                    parametro6.Value = txtPass.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Modificado Exitosamente");

                    scn.Con.Close();
                    rut = 0;
                    limpiar();
                    ObtenerListado(-1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
