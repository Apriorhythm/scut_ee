using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2012_1._0
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

        /* ListView填充工具 */
        public void FillListView(ListView view, params String[] titles)
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
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (j <= 0)
                    {
                        item.Text = table.Rows[i][j].ToString();
                    }
                    else
                    {
                        item.SubItems.Add(table.Rows[i][j].ToString());
                    }
                }
                view.Items.Add(item);
            }


            view.EndUpdate();
        }

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
            sql = @"SELECT * FROM [Employee]";
            table = db.GetBySQL(sql);
            FillListView(listView1, "员工号", "员工姓名", "所在地");
        }

        public void LoadTab2()
        {

        }

        public void LoadTab3()
        {
            sql = @"" +
                " SELECT e.[EmpNo], e.[EmpName], SUM(w.[Salary]) AS sum_salary" +
                " FROM [Employee] e, [Company] c, [Works] w" +
                " WHERE e.[EmpNo]=w.[EmpNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " GROUP BY e.[EmpNo], e.[EmpName]" +
                " HAVING COUNT(*)>=2";
            table = db.GetBySQL(sql);
            FillListView(listView3, "员工号", "姓名", "总工资");
        }

        public void LoadTab4()
        {
            sql = @"SELECT [CName] FROM [Company]";
            table = db.GetBySQL(sql);
            CNameSearchComb.DataSource = table;
            CNameSearchComb.ValueMember = "CName";
                                                       
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";

            EmployeeEdit ee = new EmployeeEdit();

            if (ee.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [Employee]" +
                    " VALUES" +
                    " (" +
                    " '" + ee.emp.EmpNo + "'," +
                    " '" + ee.emp.EmpName + "'," +
                    " '" + ee.emp.Location + "'" +
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

            Employee emp = new Employee();
            emp.SetValue(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[2].Text
            );

            EmployeeEdit ee = new EmployeeEdit();
            ee.emp = emp;
            if (ee.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Employee]" +
                    " SET" +
                    "   [EmpNo]='" + emp.EmpNo + "'," +
                    "   [EmpName]='" + emp.EmpName + "'," +
                    "   [Location]='" + emp.Location + "'";
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

            String EmpNo = listView1.SelectedItems[0].SubItems[0].Text;

            sql = @"" +
                " DELETE FROM [Employee]" +
                " WHERE [EmpNo]='" + EmpNo + "'";
            db.SetBySQL(sql);

            UpdateListView();
        }




        private void EmpNameSearchBtn_Click(object sender, EventArgs e)
        {
            String EmpName = EmpNameText.Text;

            sql = @"" +
                " SELECT c.[CName], c.[location]" +
                " FROM [Employee] e, [Company] c, [Works] w" +
                " WHERE e.[EmpNo]=w.[EmpNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " 	AND e.[EmpName] LIKE '%" + EmpName + "%'";
            table = db.GetBySQL(sql);
            FillListView(listView2, "公司名", "所在地");
        }

        private void CNameSearchBtn_Click(object sender, EventArgs e)
        {
            String CName = CNameSearchComb.SelectedValue.ToString();

            sql = @"" +
                " SELECT e.[EmpName], SUM(w.[Salary]) AS sum_salary" +
                " FROM [Employee] e, [Company] c, [Works] w" +
                " WHERE e.[EmpNo]=w.[EmpNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " 	AND e.[EmpNo] IN" +
                " 	(" +
                " 		SELECT e2.[EmpNo]" +
                " 		FROM [Employee] e2, [Company] c2, [Works] w2" +
                " 		WHERE e2.[EmpNo]=w2.[EmpNo]" +
                " 			AND c2.[CNo]=w2.[CNo]" +
                " 			AND c2.[CName]='" + CName + "'" +
                " 	)" +
                " GROUP BY e.[EmpName]" +
                " ORDER BY sum_salary DESC";
            table = db.GetBySQL(sql);
            FillListView(listView4, "员工姓名", "总工资");
        }
    }
}
