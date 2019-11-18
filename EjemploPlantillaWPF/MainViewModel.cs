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


        private System.Windows.Input.ICommand _ProcesarLosTextosTecleados;
        public System.Windows.Input.ICommand ProcesarLosTextosTecleados
        {
            get { return _ProcesarLosTextosTecleados ?? (_ProcesarLosTextosTecleados = new comandoWPF(() => Accion_ProcesarLosTextosTecleados())); }
        }
        private void Accion_ProcesarLosTextosTecleados()
        {
                mensajeEnLaBarraDeEstado = "Has tecleado '" + textoDePrueba1 + "' en la prueba 1 y '" + textoDePrueba2 + "' en la prueba 2.";
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
