using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
   public class Cliente : EntityBase
    {
        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
        public string Sobrenome { get; set; }
       
        [Required(ErrorMessage = "Data de Nascimento é obrigatório.")]
        public DateTime DataDeNascimento { get; set; }

       // public long ID { get; set; }
        public int Age
        { 
            get
            {
                var actualDate = DateTime.Now;
                var age = actualDate.Year - DataDeNascimento.Year;

                if (actualDate.Month < DataDeNascimento.Month)
                    age--;

                return age;
            }
        }

        [Required(ErrorMessage = "CPF obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [StringLength(50, ErrorMessage = "Email deve ter no máximo 50 caracteres.")]
        public string Email { get; set; }

        //public Cliente(string primeironome, string sobrenome, DateTime datadenascimento, string cpf, string email)
        //{
        //    ID = 0;
        //    PrimeiroNome = primeironome.Trim();
        //    Sobrenome = sobrenome.Trim();

        //    if (DateTime.Now.Year - DataDeNascimento.Year > 110)
        //        throw new OrderException("Idade superior a 110 anos não permitida!");

        //    bool validacpf = Valida.CPF(this.Cpf);
        //    if (validacpf == false)
        //        throw new OrderException("Cpf inválido!");

        //    bool validaemail = Valida.Email(this.Email);
        //    if (validaemail == false)
        //        throw new OrderException("E-mail inválido!");

        //    DataDeNascimento = datadenascimento;
        //    Cpf = cpf;
        //    Email = Email;
        //    base.DateHourRegister = DateTime.Now;


        //}

        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }

        }

        public void ValidaComplemento()
        {
            if (DateTime.Now.Year - DataDeNascimento.Year > 110)
                throw new OrderException("Idade superior a 110 anos não permitida!");

            bool validacpf = Valida.CPF(this.Cpf);
            if (validacpf == false)
                throw new OrderException("Cpf inválido!");

            bool validaemail = Valida.Email(this.Email);
            if (validaemail == false)
                throw new OrderException("E-mail inválido!");

            base.DateHourRegister = DateTime.Now;
        }

        public void IncluirFichario(string conexao)
        {
            string clienteJson = Cliente.SerializedClassUnit(this);
            Fichario F = new Fichario(conexao);
           // Entity en = new Entity();
            if (F.status)
            {
                // F.Incluir(en.Id.ToString(), clienteJson);
                F.Incluir(Id.ToString(), clienteJson);
                if (!(F.status))
                {
                    throw new Exception(F.mensagem);

                }
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }

        public Cliente BuscarFichario(string cpf, string conexao)
        {

            Fichario F = new Fichario(conexao);
            if (F.status)
            {
                string clienteJson = F.Buscar(Id.ToString());
                return Cliente.DeSerializedClassUnit(clienteJson);
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }

        public void AlterarFichario(string conexao)
        {
            string clienteJson = Cliente.SerializedClassUnit(this);
            Fichario F = new Fichario(conexao);
           // Entity en = new Entity();
            if (F.status)
            {
                // F.Alterar(en.Id.ToString(), clienteJson);
                F.Alterar(Id.ToString(), clienteJson);
                if (!(F.status))
                {
                    throw new Exception(F.mensagem);
                }
            }
            else
            {
                throw new Exception(F.mensagem);
            }

        }

        public void ApagarFichario(string conexao)
        {
            Fichario F = new Fichario(conexao);
            //Entity en = new Entity();
            if (F.status)
            {
               // F.Apagar(en.Id.ToString());
                F.Apagar(Id.ToString());
                if (!(F.status))
                {
                    throw new Exception(F.mensagem);
                }
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }

        public List<List<string>> BuscarFicharioTodos(string conexao)
        {
            Fichario F = new Fichario(conexao);
            //Entity en = new Entity();
            if (F.status)
            {
                List<string> List = new List<string>();
                List = F.BuscarTodos();
                if (F.status)
                {
                    List<List<string>> ListaBusca = new List<List<string>>();
                    for (int i = 0; i <= List.Count - 1; i++)
                    {
                        Cliente C = Cliente.DeSerializedClassUnit(List[i]);
                        //ListaBusca.Add(new List<string> { en.Id.ToString(), C.PrimeiroNome });
                        ListaBusca.Add(new List<string> { Id.ToString(), C.PrimeiroNome });
                    }
                    return ListaBusca;
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }

        public List<string> ListaFichario(string conexao)
        {
            Fichario F = new Fichario(conexao);
            if (F.status)
            {
                List<string> todosJson = F.BuscarTodos();
                return todosJson;
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }


        public static Cliente DeSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Cliente>(vJson);
        }

        public static string SerializedClassUnit(Cliente cliente)
        {
            return JsonConvert.SerializeObject(cliente);
        }
    }
}
