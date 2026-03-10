using Primera_interfaz;
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

namespace INotifyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            JuntaNombreYApellido = new JuntaNombre { Nombre = "Juan", Apellido = "Perez" };

            this.DataContext = JuntaNombreYApellido;
        }

        public JuntaNombre JuntaNombreYApellido;
    }
}