using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2014_1._0
{
    public partial class TeacherEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Teacher t;

        public TeacherEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void TeacherEdit_Load(object sender, EventArgs e)
        {
            DeptNameComb.SelectedIndex = 0;

            sql = @"SELECT [RNo] FROM [REMUNERATIONS]";
            table = db.GetBySQL(sql);
            RNoComb.DataSource = table;
            RNoComb.ValueMember = "RNo";

            if (Intent.State == "ADD")
            {
                t = new Teacher();
            }
            else
            {
                TNoTextbox.Text = t.TNo;
                TNameBox.Text = t.TName;
                DeptNameComb.SelectedValue = t.DeptName;
                RNoComb.SelectedValue = t.RNo;
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            t.SetValue(
                TNoTextbox.Text,
                TNameBox.Text,
                DeptNameComb.SelectedItem.ToString(),
                RNoComb.SelectedValue.ToString()
            );

            /* ################### 一般性检验 ################### */
            if ("" == t.TNo || "" == t.TName)
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            /* ################### PRIMARY KEY 重复性检验 ################### */

            sql = @"" +
                " SELECT * FROM [TEACHERS]" +
                " WHERE [TNo]='" + t.TNo + "'";
            table = db.GetBySQL(sql);
            
            if (Intent.State == "ADD")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("教师号重复，请重新填写");
                    return;
                }
            }
            else
            {
                if (Intent.OLD_ID != t.TNo)
                {
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("教师号重复，请重新填写");
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
