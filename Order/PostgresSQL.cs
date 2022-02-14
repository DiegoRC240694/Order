using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class PostgresSQL
    {
        public string connstring = string.Format("Server=localhost;Port=5432;" +
          "User Id=postgres;Password=didi240694;Database=Projeto;");
        public NpgsqlConnection conn;
        public string sql;
        public NpgsqlCommand cmd;
        public DataTable dt;
        public int rowIndex = -1;

        public void Select()
        {

        }
    }
}
