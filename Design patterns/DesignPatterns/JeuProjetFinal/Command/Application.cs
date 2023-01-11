using JeuProjetFinal.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Command
{
    internal class Application
    {
        private static Application application = new Application();
        private List<Button> buttons = new();
        private List<Game> games = new();

        private Application()
        {           
        }

        public void AddNewGame(Game game)
        {
            this.games.Add(game);
        }

        public void Initialize()
        {
            this.buttons.Clear();
            this.buttons.Add(new Button(new StartNewGameCommand(this), "Nouvelle partie"));
            this.buttons.Add(new Button(new ExitGameCommand(this), "Quitter le jeu"));
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public static Application Instance => application;
    }
}
