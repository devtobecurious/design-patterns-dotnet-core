using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Subject : ISubject
    {
        public string Request()
        {
            return string.Format("{0} {1}", "Subject request", "Choose left doort\n");
        }
    }
}
