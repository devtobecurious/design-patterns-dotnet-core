using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    [Serializable]
    internal class Originator
    {
        private List<string> state = new ();

        public void Operation(string operation)
        {
            this.state.Add(operation);
        }

        public Memento Save()
        {
            return new Memento().Save(this.state);
        }

        public void Restore(Memento memento)
        {
            this.state = memento.Restore<List<string>>();
        }
    }
}
