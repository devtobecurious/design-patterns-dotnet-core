using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Colleague2 : Colleague
    {
        public Colleague2(Mediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message, string from)
        {
            if (!String.Equals(from, this.name))
            {
                base.Receive(message, from);
            }
        }
    }
}
