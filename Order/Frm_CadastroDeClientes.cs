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


       private Pessoa LeituraFormulario()
        {

            //string primeiroNome;
            //string ultimoNome;
            //Cpf cpf;
            //Email email;
            //DateTime dataNascimento;
            Pessoa P = new Pessoa();

            P.PrimeiroNome = Txt_NomeCliente.Text;

            P.UltimoNome = Txt_SobrenomeCliente.Text;


            P.Cpf = Mask_CPF.Text;


            P.Email = Txt_Email.Text;

            P.DataNascimento = Convert.ToDateTime(Date_DataDeNascimento.Value.Date, new CultureInfo("pt-BR"));
            
            try
            {
                //var pessoa = new Pessoa(primeiroNome, ultimoNome, dataNascimento, cpf, email);
                P.validapessoa();
                var cliente = new Cliente()
                {
                    //Pessoa = pessoa,
                    Ativo = true
                };

                return P;
            }
            catch (ValidationException)
            {
                //MessageBox.Show("Erro ao cadastrar cliente:");
                //MessageBox.Show(ex.Message);
                throw;
            }
            catch (Exception)
            {
                //MessageBox.Show("Erro desconhecido:");
                //MessageBox.Show(ex.Message);
                throw;
            }

           

        }


        private void Btn_SalvarNovoCliente_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0)
            {
                Cliente C = new Cliente();
                try
                {
                   
                    LeituraFormulario();
                   
                    C.inserir();
                    Dg_Clientes.DataSource = C.Select();
                    Dg_Clientes.DataSource = null;
                    result++;
                    if (result > 0)
                    {
                        MessageBox.Show("OK: Indentificador incluido com sucesso", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        C.Pessoa.Select();
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

        private void Btn_AtualizacaoDoCliente_Click(object sender, EventArgs e)
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
            //        // Cliente C = new Cliente();
            //        Person P;
            //        P = LeituraFormulario();
            //        C.Person.ValidaClasse();
            //       // C.ValidaComplemento();
            //        C.Person.AlterarFichario("C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");
            //        MessageBox.Show("Ok: Identificador alterado com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void Btn_ApagarCliente_Click(object sender, EventArgs e)
        {
            //if (Mask_CPF.Text == "")
            //{
            //    MessageBox.Show("ID do Cliente vazio.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    try
            //    {
            //        Customer C = new Customer();
            //        //Person C;
            //        // Cliente C = new Cliente();
            //        C.Person = C.Person.BuscarFichario(Mask_CPF.Text, "C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");

            //        if (C == null)
            //        {
            //            MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            EscreveFormulario(C);
            //            Frm_Questao Db = new Frm_Questao();
            //            Db.ShowDialog();
            //            if (Db.DialogResult == DialogResult.Yes)
            //            {
            //                C.Person.ApagarFichario("C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");
            //                MessageBox.Show("Ok: Identificador apagado com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                LimparFormulario();
            //            }
            //        }
            //    }

            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
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
            Dg_Clientes.DataSource = C.Select();
           // Dg_Clientes.DataSource = null;



        }

       


    }
}

            
            
        
    

