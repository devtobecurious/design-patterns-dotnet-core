using JeuProjetFinal.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Factory_method
{
    internal class PotionCreator
    {
        public IPotion Create(int code) =>
            code switch
            {
                0 => new Potion(),
                1 => new MultiplyPotion(new Potion()),
                2 => new AntiPoisonPotion(),
                _ => throw new NotImplementedException()
            };
    }
}
