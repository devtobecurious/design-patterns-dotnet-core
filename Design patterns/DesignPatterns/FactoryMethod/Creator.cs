using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Creator
    {
        public IProduct? Create(int month)
        {
            IProduct product = null;

            if (month >= 4 && month <= 11) product = new ProductA();
            else if (month == 1 || month == 12) product = new ProductB();
            else product = new NotAvailableProduct();

            return product;
        }
    }
}
