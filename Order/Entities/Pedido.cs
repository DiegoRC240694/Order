using System;
using System.Collections.Generic;

namespace Order
{
    public enum StatusPedido
    {
        EmAndamento,
        PagamentoPendente,
        EmProcessamento,
        Enviado,
        Entregue
    }

    public class Pedido : BaseEntidade
    {
        public StatusPedido Status { get; private set; }
        public List<ItemPedido> Itens { get; private set; }
        public Cliente Cliente { get; private set; }

        public Pedido(Cliente cliente)
        {
            Status = StatusPedido.EmAndamento;
            Cliente = cliente;
            Itens = new List<ItemPedido>();
            base.RegistroDataHora = DateTime.Now;
        }

        public void Resumo()
        {
            Console.WriteLine($"Cliente: {Cliente.Pessoa.NomeCompleto}");
            Console.WriteLine($"Status: {Status}");

            foreach (var item in Itens)
            {
                Console.WriteLine($"Produto: {item.Produtos.Descricao}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Valor total: R$ {item.ValorTotal:c}");
            }
        }

        public void AdicionarItem(ItemPedido itemPedido)
        {
            if (Status != StatusPedido.EmAndamento)
                throw new ExcecaoPedido("Só é possível adicionar itens em pedidos que estão em progresso!");

            Itens.Add(itemPedido);
        }

        public void RemoverItem(ItemPedido itemPedido)
        {
            if (Status != StatusPedido.EmAndamento)
                throw new ExcecaoPedido("Só é possível remover itens em pedidos que estão em progresso!");

            Itens.Remove(itemPedido);
        }

        public void FinalizarPedido()
        {
            if (Status != StatusPedido.EmAndamento)
                throw new ExcecaoPedido("Só é possível finalizar pedido que esteja com o status em progresso!");

            Status = StatusPedido.PagamentoPendente;
        }

        public void PagamentoRealizado()
        {
            if (Status != StatusPedido.PagamentoPendente)
                throw new ExcecaoPedido("Só é possível finalizar pedido que esteja com o status aguardando pagamento!");

            Status = StatusPedido.EmProcessamento;
        }

        public void EncomendaEnviada()
        {
            if (Status != StatusPedido.EmProcessamento)
                throw new ExcecaoPedido("Só é possível enviar pedido que esteja com o status processando!");

            Status = StatusPedido.Enviado;
        }

        public void PedidoEntregue()
        {
            if (Status != StatusPedido.Enviado)
                throw new ExcecaoPedido("Só é possível entregar pedidos que estejam com o status enviado!");

            Status = StatusPedido.Entregue;
        }
    }
}
