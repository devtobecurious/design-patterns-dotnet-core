using JeuProjetFinal.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Builder
{
    internal class Game : ICloneable
    {
        private Player? player = null;
        private List<Enemy> enemies = new List<Enemy>();

        #region Observer
        public void PlayerIsDied(Player player)
        {
            Console.WriteLine("Player is dead ! Game over !");
        }
        #endregion

        public void AddPlayer(Player player)
        {
            this.CurrentPlayer = player;
            #region Observer
            this.CurrentPlayer.Died += PlayerIsDied;
            #endregion
        }

        public void AddEnemy(Enemy enemy)
        {
            this.enemies.Add(enemy);
        }

        public object Clone()
        {
            return new Game();
        }

        public Player CurrentPlayer { get => player; private set => player = value; }
    }
}
