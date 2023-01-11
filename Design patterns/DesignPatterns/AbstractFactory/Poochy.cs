using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Poochy : IBrand
    {
        public int Price => new Gucci().Price / 3;

        public string Material => "Plastic";
    }
}
