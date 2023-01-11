using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.State
{
    internal class MoveState : IPlayerState
    {
        public void Handle(PlayerContext context)
        {
            context.CurrentTexture = Texture.MovingTexture;
        }

        public void Update(PlayerContext context)
        {
            Position position = new Position();

            if (context.CurrentInput.Key == "D")
            {
                position = new Position() { x = 1 };
            }
            else if (context.CurrentInput.Key == "S")
            {
                position = new Position() { x = -1 };
            }
            else if (context.CurrentInput.Key == "Z")
            {
                position = new Position() { y = -1 };
            }
            else if (context.CurrentInput.Key == "S")
            {
                position = new Position() { y = 1 };
            }
            else
            {
                context.CurrentState = new IdleState();
            }
        }
    }
}
