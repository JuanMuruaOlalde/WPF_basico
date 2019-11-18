using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPlantillaWPF
{
    public class MainViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        private string _mensajeEnLaBarraDeEstado;
        public string mensajeEnLaBarraDeEstado
        {
            get { return _mensajeEnLaBarraDeEstado; }
            set
            {
                _mensajeEnLaBarraDeEstado = value;
                NotificarQueAlgoHaCambiadoEn("mensajeEnLaBarraDeEstado");
            }
        }

        private string _textoDePrueba1;
        public string textoDePrueba1
        {
            get { return _textoDePrueba1; }
            set
            {
                _textoDePrueba1 = value;
                NotificarQueAlgoHaCambiadoEn("textoDePrueba1");

                mensajeEnLaBarraDeEstado = "Has tecleado '" + textoDePrueba1 + "' en la prueba 1.";
            }
        }

        private string _textoDePrueba2;
        public string textoDePrueba2
        {
            get { return _textoDePrueba2; }
            set
            {
                _textoDePrueba2 = value;
                NotificarQueAlgoHaCambiadoEn("textoDePrueba2");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotificarQueAlgoHaCambiadoEn(string nombreDeLaPropiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender: this, e: new System.ComponentModel.PropertyChangedEventArgs(nombreDeLaPropiedad));
            }
        }

    }


}
