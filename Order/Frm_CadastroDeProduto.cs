using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Frm_CadastroDeProduto : Form
    {
        public Frm_CadastroDeProduto()
        {
            InitializeComponent();
            LimparFormulario();
        }

        private void LimparFormulario()
        {

            Txt_DescricaoDoProduto.Text = "";
            Txt_QuantidadeDisponivel.Text = "";
            Txt_ValorUnitarioDoProduto.Text = "";

        }
        Product LeituraFormulario()
        {
            string productDescription;
            int productAvailable = -1;
            decimal productUnitaryValue = -1M;

            
            productDescription = Txt_DescricaoDoProduto.Text;

            while (productAvailable == -1)
            {
                try
                {
                   
                    productAvailable = Convert.ToInt32(Txt_QuantidadeDisponivel.Text);
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }

            while (productUnitaryValue == -1M)
            {
                try
                {
                    
                    productUnitaryValue = Convert.ToDecimal(Txt_ValorUnitarioDoProduto.Text);
                }
                catch (Exception)
                {
                    Message.InvalidInput();
                }
            }

            var product = new Product(productDescription, productUnitaryValue, productAvailable);
            return product;
        }

        void EscreveFormulario(Cliente C)
        {
          
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Customer C = new Customer();
                // Person C = new Person();
                
                Product P;
                
                P = LeituraFormulario();
                P.ValidaClasse();
                P.AddAvailableQuantity(Convert.ToInt32(Txt_QuantidadeDisponivel.Text));
                P.IncluirFichario("C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Produto");
                MessageBox.Show("Ok: Identificador incluido com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
