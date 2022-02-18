using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Frm_CadastroDeProduto : Form
    { //var valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor)
        //var valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "US$ {0:#,###.##}", valor)
        
        public int rowIndex = -1;
        
        public Frm_CadastroDeProduto()
        {
            InitializeComponent();
            LimparFormulario();
        }
        DAL acesso = new DAL();

        private void LimparFormulario()
        {

            Txt_DescricaoDoProduto.Text = "";
            Txt_QuantidadeDisponivel.Text = "";
            Txt_ValorUnitarioDoProduto.Text = "";

        }
        Produtos LeituraFormulario()
        {

            var produtos = new Produtos(Txt_DescricaoDoProduto.Text, Convert.ToDecimal(Txt_ValorUnitarioDoProduto.Text),
                Convert.ToInt32(Txt_QuantidadeDisponivel.Text));
            return produtos;
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int result = 0;
            Produtos produto;
            if (rowIndex < 0)
            {
                try
                {

                    produto = LeituraFormulario();
                    produto.ValidaClasse();
                    produto.inserir();
                    Dg_Produtos.DataSource = null;
                    Dg_Produtos.DataSource = produto.Select();
                    result++;
                    if (result > 0)
                    {
                        MessageBox.Show("OK: Produto cadastrado com sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        produto.Select();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir");

                    }
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
            else
            {
                var idProduto = int.Parse(Dg_Produtos.Rows[rowIndex].Cells["id"].Value.ToString());
                try
                {
                    produto = LeituraFormulario();
                    produto.ValidaClasse();
                    produto.Id = idProduto;
                    produto.update();
                    Dg_Produtos.DataSource = null;
                    Dg_Produtos.DataSource = produto.Select();
                    result++;
                    if (result > 0)
                    {
                        MessageBox.Show("OK: Atualizaçao do produto feito sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        produto.Select();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar");

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        

        

        private void Frm_CadastroDeProduto_Load(object sender, EventArgs e)
        {

           // acesso.conn = new NpgsqlConnection(produto.connstring);
            //Dg_Produtos.DataSource = null;
            Dg_Produtos.DataSource = acesso.Select();
        }

        private void Dg_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                Txt_DescricaoDoProduto.Text = Dg_Produtos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                Txt_QuantidadeDisponivel.Text = Dg_Produtos.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
                Txt_ValorUnitarioDoProduto.Text = Dg_Produtos.Rows[e.RowIndex].Cells["valor"].Value.ToString();
                  
            }
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            Produtos produto;
            var idProduto = int.Parse(Dg_Produtos.Rows[rowIndex].Cells["id"].Value.ToString());
            if (idProduto < 0)
            {
                MessageBox.Show("Escolha o produto para excluir.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    produto = LeituraFormulario();
                    produto.Id = idProduto;
                    Frm_Questao Db = new Frm_Questao();
                    Db.ShowDialog();
                    if (Db.DialogResult == DialogResult.Yes)
                    {
                        produto.Delete();
                        Dg_Produtos.DataSource = null;
                        Dg_Produtos.DataSource = produto.Select();
                        MessageBox.Show("Ok: produto apagado com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao apagar produto");

                    }

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
    }
}
    

