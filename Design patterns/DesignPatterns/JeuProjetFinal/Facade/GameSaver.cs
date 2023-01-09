using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Facade
{
    internal class GameSaver
    {
        private readonly LocalFileDbDataLayer layer = null;
        private readonly GameLogger gameLogger = new GameLogger();

        public GameSaver(string path)
        {
            this.layer = new LocalFileDbDataLayer(path);
        }

        public void Save(Game game)
        {
            this.layer.Save(game);
            this.gameLogger.Save(game);
        }
    }
}
