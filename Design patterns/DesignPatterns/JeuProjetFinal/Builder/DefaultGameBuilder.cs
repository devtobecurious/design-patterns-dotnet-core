using JeuProjetFinal.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Builder
{
    internal class DefaultGameBuilder : IGameBuilder
    {
        private Game? game = null;
        
        public Game? Generate()
        {
            return this.game;
        }

        public void PrepareEnnemies()
        {
            this.game?.AddEnemy(new Enemy(new Baguette()));
        }

        public void PreparePlayer()
        {
            this.game?.AddPlayer(new Player());
        }

        public void Reset()
        {
            this.game = new Game();
        }
    }
}
