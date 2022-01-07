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


            Product P = new Product();
            P.Description = Txt_DescricaoDoProduto.Text;
            P.AvailableQuantity = Convert.ToInt32(Txt_QuantidadeDisponivel.Text);
            P.UnitaryValue = Convert.ToDecimal(Txt_ValorUnitarioDoProduto.Text);
            return P;
        }

     


        void EscreveFormulario(Product P)
        {
            Txt_DescricaoDoProduto.Text = P.Description;
            Txt_QuantidadeDisponivel.Text = P.UnitaryValue.ToString();
            Txt_ValorUnitarioDoProduto.Text = P.AvailableQuantity.ToString();
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

        private void Btn_VisualizarProdutos_Click(object sender, EventArgs e)
        {

            try
            {
                //Customer C = new Customer();
                //Person C;
                //Cliente C = new Cliente();
                Product P = new Product();
                
                List<string> List = new List<string>();
                List = P.ListaFichario("C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Produto");
              
                if (List == null)
                {
                    MessageBox.Show("Base de dados está vazia. Não existe nenhum identificador cadastrado", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    List<List<string>> ListaBusca = new List<List<string>>();
                    for (int i = 0; i <= List.Count - 1; i++)
                    {
                        P = Product.DeSerializedClassUnit(List[i]);
                        ListaBusca.Add(new List<string> { P.Description, P.UnitaryValue.ToString(), P.AvailableQuantity.ToString() });
                    }
                    Frm_Busca FForm = new Frm_Busca(ListaBusca);
                    FForm.ShowDialog();
                    if (FForm.DialogResult == DialogResult.OK)
                    {
                        var idSelect = FForm.idSelect;
                        P = P.BuscarFichario(idSelect, "C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Produto");
                        if (P == null)
                        {
                            MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            EscreveFormulario(P);
                        }
                    }
                }

            }

            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            
    }
}
    

