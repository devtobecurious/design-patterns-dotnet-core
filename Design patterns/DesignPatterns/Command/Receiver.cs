using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Receiver
    {
        private string build;
        private string oldBuild;
        private string context = "some";

        public void Action()
        {
            this.oldBuild= this.build;
            this.build += this.context;
        }

        public void Reverse()
        {
            this.build = this.oldBuild;
        }

    }
}
