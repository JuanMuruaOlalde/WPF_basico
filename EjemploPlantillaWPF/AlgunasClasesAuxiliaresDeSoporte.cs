using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




}
