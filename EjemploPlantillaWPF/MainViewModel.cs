﻿using System.ComponentModel;

namespace EjemploPlantillaWPF
{
    public class MainViewModel : System.ComponentModel.INotifyPropertyChanged
    {

        public MainViewModel()
        {
            estaSeleccionadaLaOpcion1 = true;
            estaSeleccionadaLaOpcion2 = false;
            estaSeleccionadaLaOpcion3 = false;
        }


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
                mensajeEnLaBarraDeEstado = Resources.mensajes.TextoTecleadoEnLaPrueba1 + " '" + textoDePrueba1 
                                           + "' ::  " 
                                           + Resources.mensajes.TextoTecleadoEnLaPrueba2 + " '" + textoDePrueba2
                                           + ".";
        }


        private bool? _estaSeleccionadaLaOpcion1;
        public bool? estaSeleccionadaLaOpcion1
        {
            get { return _estaSeleccionadaLaOpcion1; }
            set
            {
                _estaSeleccionadaLaOpcion1 = value;
                NotificarQueAlgoHaCambiadoEn("estaSeleccionadaLaOpcion1");
            }
        }
        private bool? _estaSeleccionadaLaOpcion2;
        public bool? estaSeleccionadaLaOpcion2
        {
            get { return _estaSeleccionadaLaOpcion2; }
            set
            {
                _estaSeleccionadaLaOpcion2 = value;
                NotificarQueAlgoHaCambiadoEn("estaSeleccionadaLaOpcion2");
            }
        }
        private bool? _estaSeleccionadaLaOpcion3;
        public bool? estaSeleccionadaLaOpcion3
        {
            get { return _estaSeleccionadaLaOpcion3; }
            set
            {
                _estaSeleccionadaLaOpcion3 = value;
                NotificarQueAlgoHaCambiadoEn("estaSeleccionadaLaOpcion3");
            }
        }


        private System.Windows.Input.ICommand _MostrarVentanaDeAyuda;
        public System.Windows.Input.ICommand MostrarVentanaDeAyuda
        {
            get { return _MostrarVentanaDeAyuda ?? (_MostrarVentanaDeAyuda = new comandoWPF(() => Accion_MostrarVentanaDeAyuda())); }
        }
        private void Accion_MostrarVentanaDeAyuda()
        {
            AyudaWindow ventana = new AyudaWindow();
            ventana.DataContext = new AyudaViewModel(uriInicial: AyudaViewModel.URI_INICIAL_DE_LA_AYUDA);
            ventana.Show();
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
