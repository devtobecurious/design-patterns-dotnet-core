using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IBrand
    {
        int Price { get; }
        string Material { get; }
    }
}
