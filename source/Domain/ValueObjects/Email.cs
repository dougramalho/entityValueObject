using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects
{
    public class Email
    {
        public string Endereco { get; protected set; }
        
        public Email(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new EmailEmBrancoException();
            
            if (!IsValid(email))
                throw new EmailInvalidoException();
            
            Endereco = email;
        }

        public bool IsValid(string email)
        {
            //Credits: https://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp/16168118
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}