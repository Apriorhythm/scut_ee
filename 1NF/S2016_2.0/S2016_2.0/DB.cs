using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace S2016_2._0
{
    // 数据库操作工具类
    class DB : IDisposable
    {
        SqlConnection connection;

        public DB()
        {
            /*  ================ 方案 1 ================
                SqlConnectionStringBuilder ssb = new SqlConnectionStringBuilder();
                ssb.DataSource = "127.0.0.1";
                ssb.InitialCatalog = "D2016";
                ssb.UserID = "sa";
                ssb.Password = "ZheShiMiMa";
                //ssb.IntegratedSecurity = true;
                connection = new SqlConnection(ssb.ConnectionString);
                ================ 方案 1 ================ */

            /*  ================ 方案 2 ================ */
            // String connectionString = @"Data Source=127.0.0.1;Initial Catalog=D2016;uid=sa;pwd=ZheShiMiMa";
            // String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=D2016;Integrated Security=True";
            // String connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=D2016;Integrated Security=SSPI";
            String connectionString = @"Data Source= localhost\SQLEXPRESS;Initial Catalog=D2016;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            /*  ================ 方案 2 ================ */

            connection.Open();
        }

        // 获取数据，sqlParams参数化查询
        public DataTable GetBySQL(String sql, SqlParameter[] sqlParams)
        {
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(sql, connection);
            if (null != sqlParams)
                command.Parameters.AddRange(sqlParams);

            SqlDataAdapter adapter = new SqlDataAdapter(command);            
            adapter.Fill(table);

            return table;
        }

        // 更新数据，sqlParams参数化查询
        public void SetBySQL(String sql, SqlParameter[] sqlParams)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (null != sqlParams)
                command.Parameters.AddRange(sqlParams);

            command.ExecuteNonQuery();
        }

        // 释放托管的资源
        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
