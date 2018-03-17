using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace S2017
{
    class DB : IDisposable
    {
        SqlConnection connection;

        public DB()
        {
            String connectionString = @"Data Source=127.0.0.1;Initial Catalog=D2017;uid=sa;pwd=Yidao999!";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public DataTable GetBySQL(String sqlString)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sqlString, connection));
            adapter.Fill(table);

            return table;
        }

        public void SetBySQL(String sqlString)
        {
            (new SqlCommand(sqlString, connection)).ExecuteNonQuery();
        }


        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
