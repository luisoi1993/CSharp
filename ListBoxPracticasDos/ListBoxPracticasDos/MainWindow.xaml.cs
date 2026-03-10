using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ListBoxPractica
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17 });
            listaPob.Add(new Poblaciones { Poblacion1 = "Sevilla", Poblacion2 = "Badalona", Temperatura1 = 10, Temperatura2 = 19 });
            listaPob.Add(new Poblaciones { Poblacion1 = "Segovia", Poblacion2 = "Valladolid", Temperatura1 = 11, Temperatura2 = 17 });
            listaPob.Add(new Poblaciones { Poblacion1 = "Burgos", Poblacion2 = "Aranjuez", Temperatura1 = 15, Temperatura2 = 17 });

            listaPoblaciones.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ninguna");
            }
            else
            {
                Poblaciones p = (Poblaciones)listaPoblaciones.SelectedItem;

                MessageBox.Show($"{p.Poblacion1} {p.Temperatura1}ºC  |  {p.Poblacion2} {p.Temperatura2}ºC");
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = sender as TextBlock;

            Poblaciones p = tb.DataContext as Poblaciones;

            MessageBox.Show($"{p.Poblacion1} {p.Temperatura1}ºC  |  {p.Poblacion2} {p.Temperatura2}ºC");
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public double Diferencia
        {
            get { return Math.Abs(Temperatura1 - Temperatura2); }
        }
    }
}