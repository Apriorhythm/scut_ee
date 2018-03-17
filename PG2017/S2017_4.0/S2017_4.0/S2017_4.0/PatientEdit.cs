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
    public partial class PatientEdit : Form
    {

        DB db;
        String sqlString;
        DataTable table;

        public Patient p;

        public PatientEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void PatientEdit_Load(object sender, EventArgs e)
        {
            sqlString = @"SELECT [GroupNo] FROM [Group]";
            table = db.GetBySQL(sqlString);
            GroupNoComb.DataSource = table;
            GroupNoComb.ValueMember = "GroupNo";

            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                p = new Patient();
            }
            else
            {
                textBox1.Text = p.PID;
                textBox2.Text = p.PName;
                dateTimePicker1.Value = Convert.ToDateTime(p.Date);
                GroupNoComb.SelectedValue = p.GroupNo;
            }


        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            p.SetValue(
                textBox1.Text,
                textBox2.Text,
                dateTimePicker1.Value.ToShortDateString(),
                GroupNoComb.SelectedValue.ToString()

            );

            if (p.PID == "" || p.PName == "")
            {
                MessageBox.Show("请填写空项");
                return;
            }

            Regex r = new Regex("[0-9]+");
            if (!r.IsMatch(p.PID))
            {
                MessageBox.Show("病人编号请使用数字");
                return;
            }

            sqlString = @"" +
                " SELECT * FROM [Patient]" +
                " WHERE [PID]'=" + p.PID + "'";
            table = db.GetBySQL(sqlString);
            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("病人编号重复");
                    return;
                }
            }
            else
            {
                if (p.PID != Intent.dict["OLD_ID"].ToString())
                {
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("病人编号重复");
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
