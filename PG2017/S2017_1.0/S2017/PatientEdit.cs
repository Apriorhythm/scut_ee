using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2017
{
    public partial class PatientEdit : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public PatientEdit()
        {
            InitializeComponent();

            db = new DB();
        }

        private void PatientEdit_Load(object sender, EventArgs e)
        {
            sqlString = @" SELECT [GroupNo] FROM [Group]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
                groupNoComb.Items.Add(table.Rows[i][0]);

            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                groupNoComb.SelectedIndex = 1;
                textBox1.Focus();
            }
            else
            {
                String PID = Intent.dict["PID"].ToString();
                String PName = Intent.dict["PName"].ToString();
                String Date = Intent.dict["Date"].ToString();
                String GroupNo = Intent.dict["GroupNo"].ToString();

                textBox1.Text = PID;
                textBox2.Text = PName;
                dateTimePicker1.Value = Convert.ToDateTime(Date);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][0].ToString() == GroupNo)
                    {
                        groupNoComb.SelectedIndex = i;
                        break;
                    }
                }

            }




        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String PID = textBox1.Text;
            String PName = textBox2.Text;
            String Date = dateTimePicker1.Value.ToShortDateString();
            String GroupNo = groupNoComb.SelectedItem.ToString();

            if (PID == "" || PName == "" || GroupNo == "")
            {
                MessageBox.Show("某项没有填写!");
                return;
            }

            sqlString = @"" +
                " SELECT * FROM [Patient]" +
                " WHERE [PID]='" + PID + "'";
            table = db.GetBySQL(sqlString);
            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("病人编号重复，请重新填写!");
                    return;
                }
            }
            else
            {
                if (PID != Intent.dict["PID"].ToString())
                {
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("病人编号重复，请重新填写!");
                        return;
                    }
                }
            }

            Intent.dict["PID"] = PID;
            Intent.dict["PName"] = PName;
            Intent.dict["Date"] = Date;
            Intent.dict["GroupNo"] = GroupNo;


            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
