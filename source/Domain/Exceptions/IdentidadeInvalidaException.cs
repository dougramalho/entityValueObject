namespace Domain.Exceptions
{
    public class IdentidadeInvalidaException: System.Exception
    {
        public IdentidadeInvalidaException() : base("O valor de identidade não pode estar vazio.") { }
        public IdentidadeInvalidaException(string message) : base(message) { }
        public IdentidadeInvalidaException(string message, System.Exception inner) : base(message, inner) { }
        
        protected IdentidadeInvalidaException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}