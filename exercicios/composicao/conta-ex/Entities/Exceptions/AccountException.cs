using System;
using ContaEx.Entities.Exceptions;

namespace ContaEx.Entities.Exceptions
{
    public class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}