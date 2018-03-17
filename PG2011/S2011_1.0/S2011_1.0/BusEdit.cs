using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class BusEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Bus b;

        public BusEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void BusEdit_Load(object sender, EventArgs e)
        {
            if (Intent.State == "ADD")
            {
                b = new Bus();
            }
            else
            {
                textBox1.Text = b.BNo;
                textBox2.Text = b.Producer;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.SetValue(
                textBox1.Text,
                textBox2.Text
            );

            if (b.BNo == "" || b.Producer == "")
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            if (Intent.State == "ADD" || b.BNo != Intent.OLD_ID)
            {
                sql = @"" +
                    " SELECT * FROM [Buses]" +
                    " WHERE [BNo]='" + b.BNo + "'";
                table = db.GetBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("车牌号重复，请重新填写");
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
