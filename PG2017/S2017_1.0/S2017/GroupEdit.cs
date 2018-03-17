using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace S2017
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
            sqlString = @" SELECT [DeptNo] FROM [Group]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox1.Items.Add(table.Rows[i][0]);

            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                textBox1.Focus();
            }
            else
            {
                String GroupNo = Intent.dict["GroupNo"].ToString();
                String GroupName = Intent.dict["GroupName"].ToString();
                String DeptNo = Intent.dict["DeptNo"].ToString();
                String Month = Intent.dict["Month"].ToString();
                String Number = Intent.dict["Number"].ToString();

                textBox1.Text = GroupNo;
                textBox2.Text = GroupName;
                textBox3.Text = Number;

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][0].ToString() == DeptNo)
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString() == Month)
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }
                }

            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String GroupNo = textBox1.Text;
            String GroupName = textBox2.Text;
            String DeptNo = comboBox1.SelectedItem.ToString();
            String Month = comboBox2.SelectedItem.ToString();
            String Number = textBox3.Text;

            if (GroupNo == "" || GroupName == "" || Number == "")
            {
                MessageBox.Show("某项没有填写!");
                return;
            }

            sqlString = @"" +
                " SELECT * FROM [Group]" +
                " WHERE [GroupNo]='" + GroupNo + "'";
            table = db.GetBySQL(sqlString);
            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("小科室编号重复，请重新填写!");
                    return;
                }
            }
            else
            {
                if (GroupNo != Intent.dict["GroupNo"].ToString())
                {
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("小科室编号重复，请重新填写!");
                        return;
                    }
                }
            }

            Regex regex = new Regex("[0-9]+");
            if (!regex.IsMatch(Number))
            {
                MessageBox.Show("病人数量填写错误，请重新填写!");
                return;
            }
            else if (Convert.ToInt32(Number) > 80 || Convert.ToInt32(Number) < 0)
            {
                MessageBox.Show("病人数量必须大于0且小于80，请重新填写!");
                return;
            }

            Intent.dict["GroupNo"] = GroupNo;
            Intent.dict["GroupName"] = GroupName;
            Intent.dict["DeptNo"] = DeptNo;
            Intent.dict["Month"] = Month;
            Intent.dict["Number"] = Number;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
