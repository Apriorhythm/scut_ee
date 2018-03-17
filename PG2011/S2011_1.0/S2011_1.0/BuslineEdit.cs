using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class BuslineEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Busline bl;

        public BuslineEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void BuslineEdit_Load(object sender, EventArgs e)
        {

            if (Intent.State == "ADD")
            {
                bl = new Busline();
            }
            else
            {
                textBox1.Text = bl.BlNo;
                textBox2.Text = bl.Start;
                textBox3.Text = bl.End;
                textBox4.Text = bl.Distance;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.SetValue(
                 textBox1.Text,
                 textBox2.Text,
                 textBox3.Text,
                 textBox4.Text
             );

            if (bl.BlNo == "" || bl.Start == "" || bl.End == "" || bl.Distance == "")
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            if (Intent.State == "ADD" || bl.BlNo != Intent.OLD_ID)
            {
                sql = @"" +
                    " SELECT * FROM [Buslines]" +
                    " WHERE [BlNo]='" + bl.BlNo + "'";
                table = db.GetBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("路线编号重复，请重新填写");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
