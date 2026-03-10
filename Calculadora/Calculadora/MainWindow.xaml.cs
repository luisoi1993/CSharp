using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        double numero1 = 0;
        string operacion = "";
        bool nuevaEntrada = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;

            if (pantalla.Text == "0" || nuevaEntrada)
            {
                pantalla.Text = boton.Content.ToString();
                nuevaEntrada = false;
            }
            else
            {
                pantalla.Text += boton.Content.ToString();
            }
        }

        private void Operacion_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;

            numero1 = double.Parse(pantalla.Text);
            operacion = boton.Content.ToString();
            nuevaEntrada = true;
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            double numero2 = double.Parse(pantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;
            }

            pantalla.Text = resultado.ToString();
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = "0";
            numero1 = 0;
            operacion = "";
        }
    }
}