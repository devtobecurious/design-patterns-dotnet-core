using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Shoes<Brand> : IShoes where Brand : IBrand, new()
    {
        private Brand brand;

        public Shoes()
        {
            this.brand = new Brand();
        }

        public int Price => this.brand.Price;
    }
}
