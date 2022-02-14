using System.Text.RegularExpressions;

namespace Order
{
    public struct Email
    {
        public readonly string _valor;
        public readonly bool EValido;

        public Email(string valor)
        {
            _valor = valor.Trim();

            if (string.IsNullOrEmpty(_valor))
            {
                EValido = false;
                return;
            }

            EValido = Regex.IsMatch(_valor, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (!EValido)
                return;
        }

        public static implicit operator Email(string valor)
            => new Email(valor);

        public override string ToString() => _valor;
    }
}
