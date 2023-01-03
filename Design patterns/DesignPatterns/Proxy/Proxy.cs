using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Proxy : ISubject
    {
        private ISubject subject;

        public Proxy()
        {
            
        }

        public string Request()
        {
            return this.subject.Request();
        }

        public ISubject Subject
        {
            get
            {
                if (subject == null)
                {
                    this.subject = new Subject();
                }

                return subject;
            }
        }
    }
}
