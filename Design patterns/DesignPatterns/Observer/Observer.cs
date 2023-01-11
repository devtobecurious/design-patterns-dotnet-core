using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Observer
    {
        private string name;
        private Subject subject;
        private string state;
        private string gap;

        public Observer(string name, Subject subject, string gap)
        {
            this.name = name;
            this.subject = subject;
            this.gap = gap;

            subject.Notify += this.Update;
        }

        public void Update(string state)
        {
            this.state = state;
            Console.WriteLine("{0}{1}: {2}", this.gap, this.name, this.state);
        }
    }
}
