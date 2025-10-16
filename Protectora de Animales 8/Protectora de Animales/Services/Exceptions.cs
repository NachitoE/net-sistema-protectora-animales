using System;

namespace Services
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message) { }
    }
}
