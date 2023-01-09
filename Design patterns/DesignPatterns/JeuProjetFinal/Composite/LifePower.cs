using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Composite
{
    internal class LifePower : IPower
    {
        private int value = 10;

        public LifePower(int value)
        {
            this.value = value;
        }

        public void Apply(ICharacter character)
        {
            character.MaxLife += value;
        }
    }
}
