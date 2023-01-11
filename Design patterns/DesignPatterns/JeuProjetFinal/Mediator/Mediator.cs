using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Mediator
{
    internal class Mediator<Store> : IMediator<Store> where Store : IStore, new()
    {
        private readonly Store store;
        private Action<Store> notify;

        public Mediator(Store store, Action<Store> action)
        {
            this.store = store;
            this.notify += action;
        }

        public void Dispatch<TItem>(IRequest<TItem, Store> request) where TItem : class, new()
        {
            request?.Execute(this.store);
            this.notify?.Invoke(this.store);
        }
    }
}
