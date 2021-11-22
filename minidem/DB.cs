using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minidem
{
    public class DB
    {
        public static SqlConnection DBConnect()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GJT134K;Initial Catalog=postirushki;Integrated Security=True");
            return conn;
        }
    }
}
