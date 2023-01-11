using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.State
{
    internal interface IPlayerState
    {
        void Handle(PlayerContext context);
        void Update(PlayerContext context);
    }
}
