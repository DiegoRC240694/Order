
namespace Order
{
    public class Cliente : BaseEntidade
    {
        public Pessoa Pessoa { get; set; }
        public bool Ativo { get; set; }
    }
}
