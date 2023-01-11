using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.State
{
    internal class PlayerContext
    {
        private readonly Player _player;

        public PlayerContext(Player player)
        {
            this._player = player;
        }

        public void Request(Input input)
        {
            this.CurrentInput = input;
            this.CurrentState.Update(this);
            this.CurrentState.Handle(this);
        }

        public IPlayerState CurrentState { get; set; }

        public Input CurrentInput { get; set; }

        public Position CurrentPosition { get; set; }

        public Texture CurrentTexture { get; set; }
    }
}
