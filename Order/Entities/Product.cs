using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Order
{
    public class Product : EntityBase
    {
        [Required(ErrorMessage = "Descrição é obrigatório.")]
        [StringLength(50, ErrorMessage = "Descrição deve ter no máximo 50 caracteres.")]
        public string Description { get;  set; }

        [Required(ErrorMessage = "Quantidade é obrigatório.")]
        public decimal UnitaryValue { get;  set; }

        [Required(ErrorMessage = "Valor do Produto é obrigatório.")]
        public int AvailableQuantity { get; set; }

        //public Product(string description, decimal unitaryValue, int availableQuantity)
        //{
        //    Description = description;
        //    UnitaryValue = unitaryValue;
        //    AvailableQuantity = availableQuantity;
        //    base.DateHourRegister = DateTime.Now;
        //}

        public void AddAvailableQuantity(int quantity)
        {
            AvailableQuantity += quantity;
        }

        public void RemoveAvailableQuantity(int quantity)
        {
            if (quantity > AvailableQuantity)
                throw new OrderException("Quantidade disponível insuficiente");

            AvailableQuantity -= quantity;
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
            string ProdutoJson = Product.SerializedClassUnit(this);
            Fichario F = new Fichario(conexao);
            // Entity en = new Entity();
            if (F.status)
            {
                // F.Incluir(en.Id.ToString(), clienteJson);
                F.Incluir(Description, ProdutoJson);
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

        public Product BuscarFichario(string cpf, string conexao)
        {

            Fichario F = new Fichario(conexao);
            if (F.status)
            {
                string clienteJson = F.Buscar(cpf);
                return Product.DeSerializedClassUnit(clienteJson);
            }
            else
            {
                throw new Exception(F.mensagem);
            }
        }

        public static Product DeSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Product>(vJson);
        }

        public static string SerializedClassUnit(Product produto)
        {
            return JsonConvert.SerializeObject(produto);
        }
    }
}
