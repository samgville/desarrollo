using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcepcionesTotem.Modulo1
{
    public class LoginErradoException : ExceptionTotem
    {
      public LoginErradoException()
            : base()
        { }

        public LoginErradoException(string message)
            : base(message)
        {
        }

        public LoginErradoException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public LoginErradoException(string codigo, string message, Exception inner)
            : base(codigo, message, inner)
        {
        }

}


    }

