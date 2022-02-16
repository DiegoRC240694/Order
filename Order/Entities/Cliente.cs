
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Order
{
    public class Cliente : BaseEntidade
    {
        public string connstring = string.Format("Server=localhost;Port=5432;" +
        "User Id=postgres;Password=didi240694;Database=Projeto;");
        public NpgsqlConnection conn;
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;
        public int rowIndex = -1;

        public Pessoa Pessoa { get; set; }
        public bool Ativo { get; set; }

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
                    string cmdSeleciona = "Select * from clientes_teste order by id";

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

        public string ToInsert()
        {
           
                string SQL;
                SQL = $@"INSERT INTO clientes_teste
                        (nome,
                         sobrenome,
                         nome_completo,
                         data_nascimento,
                         idade,
                         cpf,
                         email,
                         registro_data_hora) 
                        VALUES
            ('{Pessoa.PrimeiroNome}',
             '{Pessoa.UltimoNome}',
             '{Pessoa.NomeCompleto}',
             '{Pessoa.DataNascimento:yyyy-MM-dd HH:mm:ss}',
             '{Pessoa.Idade}',
             '{Pessoa.Cpf}',
             '{Pessoa.Email}',
            '{RegistroDataHora::yyyy-MM-dd HH:mm:ss}')";
                return SQL;
          
           

        }
    }
}
