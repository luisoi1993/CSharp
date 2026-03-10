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

namespace Primera_Interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*

            Grid grid = new Grid();

            this.Content = grid;

            Button button = new Button();

            button.Width = 200;

            button.Height = 200;

            button.Background = Brushes.Blue;

            WrapPanel wrapPanel = new WrapPanel();
            
            TextBlock textBlock = new TextBlock();

            textBlock.Text = "Hola Mundo";
            textBlock.Background = Brushes.Red;
            textBlock.Foreground = Brushes.Yellow;


            wrapPanel.Children.Add(textBlock);

            TextBlock textBlock2 = new TextBlock();

            textBlock2.Text = "Oi";

            wrapPanel.Children.Add(textBlock2);

            TextBlock textBlock3 = new TextBlock();

            textBlock3.Text = "Sharp";

            wrapPanel.Children.Add(textBlock3);

            button.Content = wrapPanel;

            grid.Children.Add(button);

            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Hola Mundo");

            Console.WriteLine("Le has dado al boton 2");
        }

       /* private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al panel");
        } */

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al panel");
        }
    }
}