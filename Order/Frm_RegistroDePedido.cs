using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Frm_RegistroDePedido : Form
    {
        public Frm_RegistroDePedido()
        {
            InitializeComponent();
        }
        private void LimparFormulario()
        {
            Txt_NumeroCliente.Text = "";
            Txt_NumeroProduto.Text = "";
        }
        Order LeituraFormulario(List<Customer> customers, List<Product> products)
        {
            int indexCustomer = -1;
            do
            {
                try
                {
                    ListCustomers(customers);
                   
                    indexCustomer = Convert.ToInt32(Txt_NumeroCliente.Text);
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }
            while (indexCustomer == -1 || indexCustomer > customers.Count);

            var customer = customers[indexCustomer - 1];

            var order = new Order(customer);

            // Fazer o order item e add na order
            var chooseMoreProducts = 1;

            do
            {
                try
                {
                    Console.WriteLine("Escolha o número de um produto válido: ");
                    ListProducts(products);
                    var indexProduct = ChooseProduct(products.Count);
                    var product = products[indexProduct - 1];
                    var quantity = ChooseQuantity(product.AvailableQuantity);

                    order.AddItem(new OrderItem(product, quantity));

                    Console.WriteLine("Deseja escolher mais produtos?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");

                    chooseMoreProducts = ChooseMoreProducts();
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }
            while (chooseMoreProducts == 1);

            return order;
        }

        public static void ListCustomers(List<Customer> customers)
        {
            if (customers == null || customers.Count == 0)
            {
                Console.WriteLine("Nenhum cliente foi registrado");
                return;
            }

            var count = 1;
            Console.WriteLine("Id | Nome | CPF | E-mail | Idade");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{count} | {customer.Person?.FullName} | {customer.Person?.Cpf.CpfFormatado} | {customer.Person?.Email} | {customer.Person?.Age}");
                Console.WriteLine();
                count++;
            }
        }

        public static void ListProducts(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("Nenhum produto foi registrado");
                return;
            }

            var count = 1;
            Console.WriteLine("Id | Descrição | Valor unitário | Quantidade disponível");
            foreach (var product in products)
            {
                Console.WriteLine($"{count} | {product.Description} | {product.UnitaryValue:c} | {product.AvailableQuantity}");
                Console.WriteLine();
                count++;
            }
        }

        public static int ChooseProduct(int maxIndex)
        {
            int productIndex = 0;
            do
            {
                try
                {
                    Console.WriteLine("Escolha um número de produto válido:");
                    productIndex = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }
            while (productIndex < 1 || productIndex > maxIndex);

            return productIndex;
        }

        public static int ChooseQuantity(int maxQuantity)
        {
            int quantity = 0;
            do
            {
                try
                {
                    Console.WriteLine("Escolha uma quantidade válida:");
                    quantity = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }
            while (quantity < 1 || quantity > maxQuantity);

            return quantity;
        }

        public static int ChooseMoreProducts()
        {
            int chooseMoreProducts = -1;
            do
            {
                try
                {
                    Console.WriteLine("Escolha um número de produto válido:");
                    chooseMoreProducts = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }
            while (chooseMoreProducts < 1 || chooseMoreProducts > 2);

            return chooseMoreProducts;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
