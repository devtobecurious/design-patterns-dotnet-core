using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal
{
    internal interface ICharacter
    {
        void Attaquer(ICharacter enemy);
        void Subir(int point);
        int PointsDeVie { get; }

        int MaxLife { get; set; }

        int MaxStrength { get; set; }
    }
}
