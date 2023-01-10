using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Product
    {
        private List<string> products = new();

        public void Add(string part) => products.Add(part);

        public void Display() => this.products.ForEach(item => Console.WriteLine(item));
    }
}
