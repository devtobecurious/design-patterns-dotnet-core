using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecoratorB : IComponent
    {
        private readonly IComponent _component;
        public DecoratorB(IComponent component) => _component = component;
        public string Operation()
        {
            return _component.Operation() + " , after going to my coffee shop";
        }
    }
}
