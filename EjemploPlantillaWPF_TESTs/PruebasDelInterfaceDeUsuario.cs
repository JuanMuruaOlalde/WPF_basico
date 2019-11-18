using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;


namespace EjemploPlantillaWPF_TESTs
{
    [TestClass]
    public class PruebasDelInterfaceDeUsuario
    {
        [TestMethod]
        public void SeNotificanLosCambiosEnLaPropiedad_mensajeEnLaBarraDeEstado()
        {
            EjemploPlantillaWPF.MainViewModel modelo = new EjemploPlantillaWPF.MainViewModel();

            List<string> eventos = new List<string>();
            modelo.PropertyChanged += delegate (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                eventos.Add(e.PropertyName);
            };

            modelo.mensajeEnLaBarraDeEstado = "Hola, mundo.";
            Assert.AreEqual(1, eventos.Count);
            Assert.AreEqual("mensajeEnLaBarraDeEstado", eventos[0]);
        }

        [TestMethod]
        public void SeNotificanLosCambiosEnLaPropiedad_textoDePrueba1YSeActualizaLaBarraDeEstado()
        {
            EjemploPlantillaWPF.MainViewModel modelo = new EjemploPlantillaWPF.MainViewModel();

            List<string> eventos = new List<string>();
            modelo.PropertyChanged += delegate (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                eventos.Add(e.PropertyName);
            };

            modelo.textoDePrueba1 = "Hola, mundo.";
            Assert.AreEqual(2, eventos.Count);
            Assert.AreEqual("textoDePrueba1", eventos[0]);
            Assert.AreEqual("mensajeEnLaBarraDeEstado", eventos[1]);
        }

        [TestMethod]
        public void SeNotificanLosCambiosEnLaPropiedad_textoDePrueba2()
        {
            EjemploPlantillaWPF.MainViewModel modelo = new EjemploPlantillaWPF.MainViewModel();

            List<string> eventos = new List<string>();
            modelo.PropertyChanged += delegate (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                eventos.Add(e.PropertyName);
            };

            modelo.textoDePrueba2 = "Hola, mundo.";
            Assert.AreEqual(1, eventos.Count);
            Assert.AreEqual("textoDePrueba2", eventos[0]);
        }



    }
}
