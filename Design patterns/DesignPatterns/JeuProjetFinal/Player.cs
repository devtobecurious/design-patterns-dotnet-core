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

        #region Observer
        public event Action<Player> Died;
        #endregion

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

        private int pointsDeVie = 100;
        public int PointsDeVie
        {
            get => pointsDeVie;
            private set
            {
                this.pointsDeVie = value;
                if (this.pointsDeVie <= 0)
                {
                    this.pointsDeVie = 0;
                    #region Observer
                    this.Died?.Invoke(this);
                    #endregion
                }
            }
        }

        public int MaxLife { get; set; }
        public int MaxStrength { get; set; }
    }
}
