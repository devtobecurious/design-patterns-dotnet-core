using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.State
{
    internal class IdleState : IPlayerState
    {
        public void Handle(PlayerContext context)
        {
            context.CurrentTexture = Texture.IdleTexture;
        }

        public void Update(PlayerContext context)
        {
            if (context.CurrentInput.Key == "D" ||
                context.CurrentInput.Key == "Q" ||
                context.CurrentInput.Key == "Z" ||
                context.CurrentInput.Key == "S")
            {
                context.CurrentState = new MoveState();
            }
        }
    }
}
