using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Mediator
    {
        private Action<string, string> respond;

        public void SignOn(Action<string, string> action)
        {
            this.respond += action;
        }

        public void Block(Action<string, string> action)
        {
            this.respond -= action;
        }

        public void UnBlock(Action<string, string> action)
        {
            this.SignOn(action);
        }

        public void Send(string message, string from) 
        { 
            this.respond?.Invoke(message, from);
        }
    }
}
