using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client<Brand> where Brand: IBrand, new()
    {
        public void Main()
        {
            IFactory<Brand> factory = new Factory<Brand>();

            IBag bag = factory.CreateBag();
            IShoes shoes = factory.CreateShoes();
        }
    }
}
