using System.Collections.Generic;
using System.Linq;

namespace Domain.ValueObjects
{
    public class Contato
    {
        public string Telefones { get; protected set; }
        public Email Email { get; protected set; }
        

        public string[] ObterTelefonesFormatados()
        {
            return Telefones.Split(',');
        }
        
        public Contato(Email email, List<string> telefones)
        {
            Email = email;
            Telefones = string.Join(",", telefones);
        }
    }
}