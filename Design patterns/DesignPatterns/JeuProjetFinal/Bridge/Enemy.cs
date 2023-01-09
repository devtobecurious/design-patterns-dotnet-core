using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Bridge
{
    internal class Enemy : ICharacter
    {
        private IArmeBridge arme;
        
        public Enemy(IArmeBridge bridge)
        {
            this.arme = bridge;
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
    }
}
