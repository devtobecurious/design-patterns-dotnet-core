using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Decorator
{
    internal class Potion : IPotion
    {
        public int Give()
        {
            return 50;
        }
    }
}
