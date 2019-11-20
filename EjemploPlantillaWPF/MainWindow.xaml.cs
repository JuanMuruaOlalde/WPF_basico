using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjemploPlantillaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ElCursorEstaSobreLosRadiobuttons(object sender, MouseEventArgs e)
        {
            ((MainViewModel)DataContext).mensajeEnLaBarraDeEstado = "El ratón está sobre los radiobuttons"
                                                                    + ", en la posicion " + e.GetPosition(relativeTo: this).ToString();
        }

        private void ElCursorYaNoEstaSobreLosRadiobuttons(object sender, MouseEventArgs e)
        {
            ((MainViewModel)DataContext).mensajeEnLaBarraDeEstado = "";
        }


    }

}
