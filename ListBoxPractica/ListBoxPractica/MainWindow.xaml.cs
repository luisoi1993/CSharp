using System;
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
using System.Collections.Generic;

namespace ListBoxPractica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones() { Poblacion1 ="Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Badalona", Temperatura1 = 10, Temperatura2 = 19 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Segovia", Poblacion2 = "Valladolid", Temperatura1 = 11, Temperatura2 = 17 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Burgos", Poblacion2 = "Aranjuez", Temperatura1 = 15, Temperatura2 = 17 });

            listaPoblaciones.ItemsSource = listaPob;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // si no hay nada seleccionado que no pete el programa

            if(listaPoblaciones.SelectedItem  == null)
            {
                MessageBox.Show("No has seleccionado ninguna: ");

            }else
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC");
            }
                
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;

            Poblaciones pob = tb.DataContext as Poblaciones;

            MessageBox.Show(pob.Poblacion1 + " " +
                            pob.Temperatura1 + " ºC " +
                            pob.Poblacion2 + " " +
                            pob.Temperatura2 + " ºC");
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int Diferencia
        {
            get { return Math.Abs(Temperatura1 - Temperatura2); }

        }
    }
}