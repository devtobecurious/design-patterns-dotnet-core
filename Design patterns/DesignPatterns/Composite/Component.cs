using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Component<T> : IComponent<T>
    {
        public Component(T name)
        {
            this.Name = name;
        }

        public T Name { get; set; }

        public void Add(IComponent<T> component)
        {
        }

        public string Display(int depth)
        {
            return $"-{depth} - {this.Name}";
        }

        public IComponent<T> Get(T find)
        {
            if (find.Equals(this.Name))
            {
                return this;
            }else
            {
                return null;
            }
        }

        public IComponent<T> Remove(T component)
        {
            return this;
        }
    }
}
