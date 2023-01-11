using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Command
{
    internal class ExitGameCommand : ICommand
    {
        private readonly Application application;

        public ExitGameCommand(Application application)
        {
            this.application = application;
        }

        public void Execute()
        {
            this.application.Exit();
        }
    }
}
