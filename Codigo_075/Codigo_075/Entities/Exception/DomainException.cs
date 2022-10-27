using System;

namespace Codigo_075.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
