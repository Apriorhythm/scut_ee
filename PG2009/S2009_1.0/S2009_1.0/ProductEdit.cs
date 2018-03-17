using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2009_1._0
{
    public partial class ProductEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Product p;
        
        public ProductEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            if (Intent.State == "ADD")
            {
                p = new Product();
            }
            else
            {
                textBox1.Text = p.ProductID;
                textBox2.Text = p.ProductName;
                textBox3.Text = p.SupplierName;
            }

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            p.SetValue(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text
            );

            if (p.ProductID == "" || p.ProductName == "" || p.SupplierName == "")
            {
                MessageBox.Show("请填写空余项");
                return;
            }

            if (Intent.State == "ADD" || Intent.OLD_ID != p.ProductID)
            {
                sql = @"" +
                    " SELECT * FROM [Products]" +
                    " WHERE [ProductID]='" + p.ProductID + "'";
                table = db.GetBySQL(sql);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("产品编号重复，请重新填写");
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
