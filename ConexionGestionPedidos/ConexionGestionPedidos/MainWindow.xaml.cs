using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows;

namespace ConexionGestionPedidos
{
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();

            ConectarBaseDatos();

            if (miConexionSql != null && miConexionSql.State == ConnectionState.Open)
            {
                MostrarClientes();
                MuestraTodosPedidos();
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

        private void MostrarClientes()
        {
            try
            {
                string consulta = "SELECT * FROM Cliente";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, miConexionSql);

                DataTable tablaClientes = new DataTable();

                adaptador.Fill(tablaClientes);

                listaClientes.DisplayMemberPath = "nombre";
                listaClientes.SelectedValuePath = "Id";
                listaClientes.ItemsSource = tablaClientes.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes:\n" + ex.Message);
            }
        }

       /* private void listaClientes_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");

            MuestraPedidos();
        } */

        private void MuestraPedidos()
        {
            try
            {
                string consulta = "SELECT * FROM Pedido P INNER JOIN Cliente C ON C.ID = P.cCliente WHERE C.ID=@ClienteId";

                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlComando);

                DataTable pedidosTabla = new DataTable();

                adaptador.Fill(pedidosTabla);

                pedidosCliente.DisplayMemberPath = "fechaPedido";
                pedidosCliente.SelectedValuePath = "Id";
                pedidosCliente.ItemsSource = pedidosTabla.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos:\n" + ex.Message);
            }
        }


        private void MuestraTodosPedidos()
        {
            string consulta = "SELECT * , CONCAT(CCLIENTE, ' ', fechaPedido, ' ', formaPago) AS INFOCOMPLETA FROM PEDIDO";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            DataTable pedidosTabla = new DataTable();

            miAdaptadorSql.Fill(pedidosTabla);

            todosPedidos.DisplayMemberPath = "INFOCOMPLETA";
            todosPedidos.SelectedValuePath = "Id";
            todosPedidos.ItemsSource = pedidosTabla.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM PEDIDO WHERE ID=@PEDIDOID";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);

                miSqlCommand.ExecuteNonQuery();

               // MessageBox.Show("Pedido eliminado correctamente");

                MuestraTodosPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);

                miSqlCommand.ExecuteNonQuery();

                // MessageBox.Show("Pedido eliminado correctamente");

                MostrarClientes();
                insertaCliente.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM CLIENTE WHERE ID=@CLIENTEID";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miSqlCommand.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);

                miSqlCommand.ExecuteNonQuery();

                // MessageBox.Show("Pedido eliminado correctamente");

                MostrarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listaClientes_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

      
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)listaClientes.SelectedValue);

           

            try
            {
                string consulta = "SELECT nombre FROM Cliente WHERE ID=@ClId";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlCommand);

                miSqlCommand.Parameters.AddWithValue("@ClId", listaClientes.SelectedValue);

                DataTable clientesTabla = new DataTable();

                miAdaptadorSql.Fill(clientesTabla);

                ventanaActualizar.cuadroActualiza.Text = clientesTabla.Rows[0]["nombre"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes:\n" + ex.Message);
            }

            ventanaActualizar.ShowDialog();

            MostrarClientes();
        }
    }
}