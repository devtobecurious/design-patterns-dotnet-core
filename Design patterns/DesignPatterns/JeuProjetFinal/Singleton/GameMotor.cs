using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuProjetFinal.Builder;

namespace JeuProjetFinal.Singleton
{
    internal sealed class GameMotor
    {
        private Game currentGame;
        private static readonly GameMotor _instance = new GameMotor();

        private GameMotor() { } 

        public static GameMotor Instance => _instance;

        public Game StartNewGame()
        {
            this.currentGame = new Game();

            return this.currentGame;
        }
    }
}
