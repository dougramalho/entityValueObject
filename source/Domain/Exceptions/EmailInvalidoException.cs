using System;

namespace Domain.Exceptions
{
    public class EmailInvalidoException: System.Exception
    {
        public EmailInvalidoException() : base("Email inválido.") { }
        public EmailInvalidoException(string message) : base(message) { }
        public EmailInvalidoException(string message, System.Exception inner) : base(message, inner) { }
        
        protected EmailInvalidoException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}