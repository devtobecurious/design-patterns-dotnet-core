using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ProductC : IProduct
    {
        public string ShipFrom()
        {
            return " from Chicago";
        }
    }
}
