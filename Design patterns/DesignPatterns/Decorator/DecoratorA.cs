using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecoratorA : IComponent
    {
        private readonly IComponent _component;
        public DecoratorA(IComponent component) => _component = component;
        public string Operation()
        {
            return _component.Operation() + " and listening my podcast";
        }
    }
}
