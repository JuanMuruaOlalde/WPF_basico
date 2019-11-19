using System;

namespace EjemploPlantillaWPF
{

    public class comandoWPF : System.Windows.Input.ICommand
    {
        private Action funcionQueImplementaElTrabajoAEjecutar;

        public comandoWPF(Action elTrabajoAEjecutar)
        {
            this.funcionQueImplementaElTrabajoAEjecutar = elTrabajoAEjecutar;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // Se ha puesto lo mas simple, para cumplir con la implementacion del interface ICommand.
            return true;
            // Se puede poner algo mas elaborado, en caso de que fuera preciso permitir o no ejecutar el comando segun determinadas circunstancias. 
        }

        public void Execute(object parameter)
        {
            funcionQueImplementaElTrabajoAEjecutar();
        }

    }



    public static class UtilidadParaPoderEnlazarConLaPropiedadSourceDelControlWebBrowser
    {
        //Este codigo esta copiado de https://stackoverflow.com/questions/263551/databind-the-source-property-of-the-webbrowser-in-wpf/2791680

        public static readonly System.Windows.DependencyProperty propiedadEnlazableASource = System.Windows.DependencyProperty.RegisterAttached(name: "BindableSource",
                                                                                                                                                propertyType: typeof(System.Uri),
                                                                                                                                                ownerType: typeof(UtilidadParaPoderEnlazarConLaPropiedadSourceDelControlWebBrowser),
                                                                                                                                                defaultMetadata: new System.Windows.UIPropertyMetadata(null, HaCambiadoLaPropiedadEnlazable));
        public static System.Uri GetBindableSource(System.Windows.DependencyObject obj)
        {
            return (System.Uri)obj.GetValue(propiedadEnlazableASource);
        }
        public static void SetBindableSource(System.Windows.DependencyObject obj, System.Uri value)
        {
            obj.SetValue(propiedadEnlazableASource, value);
        }


        public static void HaCambiadoLaPropiedadEnlazable(System.Windows.DependencyObject obj, System.Windows.DependencyPropertyChangedEventArgs ev)
        {
            System.Windows.Controls.WebBrowser visorWeb = (System.Windows.Controls.WebBrowser)obj;
            if (visorWeb != null)
            {
                visorWeb.Source = (Uri)ev.NewValue;
            }
        }
    }


}
