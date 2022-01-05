using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Order
{
    public class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                var actualDate = DateTime.Now;
                var age = actualDate.Year - BirthDate.Year;

                if (actualDate.Month < BirthDate.Month)
                    age--;

                return age;
            }
        }
        [Required(ErrorMessage = "CPF obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
        public Cpf Cpf { get; set; }
        public Email Email { get; set; }

        

        //public Person(string firstName, string lastName, DateTime birthDate, Cpf cpf, Email email)
        //{
        //    FirstName = firstName.Trim();
        //    LastName = lastName.Trim();

        //    if (DateTime.Now.Year - birthDate.Year > 110)
        //        throw new OrderException("Idade superior a 110 anos não permitida!");

        //    if (!cpf.IsValid)
        //        throw new OrderException("Cpf inválido!");

        //    if (!email.IsValid)
        //        throw new OrderException("E-mail inválido!");

        //    BirthDate = birthDate;
        //    Cpf = cpf;
        //    Email = email;
        //    base.DateHourRegister = DateTime.Now;
        //}

        public string FullName =>
            $"{FirstName} {LastName}";

        public void ValidaComplemento()
        {
            if (DateTime.Now.Year - BirthDate.Year > 110)
                throw new OrderException("Idade superior a 110 anos não permitida!");
            
            if (!Cpf.IsValid)
                throw new OrderException("Cpf inválido!");

            if (!Email.IsValid)
                throw new OrderException("E-mail inválido!");
        }

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

        public void IncluirFichario(string conexao)
        {
            string clienteJson = Person.SerializedClassUnit(this);
            Fichario F = new Fichario(conexao);
            Entity en = new Entity();
            if (F.status)
            {
                F.Incluir(en.Id.ToString(), clienteJson);
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

        public Person BuscarFichario(string cpf, string conexao)
        {

            Fichario F = new Fichario(conexao);
            if (F.status)
            {
                string clienteJson = F.Buscar(cpf);
                return Person.DeSerializedClassUnit(clienteJson);
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }

        public void AlterarFichario(string conexao)
        {
            string clienteJson = Person.SerializedClassUnit(this);
            Fichario F = new Fichario(conexao);
            Entity en = new Entity();
            if (F.status)
            {
                F.Alterar(en.Id.ToString(), clienteJson);
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

        public static Person DeSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Person>(vJson);
        }

        public static string SerializedClassUnit(Person person)
        {
            return JsonConvert.SerializeObject(person);
        }

    }
}
