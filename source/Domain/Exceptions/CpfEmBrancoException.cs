namespace Domain.Exceptions
{
    public class CpfEmBrancoException : System.Exception
    {
        public CpfEmBrancoException() : base("O cpf não pode ser vazio.") { }
        public CpfEmBrancoException(string message) : base(message) { }
        public CpfEmBrancoException(string message, System.Exception inner) : base(message, inner) { }
        
        protected CpfEmBrancoException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}