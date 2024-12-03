using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.App_code
{
    class Conexion
    {
        SqlConnection con = new SqlConnection();

        public SqlConnection Con { get { return con; } set { con = value; }
        }
        public Conexion()
        {
            this.con.ConnectionString = "Data Source = DESKTOP-HGJTC01\\SQLEXPRESS; Initial Catalog=BD_UCT;Integrated Security=True";

        }
        public void conectar()
        {
            try
            {
                this.con.Open();
                MessageBox.Show("Se ha conectado XD!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar!!\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado!!\n" + ex.Message);
            }
        }

        //Método que permite realizar la desconexión a la base de datos
        public void desconectar()
        {
            this.con.Close();
            MessageBox.Show("Se ha desconectado :D!!");
        }
    }
}
