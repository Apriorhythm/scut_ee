using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2017_2._0
{
    public partial class PatientEdit : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public Patient patient;

        public PatientEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void PatientEdit_Load(object sender, EventArgs e)
        {
            MessageBox.Show(patient.AprioriInfo);
            patient.AprioriInfo = "Walker";

            // 读取小科室编号
            sqlString = @"SELECT [GroupNo] FROM [Group]";
            table = db.GetBySQL(sqlString);
            comboBox1.DataSource = table;
            comboBox1.ValueMember = "GroupNo";


            // 设置其他值
            if (Intent.dict["ADD_OR_CHANGE"].ToString() == "ADD")
            {
                textBox1.Focus();
            }
            else
            {
                textBox1.Text = Intent.dict["PID"].ToString();
                textBox2.Text = Intent.dict["PName"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(Intent.dict["Date"].ToString());
                comboBox1.SelectedValue = Intent.dict["GroupNo"].ToString();
            }


        }


        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["PID"] = textBox1.Text;
            Intent.dict["PName"] = textBox2.Text;
            Intent.dict["Date"] = dateTimePicker1.Value.ToShortDateString().ToString();
            Intent.dict["GroupNo"] = comboBox1.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
