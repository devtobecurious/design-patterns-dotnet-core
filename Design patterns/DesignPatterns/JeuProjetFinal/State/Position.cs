using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.State
{
    internal struct Position
    {
        public static Position Empty = new Position() { x = 0, y = 0 };

        public int x;
        public int y;
    }
}
