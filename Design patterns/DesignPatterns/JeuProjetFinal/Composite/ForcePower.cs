using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Composite
{
    internal class ForcePower : IPower
    {
        private int value = 10;

        public ForcePower(int value)
        {
            this.value = value; 
        }

        public void Apply(ICharacter character)
        {
            character.MaxStrength += value;
        }
    }
}
