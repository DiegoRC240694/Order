using System;

namespace Order
{
    public static class Mensagem
    {
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o número da opção desejada:");
            Console.WriteLine("1 - Cadastro de cliente");
            Console.WriteLine("2 - Cadastro de produto");
            Console.WriteLine("3 - Cadastro de venda");
            Console.WriteLine("4 - Visualizar clientes");
            Console.WriteLine("5 - Visualizar produtos");
            Console.WriteLine("6 - Visualizar vendas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
        }

        public static void OpcaoInvalida()
        {
            Console.WriteLine();
            Console.WriteLine("Opção escolhida inválida, escolha uma das opções do menu");
        }

        public static void EntradaInvalida()
        {
            Console.WriteLine();
            Console.WriteLine("Digite apenas caracteres numéricos");
        }
    }
}
