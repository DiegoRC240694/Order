using System;

namespace Order
{
    public class ExcecaoPedido : Exception
    {
        public ExcecaoPedido(string mensagem) : base(mensagem) { }
    }
}
