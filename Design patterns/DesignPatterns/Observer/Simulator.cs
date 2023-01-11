using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Simulator : IEnumerable<string>
    {
        string[] moves = { "4", "3", "1", "6", "7" };
        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in moves)
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
