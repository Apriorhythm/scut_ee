using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DB : IDisposable
    {
        private SqlConnection connection;
        public DB()
        {
            String connectionString = @"Data Source=127.0.0.1;Initial Catalog=AprioriDB;uid=sa;pwd=Yidao999!";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public DataTable GetBySQL(String sqlString)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(sqlString, connection));
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public void SetBySQL(String sqlString)
        {
            new SqlCommand(sqlString, connection).ExecuteNonQuery();
        }


        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
