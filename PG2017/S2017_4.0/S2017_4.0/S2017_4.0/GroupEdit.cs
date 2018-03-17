using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace S2017_4._0
{
    public partial class GroupEdit : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public Group g;

        public GroupEdit()
        {
            InitializeComponent();
            db = new DB();

        }

        private void GroupEdit_Load(object sender, EventArgs e)
        {
            sqlString = @"SELECT [DeptNo] FROM [Department]";
            table = db.GetBySQL(sqlString);
            DeptComb.DataSource = table;
            DeptComb.ValueMember = "DeptNo";

            MonthComb.SelectedIndex = 0;

            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                g = new Group();
            }
            else
            {
                textBox1.Text = g.GroupNo;
                textBox2.Text = g.GroupName;
                DeptComb.SelectedValue = g.DeptNo;
                MonthComb.SelectedIndex = Convert.ToInt32(g.Month) - 1;
                numericUpDown1.Value = Convert.ToDecimal(g.Number);
            }


        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            g.SetValue(
                textBox1.Text,
                textBox2.Text,
                DeptComb.SelectedValue.ToString(),
                MonthComb.SelectedItem.ToString(),
                numericUpDown1.Value.ToString()
            );


            if (g.GroupNo == "" || g.GroupName == "")
            {
                MessageBox.Show("请填写空项");
                return;
            }

            Regex r = new Regex("[0-9]+");
            if (!r.IsMatch(g.GroupNo))
            {
                MessageBox.Show("小科室编号请使用数字");
                return;
            }

            sqlString = @"" +
                " SELECT * FROM [Group]" +
                " WHERE [GroupNo]=" + g.GroupNo + "";
            table = db.GetBySQL(sqlString);
            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("小科室编号重复");
                    return;
                }
            }
            else
            {
                if (g.GroupNo != Intent.dict["OLD_ID"].ToString())
                {
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("小科室编号重复");
                        return;
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
