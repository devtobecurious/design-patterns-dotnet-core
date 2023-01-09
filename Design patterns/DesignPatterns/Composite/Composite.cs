using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Composite<T> : IComponent<T>
    {
        private List<IComponent<T>> _components = new List<IComponent<T>>();

        public Composite(T name)
        {
            this.Name = name;
        }

        public T Name { get; set; }

        public void Add(IComponent<T> component)
        {
            this._components.Add(component);
        }

        public string Display(int depth)
        {
            StringBuilder stringBuilder= new StringBuilder("-" + depth);

            foreach (var item in this._components)
            {
                stringBuilder.Append(item.Display(depth + 2));
            }

            return stringBuilder.ToString();
        }

        public IComponent<T> Get(T find)
        {
            if (find.Equals(this.Name))
                return this;

            IComponent<T> found = null;

            foreach (var component in this._components)
            {
                found = component.Get(find);
                if (found != null) break;
            }

            return found;
        }

        public IComponent<T> Remove(T component)
        {
            return this;
        }
    }
}
