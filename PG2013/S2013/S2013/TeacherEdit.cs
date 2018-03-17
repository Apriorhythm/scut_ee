using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2013
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
            comboBox1.SelectedIndex = 0;

            if (Intent.State == "ADD")
            {
                t = new Teacher();
            }
            else
            {
                textBox1.Text = t.TNo;
                textBox2.Text = t.TName;
                comboBox1.SelectedValue = t.Gender;
            }

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            t.SetValue(
                textBox1.Text,
                textBox2.Text,
                comboBox1.SelectedItem.ToString()
            );

            // 空项检验
            if (t.TNo == "" || t.TName == "")
            {
                MessageBox.Show("请填写空余项目");
                return;
            }

            // 主键重复检验
            sql = @"" +
                " SELECT * FROM [TEACHERS]" +
                " WHERE [TNo]='" + t.TNo + "'";
            table = db.GetBySQL(sql);
            if (Intent.State == "ADD" || Intent.OLD_ID != t.TNo)
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("教师号重复，请重新填写");
                    return;
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
