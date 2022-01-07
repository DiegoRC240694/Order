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

namespace Order
{
    public partial class Frm_CadastroDeClientes : Form
    {
       
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
            //Txt_Id.Text = "";

        }

        //Customer LeituraFormulario()
        //{

        //    string firstName;
        //    string lastName;
        //    Cpf cpf = string.Empty;
        //    Email email = string.Empty;
        //    DateTime birthDate = DateTime.MinValue;


        //    firstName = Txt_NomeCliente.Text;

        //    lastName = Txt_SobrenomeCliente.Text;
        //    while (!cpf.IsValid)
        //    {

        //        cpf = Mask_CPF.Text;
        //    }

        //    while (!email.IsValid)
        //    {

        //        email = Txt_Email.Text;
        //    }

        //    while (birthDate == DateTime.MinValue)
        //    {
        //        try
        //        {

        //            birthDate = Convert.ToDateTime(Date_DataDeNascimento.Value.Date, new CultureInfo("pt-BR"));
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Data inserida no formato errado, tente novamente");
        //        }
        //    }

        //    try
        //    {
        //        var person = new Person(firstName, lastName, birthDate, cpf, email);
        //        var customer = new Customer()
        //        {
        //            Person = person,
        //            Active = true
        //        };

        //        return customer;
        //    }
        //    catch (OrderException ex)
        //    {
        //        Console.WriteLine("Erro ao cadastrar cliente:");
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro desconhecido:");
        //        Console.WriteLine(ex.Message);
        //    }

        //    return null;
        //}



        Cliente LeituraFormulario()
        {
            //Customer C = new Customer();
            //Person C = new Person();
            Cliente C = new Cliente();

            C.Cpf = Mask_CPF.Text;
            C.PrimeiroNome = Txt_NomeCliente.Text;
            C.Sobrenome = Txt_SobrenomeCliente.Text;
            C.Email = Txt_Email.Text;
            C.DataDeNascimento = Date_DataDeNascimento.Value.Date;
            return C;
        }

        void EscreveFormulario(Cliente C)
        {
            //Txt_Id.Text = C.Id.ToString();
            Mask_CPF.Text = C.Cpf;
            Txt_NomeCliente.Text = C.PrimeiroNome;
            Txt_SobrenomeCliente.Text = C.Sobrenome;
            Txt_Email.Text = C.Email;
            Date_DataDeNascimento.Value = C.DataDeNascimento;
        }

        private void Btn_SalvarNovoCliente_Click(object sender, EventArgs e)
        {

            try
            {
                //Customer C = new Customer();
                // Person C = new Person();
                //Customer C;
                Cliente C = new Cliente();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.IncluirFichario("C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");
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

        private void Btn_BuscaCPF_Click(object sender, EventArgs e)
        {
            if (Mask_CPF.Text == "")
            {
                MessageBox.Show("CPF do Cliente vazio.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    //Customer C = new Customer();
                    //Person P = new Person();
                    Cliente C = new Cliente();
                    C = C.BuscarFichario(Mask_CPF.Text, "C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");
                    
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_AtualizacaoDoCliente_Click(object sender, EventArgs e)
        {
            if (Mask_CPF.Text == "")
            {
                MessageBox.Show("CPF do Cliente vazio.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    //Customer C = new Customer();
                    Cliente C = new Cliente();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                   // C.ValidaComplemento();
                    C.AlterarFichario("C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");
                    MessageBox.Show("Ok: Identificador alterado com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_ApagarCliente_Click(object sender, EventArgs e)
        {
            if (Mask_CPF.Text == "")
            {
                MessageBox.Show("ID do Cliente vazio.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Customer C = new Customer();
                    //Person C;
                    Cliente C = new Cliente();
                    C = C.BuscarFichario(Mask_CPF.Text, "C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");

                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                        Frm_Questao Db = new Frm_Questao();
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            C.ApagarFichario("C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");
                            MessageBox.Show("Ok: Identificador apagado com sucesso ", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
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
            try
            {
                //Customer C = new Customer();
                //Person C;
                Cliente C = new Cliente();
                List<string> List = new List<string>();
                List = C.ListaFichario("C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");
                if (List == null)
                {
                    MessageBox.Show("Base de dados está vazia. Não existe nenhum identificador cadastrado", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    List<List<string>> ListaBusca = new List<List<string>>();
                    for (int i = 0; i <= List.Count - 1; i++)
                    {
                        C = Cliente.DeSerializedClassUnit(List[i]);
                        ListaBusca.Add(new List<string> { C.Cpf, C.PrimeiroNome, C.PrimeiroNome});
                    }
                    Frm_Busca FForm = new Frm_Busca(ListaBusca);
                    FForm.ShowDialog();
                    if (FForm.DialogResult == DialogResult.OK)
                    {
                        var idSelect = FForm.idSelect;
                        C = C.BuscarFichario(idSelect, "C:\\Users\\diego\\source\\repos\\DiegoRC240694\\Order\\Fichario");
                        if (C == null)
                        {
                            MessageBox.Show("Identificador não encontrado.", "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            EscreveFormulario(C);
                        }
                    }
                }

            }

            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void Btn_LimparTela_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
    }
}

            
            
        
    

