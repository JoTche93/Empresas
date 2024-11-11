using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLogin.App_code;

namespace TestLogin
{
    public partial class Login : Form
    {
        Conexion scn;
        public Login()
        {
            InitializeComponent();
            scn = new Conexion();
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
            Registro registrar = new Registro();
            registrar.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
