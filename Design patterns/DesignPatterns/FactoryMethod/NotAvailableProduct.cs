using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class NotAvailableProduct : IProduct
    {
        public string ShipFrom()
        {
            return "not available";
        }
    }
}
