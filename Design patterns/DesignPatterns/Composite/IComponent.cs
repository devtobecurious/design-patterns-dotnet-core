using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal interface IComponent<T>
    {
        void Add(IComponent<T> component);
        IComponent<T> Remove(T component);
        string Display(int depth);
        IComponent<T> Get(T find);
        T Name { get; set; }
    }
}
