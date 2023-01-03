using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProtectionProxy : ISubject
    {
        private ISubject? subject = null;
        private const string password = "Abracadabra";

        public string Request()
        {
            if (this.subject == null) throw new InvalidOperationException();

            return this.subject.Request();
        }

        public string Authenticate([NotNull] string supplied)
        {
            string result = "No access";

            if (supplied == null) throw new ArgumentNullException();
            if (supplied == password) result = "Authenticated";

            return result;
        }

       
    }
}
