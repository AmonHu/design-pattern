using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxySubject: ISubject
    {
        private ISubject subject;
        public ProxySubject(ISubject subject)
        {
            this.subject = subject;
        }

        public void Request()
        {
            Console.WriteLine("proxy subject");
            this.subject.Request();
        }
    }
}
