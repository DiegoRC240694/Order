using System;
using System.Collections.Generic;
using System.Globalization;

namespace Order
{
    public static class Util
    {
        public static Cliente CadastrarCliente()
        {
            string primeiroNome;
            string ultimoNome;
            Cpf cpf = string.Empty;
            Email email = string.Empty;
            DateTime dataNascimento = DateTime.MinValue;

            Console.WriteLine("Insira o primeiro nome do cliente: ");
            primeiroNome = Console.ReadLine();
            Console.WriteLine("Insira o sobrenome do cliente: ");
            ultimoNome = Console.ReadLine();
            while (!cpf.EValido)
            {
                Console.WriteLine("Insira o cpf do cliente sem pontos e traços: ");
                cpf = Console.ReadLine();
            }

            while (!email.EValido)
            {
                Console.WriteLine("Insira o e-mail do cliente: ");
                email = Console.ReadLine();
            }

            while (dataNascimento == DateTime.MinValue)
            {
                try
                {
                    Console.WriteLine("Insira a data de nascimento do cliente, no formato dd/MM/yyyy: ");
                    dataNascimento = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("pt-BR"));
                }
                catch (Exception)
                {
                    Console.WriteLine("Data inserida no formato errado, tente novamente");
                }
            }

            try
            {
              //  var pessoa = new Pessoa(primeiroNome, ultimoNome, dataNascimento, cpf, email);
                var cliente = new Cliente()
                {
                    //Pessoa = pessoa,
                    Ativo = true
                };

                return cliente;
            }
            catch (ExcecaoPedido ex)
            {
                Console.WriteLine("Erro ao cadastrar cliente:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro desconhecido:");
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public static Produtos RegistrarProduto()
        {
            string DescricaoProduto;
            int ProdutoDisponivel = -1;
            decimal ValorUnitarioProduto = -1M;

            Console.WriteLine("Insira a descrição do produto: ");
            DescricaoProduto = Console.ReadLine();

            while (ProdutoDisponivel == -1)
            {
                try
                {
                    Console.WriteLine("Insira a quantidade disponível: ");
                    ProdutoDisponivel = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }

            while (ValorUnitarioProduto == -1M)
            {
                try
                {
                    Console.WriteLine("Insira o valor unitário do produto: ");
                    ValorUnitarioProduto = Convert.ToDecimal(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }

            var produtos = new Produtos(DescricaoProduto, ValorUnitarioProduto, ProdutoDisponivel);
            return produtos;
        }

        public static Pedido RegistrarPedido(List<Cliente> clientes, List<Produtos> produtos)
        {
            int IndexarCliente = -1;
            do
            {
                try
                {
                    ListarClientes(clientes);
                    Console.WriteLine("Informe o número de um cliente válido: ");
                    IndexarCliente = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }
            while (IndexarCliente == -1 || IndexarCliente > clientes.Count);

            var cliente = clientes[IndexarCliente - 1];

            var pedido = new Pedido(cliente);

            // Fazer o pedido item e add na pedido
            var escolhaMaisProdutos = 1;

            do
            {
                try
                {
                    Console.WriteLine("Escolha o número de um produto válido: ");
                    ListarProdutos(produtos);
                    var produtoIndice = EscolhaProduto(produtos.Count);
                    var produto = produtos[produtoIndice - 1];
                    var quantidade = EscolhaQuantidade(produto.QuantidadeDisponivel);

                    pedido.AdicionarItem(new ItemPedido(produto, quantidade));

                    Console.WriteLine("Deseja escolher mais produtos?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");

                    escolhaMaisProdutos = EscolhaMaisprodutos();
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }
            while (escolhaMaisProdutos == 1);

            return pedido;
        }

        public static int EscolhaMaisprodutos()
        {
            int escolhaMaisProdutos = -1;
            do
            {
                try
                {
                    Console.WriteLine("Escolha um número de produto válido:");
                    escolhaMaisProdutos = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }
            while (escolhaMaisProdutos < 1 || escolhaMaisProdutos > 2);

            return escolhaMaisProdutos;
        }

        public static int EscolhaProduto(int indiceMaximo)
        {
            int indiceProduto = 0;
            do
            {
                try
                {
                    Console.WriteLine("Escolha um número de produto válido:");
                    indiceProduto = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }
            while (indiceProduto < 1 || indiceProduto > indiceMaximo);

            return indiceProduto;
        }

        public static int EscolhaQuantidade(int quantidadeMaxima)
        {
            int quantidade = 0;
            do
            {
                try
                {
                    Console.WriteLine("Escolha uma quantidade válida:");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }
            while (quantidade < 1 || quantidade > quantidadeMaxima);

            return quantidade;
        }

        public static int EscolhaOpcaoMenu()
        {
            var resultado = -1;
            do
            {
                try
                {
                    Mensagem.Menu();
                    resultado = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Mensagem.EntradaInvalida();
                }
            }
            while (resultado == -1);

            return resultado;
        }

        public static void ListarClientes(List<Cliente> clientes)
        {
            if (clientes == null || clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente foi registrado");
                return;
            }

            var count = 1;
            Console.WriteLine("Id | Nome | CPF | E-mail | Idade");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{count} | {cliente.Pessoa?.NomeCompleto} | {cliente.Pessoa?.Cpf.CpfFormatado} | {cliente.Pessoa?.Email} | {cliente.Pessoa?.Idade}");
                Console.WriteLine();
                count++;
            }
        }

        public static void ListarProdutos(List<Produtos> produtos)
        {
            if (produtos == null || produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto foi registrado");
                return;
            }

            var count = 1;
            Console.WriteLine("Id | Descrição | Valor unitário | Quantidade disponível");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"{count} | {produto.Descricao} | {produto.ValorUnitario:c} | {produto.QuantidadeDisponivel}");
                Console.WriteLine();
                count++;
            }
        }

        public static void ListarPedidos(List<Pedido> pedidos)
        {
            if (pedidos == null || pedidos.Count == 0)
            {
                Console.WriteLine("Nenhuma venda foi registrada");
                return;
            }

            var count = 1;
            foreach (var pedido in pedidos)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Id da venda: {count}");
                Console.WriteLine($"Cliente: {pedido.Cliente?.Pessoa?.NomeCompleto}");
                Console.WriteLine($"Status do pedido: {pedido.Status}");
                Console.WriteLine();
                Console.WriteLine("Itens do pedido");
                Console.WriteLine("Produto | Quantidade | Valo unitário | Valor total");
                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"{item.Produtos?.Descricao} | {item.Quantidade} | R$ {item.Produtos?.ValorUnitario:c} | R$ {item.ValorTotal:c}");
                }
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
