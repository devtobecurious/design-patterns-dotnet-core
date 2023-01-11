using JeuProjetFinal.Bridge;
using JeuProjetFinal.State;
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
        private PlayerContext context;

        public Player(IArmeBridge bridge) : this()
        {
            this.arme = bridge;
        }

        public Player()
        {
            this.context = new PlayerContext(this);
            this.context.CurrentState = new IdleState();
        }

        public void RequestInput(Func<Input> input)
        {
            this.context.Request(input());
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
