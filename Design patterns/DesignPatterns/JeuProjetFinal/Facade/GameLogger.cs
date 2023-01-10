using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuProjetFinal.Builder;

namespace JeuProjetFinal.Facade
{
    internal class GameLogger
    {
        public GameLogger() { }

        public void Save(Game game) => Console.WriteLine(game.ToString());
    }
}
