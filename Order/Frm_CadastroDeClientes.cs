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
            
        }

        Customer LeituraFormulario()
        {
            Customer C = new Customer();
            C.Person.Cpf = Mask_CPF.Text;
            C.Person.FirstName = Txt_NomeCliente.Text;
            C.Person.LastName = Txt_SobrenomeCliente.Text;
            C.Person.Email = Txt_Email.Text;
            C.Person.BirthDate = Date_DataDeNascimento.Value;
            return C;
        }

        void EscreveFormulario(Customer C)
        {
            Mask_CPF.Text = C.Person.Cpf.ToString();
            Txt_NomeCliente.Text = C.Person.FirstName;
            Txt_SobrenomeCliente.Text = C.Person.LastName;
            Txt_Email.Text = C.Person.Email.ToString();
            Date_DataDeNascimento.Value = C.Person.BirthDate;
        }

        private void Btn_SalvarNovoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Customer C = new Customer();
                C = LeituraFormulario();
                C.Person.ValidaClasse();
                C.Person.IncluirFichario("C:\\Users\\DiegoRodriguesCardos\\source\\repos\\Order\\Fichario");
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
                    Customer C = new Customer();
                    C.Person = C.Person.BuscarFichario(Mask_CPF.Text, "C:\\Users\\DiegoRodriguesCardos\\source\\repos\\LojaDeProdutos\\Fichario");
                    //EscreveFormulario(C);
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_AtualizacaoDoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
