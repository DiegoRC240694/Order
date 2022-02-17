using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Npgsql;

namespace Order
{
    public partial class Frm_CadastroDeClientes : Form
    {
        public string connstring = string.Format("Server=localhost;Port=5432;" +
         "User Id=postgres;Password=didi240694;Database=Projeto;");
        public NpgsqlConnection conn;
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;
        public int rowIndex = -1;
       



        public Frm_CadastroDeClientes()
        {
            InitializeComponent();
            LimparFormulario();
          
        }

        private void LimparFormulario()
        {

            Mask_CPF.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_SobrenomeCliente.Text = "";
            Txt_Email.Text = "";
            Date_DataDeNascimento.Value = DateTime.Now.Date;
            
        }


        Pessoa LeituraFormulario()
        {
            try
            {

                var pessoa = new Pessoa(Txt_NomeCliente.Text, Txt_SobrenomeCliente.Text, 
                    Convert.ToDateTime(Date_DataDeNascimento.Value.Date, new CultureInfo("pt-BR")),
                   Mask_CPF.Text, Txt_Email.Text);
            
                return pessoa;
            }
            catch (ValidationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
        
        private void Btn_SalvarNovoCliente_Click(object sender, EventArgs e)
        {
            int result = 0;
            Cliente cliente = new Cliente();
            
            if (rowIndex < 0)
            {

                try
                {
                   
                    cliente.Pessoa = LeituraFormulario();
                    cliente.Pessoa.ValidaClasse();
                    cliente.inserir();
                    Dg_Clientes.DataSource = null;
                    Dg_Clientes.DataSource = cliente.Select();
                    result++;
                    if (result > 0)
                    {
                        MessageBox.Show("OK: Cliente cadastrado com sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cliente.Select();
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
                var idCliente = int.Parse(Dg_Clientes.Rows[rowIndex].Cells["id"].Value.ToString());
                try
                {
                    cliente.Pessoa = LeituraFormulario();
                    cliente.Pessoa.ValidaClasse();
                    cliente.Id = idCliente;
                    cliente.update();
                    Dg_Clientes.DataSource = null;
                    Dg_Clientes.DataSource = cliente.Select();
                    result++;
                    if (result > 0)
                    {
                        MessageBox.Show("OK: Atualizaçao do cliente feito sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cliente.Select();
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

        private void Btn_BuscaCPF_Click(object sender, EventArgs e)
        {
            //if (Mask_CPF.Text == "")
            //{
            //    MessageBox.Show("CPF do Cliente vazio.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //else
            //{
            //    try
            //    {
            //        Customer C = new Customer();
            //       // Person P;
            //        //Cliente C = new Cliente();
            //        C.Person = C.Person.BuscarFichario(Mask_CPF.Text, "C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");
                    
            //        if (C == null)
            //        {
            //            MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            EscreveFormulario(C);
            //        }
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }


        private void Btn_ApagarCliente_Click(object sender, EventArgs e)
        {
           
            
            Cliente cliente = new Cliente();
            var idCliente = int.Parse(Dg_Clientes.Rows[rowIndex].Cells["id"].Value.ToString());
            if (idCliente < 0)
            {
                MessageBox.Show("Escolha o cliente para excluir.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    cliente.Pessoa = LeituraFormulario();
                    cliente.Id = idCliente;
                    Frm_Questao Db = new Frm_Questao();
                    Db.ShowDialog();
                    if (Db.DialogResult == DialogResult.Yes)
                    {
                        cliente.Delete();
                        Dg_Clientes.DataSource = null;
                        Dg_Clientes.DataSource = cliente.Select();
                        MessageBox.Show("Ok: Cliente apagado com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao apagar cliente");

                    }
    
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Customer C = new Customer();
            //   // Person P;
            //   // Cliente C = new Cliente();
            //    List<string> List = new List<string>();
            //    List = C.Person.ListaFichario("C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");
            //    if (List == null)
            //    {
            //        MessageBox.Show("Base de dados está vazia. Não existe nenhum identificador cadastrado", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {

            //        List<List<string>> ListaBusca = new List<List<string>>();
            //        for (int i = 0; i <= List.Count - 1; i++)
            //        {
            //            C.Person = Person.DeSerializedClassUnit(List[i]);
            //            ListaBusca.Add(new List<string> { C.Person.Cpf.ToString(), C.Person.FirstName, C.Person.LastName});
            //        }
            //        Frm_Busca FForm = new Frm_Busca(ListaBusca);
            //        FForm.ShowDialog();
            //        if (FForm.DialogResult == DialogResult.OK)
            //        {
            //            var idSelect = FForm.idSelect;
            //            C.Person = C.Person.BuscarFichario(idSelect, "C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");
            //            if (C == null)
            //            {
            //                MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //            else
            //            {
            //                EscreveFormulario(C);
            //            }
            //        }
            //    }

            //}

            //catch (Exception Ex)
            //{

            //    MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}




        }

        private void Btn_LimparTela_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void Dg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                Txt_NomeCliente.Text = Dg_Clientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                Txt_SobrenomeCliente.Text = Dg_Clientes.Rows[e.RowIndex].Cells["sobrenome"].Value.ToString();
                Date_DataDeNascimento.Value = Convert.ToDateTime(Dg_Clientes.Rows[e.RowIndex].Cells["data_nascimento"].Value, new CultureInfo("pt-BR"));
                Mask_CPF.Text = Dg_Clientes.Rows[e.RowIndex].Cells["cpf"].Value.ToString();//////
                Txt_Email.Text = Dg_Clientes.Rows[e.RowIndex].Cells["email"].Value.ToString();


            }
        }

        private void Frm_CadastroDeClientes_Load(object sender, EventArgs e)
        {
             
            Cliente C = new Cliente();
            C.conn = new NpgsqlConnection(C.connstring);
            Dg_Clientes.DataSource = null;
            Dg_Clientes.DataSource = C.Select();
            
        }

       


    }
}

            
            
        
    

