using System;
using HotelEx.Entities.Exceptions;

namespace HotelEx.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}