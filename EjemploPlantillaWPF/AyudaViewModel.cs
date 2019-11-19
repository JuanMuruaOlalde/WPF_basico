using System.ComponentModel;

namespace EjemploPlantillaWPF
{
    public class AyudaViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        public static readonly System.Uri URI_INICIAL_DE_LA_AYUDA = new System.Uri("pack://siteoforigin:,,,/Ayuda/index.html");


        public AyudaViewModel(System.Uri uriInicial)
        {
            this.uriAMostrar = uriInicial;
        }


        private System.Uri _uriAMostrar;
        public System.Uri uriAMostrar
        {
            get { return _uriAMostrar; }
            set
            {
                _uriAMostrar = value;
                NotificarQueAlgoHaCambiadoEn("uriAMostrar");
            }
        }


        private System.Windows.Input.ICommand _MostrarPaginaInicial;
        public System.Windows.Input.ICommand MostrarPaginaInicial
        {
            get { return _MostrarPaginaInicial ?? (_MostrarPaginaInicial = new comandoWPF(() => Accion_MostrarPaginaInicial())); }
        }
        private void Accion_MostrarPaginaInicial()
        {
            uriAMostrar = URI_INICIAL_DE_LA_AYUDA;
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
