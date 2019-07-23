namespace Domain.Exceptions
{
    public class CpfInvalidoException: System.Exception
    {
        public CpfInvalidoException() : base("O cpf informado é inválido.") { }
        public CpfInvalidoException(string message) : base(message) { }
        public CpfInvalidoException(string message, System.Exception inner) : base(message, inner) { }
        
        protected CpfInvalidoException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}