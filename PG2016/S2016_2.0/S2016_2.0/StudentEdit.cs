using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace S2016_2._0
{
    public partial class StudentEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Student s;

        public StudentEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {
            sql = @"SELECT [classNo] FROM [CLASS]";
            table = db.GetBySQL(sql, null);
            comboBox1.DataSource = table;
            comboBox1.ValueMember = "classNo";

            if (Intent.STATE == "ADD")
            {
                s = new Student();
            }
            else
            {
                textBox1.Text = s.SNo;
                textBox2.Text = s.SName;
                dateTimePicker1.Value = Convert.ToDateTime(s.Date);
                comboBox1.SelectedValue = s.classNo;
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            s.SetValue(
                textBox1.Text,
                textBox2.Text,
                dateTimePicker1.Value.ToShortDateString(),
                comboBox1.SelectedValue.ToString()
            );

            if ("" == s.SNo || "" == s.SName)
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            Regex r = new Regex("[0-9]+");
            if (!r.IsMatch(s.SNo))
            {
                MessageBox.Show("学生编号请使用数字");
                return;
            }

            sql = @"" +
                " SELECT * FROM [Student]" +
                " WHERE [SNo]=@SNo";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@SNo", s.SNo),
            };
            table = db.GetBySQL(sql, sqlParams);

            if (Intent.STATE == "ADD" || Intent.OLD_ID != s.SNo)
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("学生编号重复");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
