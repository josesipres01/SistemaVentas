using CapaNegocio;
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
using CapaDatos;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        string password;
        string usuario;
        public Login()
        {
            InitializeComponent();
        }

        public void btnLoginNow_Click(object sender, EventArgs e)
        {
            usuario = txtusuario.Text.Trim();
            password = txtcontrasena.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Conexión.Conn))
                {
                    con.Open();
                    string queryLogin = @"
                SELECT e.nombre, e.apellidos 
                FROM usuario u
                INNER JOIN empleado e ON u.idempleado = e.idempleado
                WHERE u.usuario = @user AND u.pass = @pass AND u.estado = 'Activo'"; // Validamos que esté Activo

                    SqlCommand cmdLogin = new SqlCommand(queryLogin, con);
                    cmdLogin.Parameters.AddWithValue("@user", usuario);
                    cmdLogin.Parameters.AddWithValue("@pass", password);

                    SqlDataReader reader = cmdLogin.ExecuteReader();

                    if (reader.Read()) // Si el usuario y contraseña son correctos
                    {
                        // Extraemos los datos para el Label de FrmInicio
                        string nombreRecuperado = reader["nombre"].ToString();
                        string apellidoRecuperado = reader["apellidos"].ToString();

                        reader.Close(); // Cerramos el reader para poder ejecutar la otra consulta

                       
                        // CREAMOS EL FRMINICIO Y LE PASAMOS LOS DATOS
                        FrmInicio inicio = new FrmInicio(nombreRecuperado, apellidoRecuperado);
                        inicio.Show();

                        // Ocultamos el Login actual
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Usuario o contraseña incorrectos (o usuario inactivo).", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcontrasena.Clear();
                        txtusuario.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
