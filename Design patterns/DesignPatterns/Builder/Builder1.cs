using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Builder1 : IBuilder
    {
        private Product product = new();

        public void BuildA()
        {
            product.Add("1-A");
        }

        public void BuildB()
        {
            product.Add("1-B");
        }

        public Product GetResult()
        {
            return this.product;
        }
    }
}
