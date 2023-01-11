using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Bag<Brand> : IBag where Brand : IBrand, new()
    {
        private Brand brand;
        public Bag()
        {
            this.brand = new Brand();
        }

        public string Material => this.brand.Material;
    }
}
