using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Proxy
{
    internal interface IPlaneteProxy
    {
        IEnumerable<Planete>? GetList();
    }
}
