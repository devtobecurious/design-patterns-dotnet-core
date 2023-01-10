using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Builder
{
    internal interface IGameBuilder
    {
        void Reset();
        void PreparePlayer();
        void PrepareEnnemies();
        Game? Generate();
    }
}
