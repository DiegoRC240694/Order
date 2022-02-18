using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Produtos : BaseEntidade
    {
        public string connstring = string.Format("Server=localhost;Port=5432;" +
        "User Id=postgres;Password=didi240694;Database=Projeto;");
        public NpgsqlConnection conn;
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;
        public int rowIndex = -1;

        [Required(ErrorMessage = "Descrição é obrigatório.")]
        [StringLength(50, ErrorMessage = "Descrição deve ter no máximo 50 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor Unitario é obrigatória.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor Unitario deve ser um valor positivo.")]
        public decimal ValorUnitario { get; set; }

        [Required(ErrorMessage = "Quantidade disponivel é obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Quantidade disponivel somente aceita valores numéricos.")]
        public int QuantidadeDisponivel { get; set; }

        public Produtos(string descricao, decimal valorUnitario, int quantidadeDisponivel)
        {
            if (descricao == "")
                throw new ValidationException("Descrição do produto é obrigatório.");
            if (valorUnitario == -1M)
                throw new ValidationException("No campo valor digite apenas caracteres numéricos");
            if (quantidadeDisponivel == -1)
                throw new ValidationException("No campo quantidade digite apenas caracteres numéricos");
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

        public DataTable Select()
        {

            DataTable dt = new DataTable();

            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    conn.Open();
                    string cmdSeleciona = "Select * from produtos_teste order by id";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, conn))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        public void Delete()
        {
            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    //abre a conexao                
                    conn.Open();

                    string cmdDeletar = $@"Delete From produtos_teste Where id = '{Id}'";

                    using (cmd = new NpgsqlCommand(cmdDeletar, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public string ToInsert()
        {
            string SQL;
            SQL = $@"INSERT INTO produtos_teste
                        (descricao,
                         valor,
                         quantidade,
                         registro_data_hora) 
                        VALUES
            ('{Descricao}',
             '{ValorUnitario}',
             '{QuantidadeDisponivel}',
            '{RegistroDataHora:yyyy-MM-dd HH:mm:ss}')";
            return SQL;

        }

        public string ToUpdate()
        {
            string SQL;
            SQL = $@"UPDATE produtos_teste
                        SET 
             descricao = '{Descricao}',
             valor = '{ValorUnitario}',
             quantidade = '{QuantidadeDisponivel}',
             alteracao_data_hora = '{AlteracaoDataHora:yyyy-MM-dd HH:mm:ss}'
             WHERE id = {Id}";
            return SQL;

        }

        public void inserir()
        {
            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    //Abra a conexão com o PgSQL                  
                    conn.Open();
                    string sql;
                    sql = ToInsert();
                    using (cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                conn.Close();
            }
        }

        public void update()
        {
            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    //Abra a conexão com o PgSQL                  
                    conn.Open();
                    string sql;
                    sql = ToUpdate();
                    using (cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
