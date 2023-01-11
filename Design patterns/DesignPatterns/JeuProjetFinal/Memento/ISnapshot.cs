using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Memento
{
    internal interface ISnapshot
    {
        IGameMemento CreateSnapShot();

        void Restore(IGameMemento memento);
    }
}
