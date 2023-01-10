using JeuProjetFinal.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Builder
{
    internal class Game
    {
        private Player? player = null;
        private List<Enemy> enemies = new List<Enemy>();

        public void AddPlayer(Player player)
        {
            this.player = player;
        }

        public void AddEnemy(Enemy enemy)
        {
            this.enemies.Add(enemy);
        }

    }
}
