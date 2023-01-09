using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : Adaptee, ITarget
    {
        public string Request(int i)
        {
            return $"Estimation is {Math.Round(this.SpecificRequest(i, 3))}";
        }
    }
}
