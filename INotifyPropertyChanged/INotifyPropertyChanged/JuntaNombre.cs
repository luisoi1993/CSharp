using System;

namespace Primera_interfaz
{
    public class JuntaNombre : System.ComponentModel.INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string nombre_completo;

        public event System.ComponentModel.PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string property)
        {

            if(PropertyChanged != null) {
                PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
            
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("Nombre_completo");
            }

           
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("Nombre_completo");
            }
        }

        public string Nombre_completo
        {
            get { nombre_completo = Nombre + " " + Apellido;

                return nombre_completo;
            }
            set {  }
        }
    }
}