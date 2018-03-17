using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class DriverMainForm : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Driver d;

        public DriverMainForm()
        {
            InitializeComponent();
            db = new DB();
        }

        private void DriverMainForm_Load(object sender, EventArgs e)
        {

            textBox1.Text = d.DNo;
            textBox2.Text = d.DName;
            if (d.Gender == "男")
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = 1;
            numericUpDown1.Value = Convert.ToInt32(d.Age);
            textBox3.Text = d.Phone;
            textBox4.Text = d.Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Driver newDriver = new Driver();
            newDriver.SetValue(
                textBox1.Text,
                textBox2.Text,
                comboBox1.SelectedItem.ToString(),
                numericUpDown1.Value.ToString(),
                textBox3.Text,
                textBox4.Text
            );

            if (d.DNo == "" || d.DName == "" || d.Phone == "" || d.Password == "")
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            if (Intent.State == "ADD" || newDriver.DNo != d.DNo)
            {
                sql = @"" +
                    " SELECT * FROM [Driver]" +
                    " WHERE [DNo]='" + newDriver.DNo + "'";
                table = db.GetBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("员工号重复，请重新填写");
                    return;
                }
            }

            sql = @"" +
                " UPDATE [Driver]" +
                " SET" +
                "   [DNo]='" + newDriver.DNo + "'," +
                "   [DName]='" + newDriver.DName + "'," +
                "   [Gender]='" + newDriver.Gender + "'," +
                "   [Age]=" + newDriver.Age + "," +
                "   [Phone]='" + newDriver.Phone + "'," +
                "   [Password]='" + newDriver.Password + "'" +
                " WHERE [DNo]='" + d.DNo + "'";
            db.SetBySQL(sql);
            d = newDriver;

            MessageBox.Show("修改成功");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
