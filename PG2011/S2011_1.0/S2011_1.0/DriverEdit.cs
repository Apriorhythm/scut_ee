using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class DriverEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Driver d;

        public DriverEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void DriverEdit_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            if (Intent.State == "ADD")
            {
                d = new Driver();
            }
            else
            {
                textBox1.Text = d.DNo;
                textBox2.Text = d.DName;
                comboBox1.SelectedValue = d.Gender;
                numericUpDown1.Value = Convert.ToInt32(d.Age);
                textBox3.Text = d.Phone;
                textBox4.Text = d.Password;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.SetValue(
                textBox1.Text,
                textBox2.Text,
                comboBox1.SelectedItem.ToString(),
                numericUpDown1.Value.ToString(),
                textBox3.Text,
                textBox4.Text
            );

            if (d.DNo == "" || d.DName == "" || d.Phone =="" || d.Password == "")
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            if (Intent.State == "ADD" || d.DNo != Intent.OLD_ID)
            {
                sql = @"" +
                    " SELECT * FROM [Driver]" +
                    " WHERE [DNo]='" + d.DNo + "'";
                table = db.GetBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("员工号重复，请重新填写");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
