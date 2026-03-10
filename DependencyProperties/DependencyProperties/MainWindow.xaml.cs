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

namespace DependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int MiProperty
        {
            get { return (int)GetValue(miDependencyProperty); }

            set { SetValue(miDependencyProperty, value); }
        }

        public static readonly DependencyProperty miDependencyProperty =
            DependencyProperty.Register("MiProperty",typeof(int),typeof(MainWindow),new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();

           
        }
    }
}