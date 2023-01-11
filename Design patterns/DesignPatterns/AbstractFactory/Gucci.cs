using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Gucci : IBrand
    {
        public int Price => 1000;

        public string Material => "Crocodile skin";
    }
}
