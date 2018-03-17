using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace S2013
{
    /* 数据库操作工具类 */
    class DB : IDisposable
    {
        SqlConnection connection;

        public DB()
        {
            String connectionString = @"Data Source=127.0.0.1;Initial Catalog=D2013;uid=sa;pwd=Yidao999!";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public DataTable GetBySQL(String sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sql, connection));
            adapter.Fill(table);

            return table;
        }

        public void SetBySQL(String sql)
        {
            (new SqlCommand(sql, connection)).ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
