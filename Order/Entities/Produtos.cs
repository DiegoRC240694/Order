using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Produtos : BaseEntidade
    {
        [Required(ErrorMessage = "Descrição é obrigatório.")]
        [StringLength(50, ErrorMessage = "Descrição deve ter no máximo 50 caracteres.")]
        public string Descricao { get; private set; }

        [Required(ErrorMessage = "Valor Unitario é obrigatória.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor Unitario deve ser um valor positivo.")]
        public decimal ValorUnitario { get; private set; }

        [Required(ErrorMessage = "Quantidade disponivel é obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Quantidade disponivel somente aceita valores numéricos.")]
        public int QuantidadeDisponivel { get; private set; }

        public Produtos(string descricao, decimal valorUnitario, int quantidadeDisponivel)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            QuantidadeDisponivel = quantidadeDisponivel;
            base.RegistroDataHora = DateTime.Now;
        }

        public void AdicionarQuantidadeDisponivel(int quantidade)
        {
            QuantidadeDisponivel += quantidade;
        }

        public void RemoverQuantidadeDisponivel(int quantidade)
        {
            if (quantidade > QuantidadeDisponivel)
                throw new ExcecaoPedido("Quantidade disponível insuficiente");

            QuantidadeDisponivel -= quantidade;
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
    }
}
