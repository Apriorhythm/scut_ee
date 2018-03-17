using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public Form2()
        {
            InitializeComponent();
            db = new DB();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Intent.dict["FLAG"].ToString() == "ADD")
            {
                textBox1.Focus();
            }
            else // 修改
            {
                textBox1.Text = Intent.dict["EmpNo"].ToString();
                textBox2.Text = Intent.dict["EmpName"].ToString();
                if ("男" == Intent.dict["EmpSex"].ToString())
                    radioMale.Checked = true;
                else
                    radioFemale.Checked = true;
                textBox3.Text = Intent.dict["EmpAge"].ToString();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // 一般性非法输入
            String EmpNo = textBox1.Text;
            String EmpName = textBox2.Text;
            String EmpSex = radioMale.Checked == true ? "男" : "女";
            String EmpAge = textBox3.Text;

            if (EmpNo == "" || EmpName == "" || !(radioFemale.Checked || radioMale.Checked) || EmpAge == "")
            {
                MessageBox.Show("Error", "某些项目没有填写");
                return;
            }

            Regex regex = new Regex(@"^[0-9]{1,3}$");            
            if ( !(regex.IsMatch(EmpAge) && Convert.ToInt32(EmpAge) > 0) )
            {
                MessageBox.Show("年龄填写错误", "Error");
                return;
            }
            

            if (Intent.dict["FLAG"].ToString() == "ADD")
            {
                sqlString = @"SELECT * FROM [EMPLOYEE]" +
                    " WHERE [EmpNo]='" + EmpNo + "'";
                table = db.GetBySQL(sqlString);

                if (table.Rows.Count != 0)
                {
                    MessageBox.Show("员工号已经存在，请换一个!", "ERROR");
                    return;
                }
            }
            else    //修改
            {
                if (EmpNo != Intent.dict["EmpNo"].ToString())
                {
                    sqlString = @"SELECT * FROM [EMPLOYEE]" +
                        " WHERE [EmpNo]='" + EmpNo + "'";
                    table = db.GetBySQL(sqlString);

                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show("员工号已经存在，请换一个!", "ERROR");
                        return;
                    }
                }
            }

            Intent.dict["EmpNo"] = EmpNo;
            Intent.dict["EmpName"] = EmpName;
            Intent.dict["EmpSex"] = EmpSex;
            Intent.dict["EmpAge"] = EmpAge;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
