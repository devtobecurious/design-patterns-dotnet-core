using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class Singleton
    {
        private Singleton() { }

        static readonly Singleton instance = new Singleton();

        public static Singleton Instance => instance;
    }
}
