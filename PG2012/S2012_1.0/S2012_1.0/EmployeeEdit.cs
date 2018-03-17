using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace S2012_1._0
{
    public partial class EmployeeEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Employee emp;

        public EmployeeEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            if (Intent.State == "ADD")
            {
                emp = new Employee();        
            }
            else
            {
                EmpNoText.Text = emp.EmpName;
                EmpNameText.Text = emp.EmpName;
                LocationText.Text = emp.Location;
            }

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            emp.SetValue(
                EmpNoText.Text,
                EmpNameText.Text,
                LocationText.Text
            );

            if (emp.EmpNo == "" || emp.EmpName == "" || emp.Location == "")
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            sql = @"" +
                " SELECT * FROM [Employee]" +
                " WHERE [EmpNo]='" + emp.EmpNo + "'";
            table = db.GetBySQL(sql);

            if (Intent.State == "ADD")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("员工号重复，请重新填写");
                    return;
                }
            }
            else
            {
                if (Intent.OLD_ID != emp.EmpNo)
                {
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("员工号重复，请重新填写");
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
