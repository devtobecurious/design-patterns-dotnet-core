using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Composite
{
    internal interface IPower
    {
        void Apply(ICharacter character);
    }
}
