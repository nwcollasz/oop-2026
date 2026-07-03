using System;
using ContaExceptionEx.Entities.Exceptions;

namespace ContaExceptionEx.Entities.Exceptions
{
    public class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}