using JeuProjetFinal.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Factory_method
{
    internal class AntiPoisonPotion : IPotion
    {
        public int Give()
        {
            return 0;
        }
    }
}
