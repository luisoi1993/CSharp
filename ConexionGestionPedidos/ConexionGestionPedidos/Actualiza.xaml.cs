using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConexionGestionPedidos
{
    
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        SqlConnection miConexionSql;
        private int z;

        public Actualiza(int elId)
        {
            InitializeComponent();
            z = elId;
            ConectarBaseDatos();


            if (miConexionSql != null && miConexionSql.State == ConnectionState.Open)
            {
               
            }
        }

        private void ConectarBaseDatos()
        {
            try
            {
                string connectionString =
                "Data Source=VDI-TUCO46\\IESA_DATOS;Initial Catalog=pruebas;Integrated Security=True;Trust Server Certificate=True;";

                miConexionSql = new SqlConnection(connectionString);

                miConexionSql.Open();

                MessageBox.Show("Conexión correcta con SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión:\n" + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "UPDATE CLIENTE SET nombre=@nombre WHERE Id =" + z;

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);

                miSqlCommand.ExecuteNonQuery();

                // MessageBox.Show("Pedido eliminado correctamente");

                this.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
