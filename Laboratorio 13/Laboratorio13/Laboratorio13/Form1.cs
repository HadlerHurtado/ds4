using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        // ✅ 1. Declarar la variable de conexión en la clase Form1
        string connectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=master;TrustServerCertificate=true;Integrated Security=SSPI;";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar código de inicialización si lo necesitas
        }

        // ✅ 2. Agregar el código de conexión en el evento Click del botón
        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarProductos();

        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    // Consulta SQL
                    string query = "SELECT ProductName FROM [dbo].[Products]";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader lector = comando.ExecuteReader();

                    // Limpiar el ListBox antes de cargar
                    listBox1.Items.Clear();

                    while (lector.Read())
                    {
                        // Agregar cada producto al ListBox
                        listBox1.Items.Add(lector["ProductName"].ToString());
                    }

                    lector.Close();
                    conexion.Close();

                    MessageBox.Show("✅ Productos cargados correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar productos: " + ex.Message);
            }
        }
    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

