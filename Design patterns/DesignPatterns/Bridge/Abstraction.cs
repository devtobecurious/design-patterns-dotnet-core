using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Abstraction
    {
        private IBridge bridge;

        public Abstraction(IBridge bridge)
        {
            this.bridge = bridge;   
        }

        public string Operation() => $"Abtraction : << BRIDGE >> {this.bridge.Operation()}";

    }
}
