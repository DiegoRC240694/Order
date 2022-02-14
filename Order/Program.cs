using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Order
{
    static class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Cliente> _clientes = new List<Cliente>();
        //    List<Produtos> _produtos = new List<Produtos>();
        //    List<Pedido> _pedidos = new List<Pedido>();

        //    Console.WriteLine("Seja bem-vindo!");

        //    var opcaoEscolhida = -1;

        //    while (opcaoEscolhida != 0)
        //    {
        //        opcaoEscolhida = Util.EscolhaOpcaoMenu();

        //        switch (opcaoEscolhida)
        //        {
        //            case 1:
        //                _clientes.Add(Util.CadastrarCliente());
        //                break;
        //            case 2:
        //                _produtos.Add(Util.RegistrarProduto());
        //                break;
        //            case 3:
        //                _pedidos.Add(Util.RegistrarPedido(_clientes, _produtos));
        //                break;
        //            case 4:
        //                Util.ListarClientes(_clientes);
        //                break;
        //            case 5:
        //                Util.ListarProdutos(_produtos);
        //                break;
        //            case 6:
        //                Util.ListarPedidos(_pedidos);
        //                break;
        //            default:
        //                Mensagem.EntradaInvalida();
        //                break;
        //        }
        //    }

        //    Environment.Exit(0);
        //}

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
              
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Menu());
        }
    }
}