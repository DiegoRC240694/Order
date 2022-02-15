//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
////using Newtonsoft.Json;
////using CursoWindowsFormsBiblioteca.Databases;
//using System.Data;

//namespace Order
//{
//    public class Pessoa : BaseEntidade
//    {
//        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
//        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
//        public string PrimeiroNome { get; set; }

//        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
//        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
//        public string UltimoNome { get; set; }

//        [Required(ErrorMessage = "Data de Nascimento é obrigatório.")]
//        public DateTime DataNascimento { get; set; }
//        public int Idade
//        {
//            get
//            {
//                var dataAtual = DateTime.Now;
//                var idade = dataAtual.Year - DataNascimento.Year;

//                if (dataAtual.Month < DataNascimento.Month)
//                    idade--;

//                return idade;
//            }
//        }
//        [Required(ErrorMessage = "CPF obrigatório.")]
//        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
//        public Cpf Cpf { get; set; }

//        [Required(ErrorMessage = "Email é obrigatório.")]
//        [StringLength(50, ErrorMessage = "Email deve ter no máximo 50 caracteres.")]
//        public Email Email { get; set; }


//        public Pessoa(string primeiroNome, string ultimoNome, DateTime dataNascimento, Cpf cpf, Email email)
//        {
//            PrimeiroNome = primeiroNome.Trim();
//            UltimoNome = ultimoNome.Trim();

//            if (DateTime.Now.Year - dataNascimento.Year > 110)
//                throw new ExcecaoPedido("Idade superior a 110 anos não permitida!");

//            if (!cpf.EValido)
//                throw new ExcecaoPedido("Cpf inválido!");

//            if (!email.EValido)
//                throw new ExcecaoPedido("E-mail inválido!");

//            DataNascimento = dataNascimento;
//            Cpf = cpf;
//            Email = email;
//            base.RegistroDataHora = DateTime.Now;
//        }

//        public string NomeCompleto =>
//            $"{PrimeiroNome} {UltimoNome}";

//        public void ValidaClasse()
//        {
//            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
//            List<ValidationResult> results = new List<ValidationResult>();
//            bool isValid = Validator.TryValidateObject(this, context, results, true);

//            if (isValid == false)
//            {
//                StringBuilder sbrErrors = new StringBuilder();
//                foreach (var validationResult in results)
//                {
//                    sbrErrors.AppendLine(validationResult.ErrorMessage);
//                }
//                throw new ValidationException(sbrErrors.ToString());
//            }
//        }
//    }

//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using Newtonsoft.Json;
//using CursoWindowsFormsBiblioteca.Databases;
using System.Data;
using Npgsql;

namespace Order
{
    public class Pessoa : BaseEntidade
    {
        public string connstring = string.Format("Server=localhost;Port=5432;" +
         "User Id=postgres;Password=didi240694;Database=Projeto;");
        public NpgsqlConnection conn;
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;
        public int rowIndex = -1;

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
            set { Idade = value; }
            
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

        public string ToInsert()
        {
            string SQL;
            SQL = @"INSERT INTO clientes_teste
                        (nome,
                         sobrenome,
                         nome_completo,
                         data_nascimento,
                         idade,
                         cpf,
                         email,
                         registro_data_hora) 
                        VALUES ";
            SQL += "('" + this.PrimeiroNome + "'";
            SQL += ",'" + this.UltimoNome + "'";
            SQL += ",'" + this.NomeCompleto + "'";
            SQL += ",'" + this.DataNascimento + "'";
            SQL += "," +  this.Idade + ",";
            SQL += "'" + this.Cpf + "'";
            SQL += "," + this.Email + ",";
            SQL += "'" + this.RegistroDataHora + ");";
            return SQL;

        }

        public string ToUpdate(long Id)
        {
            string SQL;
            SQL = @"UPDATE clientes_teste
                        SET ";
            SQL += "id = '" + this.Id + "'";
            SQL += " , nome = '" + this.PrimeiroNome + "'";
            SQL += " , sobrenome = '" + this.UltimoNome + "'";
            SQL += " , nome_completo = '" + this.NomeCompleto + "'";
            SQL += " , data_nascimento = " + this.DataNascimento + "";
            SQL += " , idade = '" + this.Idade + "'";
            SQL += " , cpf = " + this.Cpf + "";
            SQL += " , email = '" + this.Email + "'";
            SQL += " , registro_data_hora = '" + this.RegistroDataHora + "";
            SQL += " WHERE id = '" + Id + "';";
            return SQL;

        }

        //public Pessoa DataRowToUnit(DataRow dr)
        //{

        //   // Pessoa P = new Pessoa(); 

        //   // P.Id = (long)dr["id"];
        //   // P.PrimeiroNome = dr["nome"].ToString();
        //   // P.UltimoNome = dr["sobrenome"].ToString();
        //   //// P.NomeCompleto = dr["nome_completo"].ToString();
        //   // P.DataNascimento = Convert.ToDateTime(dr["data_nascimento"]);
        //   // P.Idade = (int)dr["idade"];
        //   //// P.Cpf = dr["cpf"].ToString();
        //   // P.Email = dr["email"].ToString();
        //   // P.RegistroDataHora = Convert.ToDateTime(dr["registro_data_hora"]);
        //   // return P;

        //}

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
                    sql = this.ToInsert();
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

