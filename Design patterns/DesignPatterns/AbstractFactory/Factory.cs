using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    {
        public IBag CreateBag() => new Bag<Brand>();

        public IShoes CreateShoes() => new Shoes<Brand>();
    }
}
