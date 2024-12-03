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

namespace TestLogin.App_code
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Capturar los datos ingresados por el usuario
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método para actualizar datos
            ActualizarDatos(rut, nombre, apellido, direccion);
        }

        private void ActualizarDatos(string rut, string nombre, string apellido, string direccion)
        {
            // Cadena de conexión (asegúrate de cambiarla por la de tu entorno)
            string connectionString = "Data Source=TU_SERVIDOR;Initial Catalog=TU_BASE_DE_DATOS;Integrated Security=True";

            // Query para actualizar los datos
            string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion WHERE RUT = @RUT";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crear el comando SQL
                    SqlCommand command = new SqlCommand(query, connection);

                    // Agregar los parámetros
                    command.Parameters.AddWithValue("@RUT", rut);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Direccion", direccion);

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un usuario con el RUT ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
