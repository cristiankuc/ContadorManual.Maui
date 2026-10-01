using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContadorManualMaui.maui.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;
        private int _incremeto;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }
        public int Incremento
        {
            get => (_incremeto);
            set
            {
                if (_incremeto  != value)
                
                    { 
                    _incremeto = value;
                    } 
            }
        }
        public Contador()
        {
            Conteo = 0;
            Incremento = 1;
        }
        public void Contar()
        {
            Conteo +=Incremento;
        }
        public void Reiniciar()
        {
            Conteo = 0;
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, 
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }

   
}
