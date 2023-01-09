using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adaptee
    {
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }
}
