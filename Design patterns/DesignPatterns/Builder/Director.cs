using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        public Product Construct(IBuilder builder)
        {
            builder.BuildA();
            builder.BuildB();

            return builder.GetResult();
        }
    }
}
