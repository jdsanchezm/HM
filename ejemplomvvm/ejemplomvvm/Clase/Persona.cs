using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ejemplomvvm.Clase
{
    class Persona : INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }
        private int telefono;
        public int Telefono
        {
            get { return this.telefono; }
            set
            {
                this.telefono = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Telefono"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
