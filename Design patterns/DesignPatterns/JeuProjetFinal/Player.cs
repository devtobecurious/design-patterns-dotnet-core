using JeuProjetFinal.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal
{
    internal class Player : ICharacter
    {
        private IArmeBridge arme;

        public Player(IArmeBridge bridge)
        {
            this.arme = bridge;
        }

        public Player()
        {
        }

        public void Attaquer(ICharacter enemy)
        {
            int point = this.arme.DonnerUnCoup();
            enemy.Subir(point);
        }

        public void Subir(int point)
        {
            this.PointsDeVie -= point;
        }

        public int PointsDeVie { get; private set; }
        public int MaxLife { get; set; }
        public int MaxStrength { get; set; }
    }
}
