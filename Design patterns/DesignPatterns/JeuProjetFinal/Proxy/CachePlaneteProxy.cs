using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Proxy
{
    internal class CachePlaneteProxy : IPlaneteProxy
    {
        public IEnumerable<Planete>? GetList()
        {
            if (this.Planetes == null)
            {
                var proxy = new ApiPlanete();
                this.Planetes = proxy.GetList().Result;
            }

            return this.Planetes;
        }

        public IEnumerable<Planete>? Planetes { get; private set; }
    }
}
