using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Command
    {
        private Action Execute;
        private Action Undo;
        private Action Redo;

        public Command(Receiver receiver) 
        {
            this.Execute = receiver.Action;
            this.Redo = receiver.Action;
            this.Undo= receiver.Reverse;
        }
    }
}
