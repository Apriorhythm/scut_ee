using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2017_2._0
{
    public partial class GroupEdit : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public GroupEdit()
        {
            InitializeComponent();

            db = new DB();

        }

        private void GroupEdit_Load(object sender, EventArgs e)
        {
            // 读取大科室编号
            sqlString = @"SELECT [DeptNo] FROM [Department]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox1.Items.Add(table.Rows[i][0].ToString());

            // 设置其他值
            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                textBox1.Focus();
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                textBox1.Text = Intent.dict["GroupNo"].ToString();
                textBox2.Text = Intent.dict["GroupName"].ToString();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == Intent.dict["DeptNo"].ToString())
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == Intent.dict["Month"].ToString())
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }
                }

                textBox3.Text = Intent.dict["Number"].ToString();
            }


        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["GroupNo"] = textBox1.Text;
            Intent.dict["GroupName"] = textBox2.Text;
            Intent.dict["DeptNo"] = comboBox1.SelectedItem.ToString();
            Intent.dict["Month"] = comboBox2.SelectedItem.ToString();
            Intent.dict["Number"] = textBox3.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
