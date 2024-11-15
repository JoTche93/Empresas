using System.Data;
using System.Data.SqlClient;
using TestLogin.App_code;

namespace TestLogin
{
    public partial class Registro : Form
    {
        Conexion scn;
        public Registro()
        {
            InitializeComponent();
            scn = new Conexion();
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
