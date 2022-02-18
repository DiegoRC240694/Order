using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Order
{
    public class ItemPedido : BaseEntidade
    {
        public Produtos Produtos { get;  set; }
        public int Quantidade { get;  set; }
        public decimal ValorTotal => Quantidade * Produtos.ValorUnitario;

        public ItemPedido(Produtos produtos, int quantidade)
        {
            Produtos = produtos;

            if (quantidade <= 0)
                throw new ExcecaoPedido("Quantidade inválida. Informe uma quantidade igual ou superior a um.");

            if (quantidade > produtos.QuantidadeDisponivel)
                throw new ExcecaoPedido("Quantidade inválida. Informe uma quantidade menor ou igual a quantidade máxima disponível.");

            Quantidade = quantidade;
            base.RegistroDataHora = DateTime.Now;
            produtos.RemoverQuantidadeDisponivel(quantidade);
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
