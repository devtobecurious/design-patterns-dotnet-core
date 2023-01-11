using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Colleague
    {
        private Mediator mediator;
        protected string name;

        public Colleague(Mediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;

            this.mediator.SignOn(this.Receive);
        }

        public virtual void Receive(string message, string from)
        {
            Console.WriteLine($"{this.name} received from {from}, message => {message}");
        }

        public void Send(string message)
        {
            this.mediator.Send(message, this.name);
        }
    }
}
