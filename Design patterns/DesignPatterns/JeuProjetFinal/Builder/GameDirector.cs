using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Builder
{
    internal class GameDirector
    {
        private readonly IGameBuilder builder;

        public GameDirector(IGameBuilder builder)
        {
            this.builder = builder;
        }

        public Game? Build()
        {
            this.builder.Reset();

            this.builder.PreparePlayer();
            this.builder.PrepareEnnemies();

            return this.builder.Generate();
        }
    }
}
