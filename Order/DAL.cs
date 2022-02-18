using Npgsql;
using System;
using System.Data;

namespace Order
{
    public class DAL
    {
        public string connstring = string.Format("Server=localhost;Port=5432;" +
        "User Id=postgres;Password=didi240694;Database=Projeto;");
        public NpgsqlConnection conn;
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;
        public int rowIndex = -1;

        public DAL()
        {
            connstring = string.Format("Server=localhost;Port=5432;" +
        "User Id=postgres;Password=didi240694;Database=Projeto;");
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

        public DataTable SelectClientes()
        {

            DataTable dt = new DataTable();

            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    conn.Open();
                    string cmdSeleciona = "Select id, nome_completo, cpf from clientes_teste order by id";

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

        public DataTable Selectpedido()
        {

            DataTable dt = new DataTable();

            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    conn.Open();
                    string cmdSeleciona = "select id, descricao, valor, quantidade from produtos_teste order by id";

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
    }
}
