using JeuProjetFinal.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Mediator
{
    internal class SaveGameRequest<TItem, Store> : IRequest<TItem, Store> where Store : IStore, new()
                                                                          where TItem : class, new()
    {
        public SaveGameRequest(TItem item)
        {
            this.Item = item;
        }

        public TItem Item { get; set; }

        public void Execute(Store store)
        {
            Console.WriteLine("Save the store to database");
        }
    }
}
