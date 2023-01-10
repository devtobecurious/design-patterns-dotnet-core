using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Builder2 : IBuilder
    {
        private readonly Product product = new();
        
        public void BuildA()
        {
            this.product.Add("2-A");
        }

        public void BuildB()
        {
            this.product.Add("2-B");
        }

        public Product GetResult()
        {
            return this.product;
        }
    }
}
