using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Client
    {
        public static void Display(string text, IComponent component) => Console.WriteLine("{0} : {1}", text, component.Operation());
    }
}
