using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Command
{
    internal class Button
    {
        private readonly ICommand command;
        private readonly string libelle;

        public Button(ICommand command, string libelle)
        {
            this.command = command;
            this.libelle = libelle; 
        }

        public void Click()
        {
            this.command.Execute();
        }
    }
}
