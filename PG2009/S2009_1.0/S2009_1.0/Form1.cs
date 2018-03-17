using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2009_1._0
{
    public partial class Form1 : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
        }

        /* ListView填充通用方法 */
        public void FillListView(ListView view, params String [] titles)
        {
            view.BeginUpdate();
            view.Clear();

            for (int i = 0; i < titles.Length; i++)
            {
                view.Columns.Add(titles[i], view.Width / titles.Length - 1);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j =0; j < table.Columns.Count; j++)
                {
                    if (j <= 0)
                    {
                        item.Text = table.Rows[i][j].ToString();
                    }
                    else
                    {
                        if (table.Rows[i][j].GetType() == typeof(DateTime))
                            item.SubItems.Add(Convert.ToDateTime(table.Rows[i][j].ToString()).ToShortDateString());
                        else
                            item.SubItems.Add(table.Rows[i][j].ToString());
                    }
                }
                view.Items.Add(item);
            }

            view.EndUpdate();
        }
        
        /* 更新所有Tab */
        public void UpdateListView()
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();

            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();
        }

        public void LoadTab1()
        {
            sql = @"SELECT * FROM [Products]";
            table = db.GetBySQL(sql);
            FillListView(listView1, "产品编号", "产品名称", "供应商名称");
        }

        public void LoadTab2()
        {
            sql = @"SELECT [OrderID] FROM [Orders]";
            table = db.GetBySQL(sql);
            comboBox1.DataSource = table;
            comboBox1.ValueMember = "OrderID";
            comboBox1.SelectedIndex = 0;


            sql = @"SELECT [SupplierName] FROM [Products]";
            table = db.GetBySQL(sql);
            comboBox2.DataSource = table;
            comboBox2.ValueMember = "SupplierName";
            comboBox2.SelectedIndex = 0;
        }

        public void LoadTab3()
        {   
            sql = @"" +
                " SELECT o.[OrderID], o.[OrderName], o.[Amount]" +
                " FROM[Orders] o";
            table = db.GetBySQL(sql);
            FillListView(listView3, "订单号", "订单名", "总金额");
        }

        public void LoadTab4()
        {
            sql = @"" +
                " SELECT ([SumP]/[SumQ]) AVGP, [SumQ] , MIN([UnitePrice]) AS MinP, MAX([UnitePrice]) AS MaxP" +
                " FROM [vw_statistics], [OrderDetials] od" +
                " WHERE [vw_statistics].[ProductId]=od.[ProductID]" +
                " GROUP BY ([SumP]/[SumQ]), [SumQ]";
            table = db.GetBySQL(sql);
            FillListView(listView4, "平均价格", "总销售量", "最低单价", "最高单价");
        }

        private void OrderIDSearchBtn_Click(object sender, EventArgs e)
        {
            String OrderID = comboBox1.SelectedValue.ToString();
            sql = @"" +
               " SELECT * FROM [Orders]" +
               " WHERE [OrderID]='" + OrderID + "'";
            table = db.GetBySQL(sql);
            FillListView(listView2, "订单编号", "订单名称", "下订单日期", "交付日期", "订单总金额");
        }

        private void SupSearchBtn_Click(object sender, EventArgs e)
        {
            String SupplierName = comboBox2.SelectedValue.ToString();
            sql = @"" +
                " SELECT p.[SupplierName], o.[OrderID]" +
                " FROM [Products] p, [Orders] o, [OrderDetials] od" +
                " WHERE od.[OrderID]=o.[OrderID]" +
                " 	AND od.[ProductID]=p.ProductID" +
                "   AND p.[SupplierName]='" + SupplierName + "'";
            table = db.GetBySQL(sql);
            FillListView(listView2, "供应商名", "订单号");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";
            ProductEdit pe = new ProductEdit();

            if (pe.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [Products]" +
                    " VALUES" +
                    " (" +
                    "   '" + pe.p.ProductID + "'," +
                    "   '" + pe.p.ProductName + "'," +
                    "   '" + pe.p.SupplierName + "'" +
                    " )";
                db.SetBySQL(sql);
            }

            UpdateListView();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Intent.State = "CHANGE";

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Product p = new Product();
            p.SetValue(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[2].Text
            );
            Intent.OLD_ID = p.ProductID;
            ProductEdit pe = new ProductEdit();
            pe.p = p;

            if (pe.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Products]" +
                    " SET " +
                    "   [ProductID]='" + pe.p.ProductID + "'," +
                    "   [ProductName]='" + pe.p.ProductName + "'," +
                    "   [SupplierName]='" + pe.p.SupplierName + "'" +
                    " WHERE [ProductID]='" + Intent.OLD_ID + "'";
                db.SetBySQL(sql);
            }

            UpdateListView();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String ProductID = listView1.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [Products]" +
                " WHERE [ProductID]='" + ProductID + "'";
            db.SetBySQL(sql);

            UpdateListView();
        }
    }
}
