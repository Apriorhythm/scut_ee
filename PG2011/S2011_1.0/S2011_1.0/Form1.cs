using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class Form1 : Form
    {
        DB db;
        String sql;
        DataTable table;
           
        
        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String pwd = textBox2.Text;

            if ("" == id || "" == pwd)
            {
                MessageBox.Show("请填写完整空余项");
                return;
            }

            if (id == "root")
            {
                if (pwd == "666")
                {
                    RootMainForm rootMainForm = new RootMainForm();
                    rootMainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号密码错误");
                    return;
                }
            }
            else
            {
                sql = @"" +
                    " SELECT * FROM [Driver]" +
                    " WHERE [DNo]='" + id + "'" +
                    "   AND [Password]='" + pwd + "'";
                table = db.GetBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    DriverMainForm dm = new DriverMainForm();
                    Driver d = new Driver();
                    d.SetValue(
                        table.Rows[0][0].ToString(),
                        table.Rows[0][1].ToString(),
                        table.Rows[0][2].ToString(),
                        table.Rows[0][3].ToString(),
                        table.Rows[0][4].ToString(),
                        table.Rows[0][5].ToString()
                    );
                    dm.d = d;

                    dm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号密码错误");
                    return;
                }
                return;
            }
        }
    }
}
