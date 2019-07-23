using System;
using Domain.Exceptions;

namespace Domain.Identities
{
    public class PessoaId
    {
        public Guid Value { get; protected set; }
        
        public PessoaId(Guid id)
        {
            if (id == Guid.Empty)
                throw new IdentidadeInvalidaException();
            
            Value = id;
        }
    }
}