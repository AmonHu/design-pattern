using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new ProxySubject(new RealSubject());
            subject.Request();
            
        }
    }
}
