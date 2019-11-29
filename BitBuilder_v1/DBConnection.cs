using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder_v1
{
    class DBconnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BitBuilder_v2;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();

        public DBconnection()
        { }



        public void Inserts(string query) // insert / update / delete
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Select(string query) // select query
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter dt_adapter = new SqlDataAdapter(cmd);
            DataTable d_table = new DataTable();
            dt_adapter.Fill(d_table);
            conn.Close();
            return d_table;
        }
    }
    
}
