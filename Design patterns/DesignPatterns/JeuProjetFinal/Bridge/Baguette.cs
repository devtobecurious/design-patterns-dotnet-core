using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Bridge
{
    internal class Baguette : IArmeBridge
    {
        public int DonnerUnCoup()
        {
            return 10;
        }
    }
}
