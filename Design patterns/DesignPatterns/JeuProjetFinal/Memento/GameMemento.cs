using JeuProjetFinal.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Memento
{
    internal class GameMemento : IGameMemento
    {
        private readonly Game game;

        public GameMemento(Game game)
        {
            this.game = game.Clone() as Game;
        }

        public Player Player => this.game.CurrentPlayer;
    }
}
