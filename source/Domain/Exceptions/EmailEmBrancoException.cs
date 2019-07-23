namespace Domain.Exceptions
{
    public class EmailEmBrancoException: System.Exception
    {
        public EmailEmBrancoException() : base("Email não pode estar em branco.") { }
        public EmailEmBrancoException(string message) : base(message) { }
        public EmailEmBrancoException(string message, System.Exception inner) : base(message, inner) { }
        
        protected EmailEmBrancoException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}