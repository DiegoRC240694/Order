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
    public partial class Frm_RegistroDePedido : Form
    {
        public int rowIndex = -1;
        DAL acesso =  new DAL();
        public Frm_RegistroDePedido()
        {
            InitializeComponent();
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            Txt_NomeCliente.Text = "";
            Txt_Descricao.Text = "";
            Txt_Quantidade.Text = "";
            Txt_ValorTotal.Text = "";
        }

        ItemPedido LeituraFormulario()
        {
            var produto = new Produtos(Txt_Descricao.Text, Convert.ToDecimal(Txt_ValorTotal), Convert.ToInt32(Txt_ValorTotal));
            var itempedido = new ItemPedido(produto, int.Parse(Txt_Quantidade.Text));
            return(itempedido); 
        }
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            //int result = 0;
            //Produtos produto;
            //if (rowIndex < 0)
            //{
            //    try
            //    {

            //        produto = LeituraFormulario();
            //        produto.ValidaClasse();
            //        produto.inserir();
            //        Dg_Produtos.DataSource = null;
            //        Dg_Produtos.DataSource = produto.Select();
            //        result++;
            //        if (result > 0)
            //        {
            //            MessageBox.Show("OK: Produto cadastrado com sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            produto.Select();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Falha ao inserir");

            //        }
            //    }
            //    catch (ValidationException Ex)
            //    {
            //        MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    var idProduto = int.Parse(Dg_Produtos.Rows[rowIndex].Cells["id"].Value.ToString());
            //    try
            //    {
            //        produto = LeituraFormulario();
            //        produto.ValidaClasse();
            //        produto.Id = idProduto;
            //        produto.update();
            //        Dg_Produtos.DataSource = null;
            //        Dg_Produtos.DataSource = produto.Select();
            //        result++;
            //        if (result > 0)
            //        {
            //            MessageBox.Show("OK: Atualizaçao do produto feito sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            produto.Select();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Falha ao atualizar");

            //        }
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void Frm_RegistroDePedido_Load(object sender, EventArgs e)
        {
            Dg_Produtos.DataSource = acesso.Select();
            Dg_Clientes.DataSource = acesso.SelectClientes();   
            Dg_Pedido.DataSource = acesso.Selectpedido(); 
        }

        private void Dg_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                Txt_Descricao.Text = Dg_Produtos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                Txt_Quantidade.Text = Dg_Produtos.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
                Txt_ValorTotal.Text = Dg_Produtos.Rows[e.RowIndex].Cells["valor"].Value.ToString();

            }
        }

        private void Dg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Txt_NomeCliente.Text = Dg_Clientes.Rows[e.RowIndex].Cells["nome_cliente"].Value.ToString();
            }
           
        }

        private void Dg_Pedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Txt_NomeCliente.Text = Dg_Clientes.Rows[e.RowIndex].Cells["nome_cliente"].Value.ToString();
                Txt_Descricao.Text = Dg_Produtos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                Txt_Quantidade.Text = Dg_Pedido.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
                Txt_ValorTotal.Text = Dg_Pedido.Rows[e.RowIndex].Cells["valor_total"].Value.ToString();
            }
        }
    }
}
