using System;

namespace Order
{
    public abstract class Entidade
    {
        public long Id { get; set; }
    }

    public abstract class BaseEntidade : Entidade
    {
        public DateTime RegistroDataHora { get; set; }
        public DateTime AlteracaoDataHora { get; set; }
    }
}
