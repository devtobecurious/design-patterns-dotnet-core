using JeuProjetFinal.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Mediator
{
    internal interface IMediator<Store> where Store : IStore, new()
    {
        void Dispatch<TItem>(IRequest<TItem, Store> request) where TItem: class, new();
    }
}
