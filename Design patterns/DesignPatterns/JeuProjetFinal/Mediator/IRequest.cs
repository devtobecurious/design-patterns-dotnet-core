using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Mediator
{
    internal interface IRequest<TItem, Store> where TItem : class, new()
                                              where Store : IStore, new()
    {
        void Execute(Store store);

        TItem Item { get; set; }
    }
}
