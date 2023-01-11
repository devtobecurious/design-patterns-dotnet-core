using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Simulator : IEnumerable<string>
    {
        string[] lines =
        {
            "Il était une fois",
            "Dans la ville de Foie",
            "**STOP**",
            "Un monsieur se nommant, ma foi, Fois"
        };

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in this.lines)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
