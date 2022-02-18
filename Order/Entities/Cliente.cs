
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

        public void Delete()
        {
            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    //abre a conexao                
                    conn.Open();

                    string cmdDeletar = $@"Delete From clientes_teste Where id = '{Id}'";

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
            '{RegistroDataHora:yyyy-MM-dd HH:mm:ss}')";
                return SQL;
         
        }

        public string ToUpdate()
        {
            string SQL;
            SQL = $@"UPDATE clientes_teste
                        SET 
             nome = '{Pessoa.PrimeiroNome}',
             sobrenome = '{Pessoa.UltimoNome}',
             nome_completo = '{Pessoa.NomeCompleto}',
             data_nascimento = '{Pessoa.DataNascimento:yyyy-MM-dd HH:mm:ss}',
             idade = {Pessoa.Idade},
             cpf = '{Pessoa.Cpf}',
             email = '{Pessoa.Email}',
             registro_data_hora = '{AlteracaoDataHora:yyyy-MM-dd HH:mm:ss}'
             WHERE id = {Id}";
            return SQL;

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
