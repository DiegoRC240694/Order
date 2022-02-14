using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using Newtonsoft.Json;
//using CursoWindowsFormsBiblioteca.Databases;
using System.Data;

namespace Order
{
    public class Pessoa : BaseEntidade
    {
        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
        public string UltimoNome { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatório.")]
        public DateTime DataNascimento { get; set; }
        public int Idade
        {
            get
            {
                var dataAtual = DateTime.Now;
                var idade = dataAtual.Year - DataNascimento.Year;

                if (dataAtual.Month < DataNascimento.Month)
                    idade--;

                return idade;
            }
        }
        [Required(ErrorMessage = "CPF obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
        public Cpf Cpf { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [StringLength(50, ErrorMessage = "Email deve ter no máximo 50 caracteres.")]
        public Email Email { get; set; }


        public Pessoa(string primeiroNome, string ultimoNome, DateTime dataNascimento, Cpf cpf, Email email)
        {
            PrimeiroNome = primeiroNome.Trim();
            UltimoNome = ultimoNome.Trim();

            if (DateTime.Now.Year - dataNascimento.Year > 110)
                throw new ExcecaoPedido("Idade superior a 110 anos não permitida!");

            if (!cpf.EValido)
                throw new ExcecaoPedido("Cpf inválido!");

            if (!email.EValido)
                throw new ExcecaoPedido("E-mail inválido!");

            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
            base.RegistroDataHora = DateTime.Now;
        }

        public string NomeCompleto =>
            $"{PrimeiroNome} {UltimoNome}";

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
    }




}
