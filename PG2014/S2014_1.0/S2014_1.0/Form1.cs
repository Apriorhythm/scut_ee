using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2014_1._0
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

        // 填充ListView
        public void FillListView(ListView view, params String[] titles)
        {
            view.Clear();
            view.BeginUpdate();
            // 表头
            for (int i = 0; i < titles.Length; i++)
            {
                view.Columns.Add(titles[i], view.Width / titles.Length - 1);
            }

            // 数据
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
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
            sql = @"SELECT * FROM [TEACHERS]";
            table = db.GetBySQL(sql);
            FillListView(listView1, "教师号", "教师名", "所在系", "职称号");

            DeptComb.SelectedIndex = 0;
        }

        public void LoadTab2()
        {
            sql = @"SELECT [TNo] FROM [TEACHERS]";
            table = db.GetBySQL(sql);
            TNoComb.DataSource = table;
            TNoComb.ValueMember = "TNo";

            sql = @"SELECT [TName] FROM [TEACHERS]";
            table = db.GetBySQL(sql);
            TNameComb.DataSource = table;
            TNameComb.ValueMember = "TName";
        }

        public void LoadTab3()
        {
            sql = @"" +
                " SELECT  t.[TName], c.[CNo], c.[CName], c.[Period]" +
                " FROM [TEACHERS] t, [COURSES] c" +
                " WHERE t.[TNo]=c.[TNo]" +
                " 	AND t.[TNo] IN" +
                " 	(" +
                " 		SELECT [TNo]" +
                " 		FROM [COURSES]" +
                " 		GROUP BY [TNo]" +
                " 		HAVING COUNT(TNo)=1" +
                " 	)";
            table = db.GetBySQL(sql);
            FillListView(listView3, "教师名", "课程号", "课程名", "时长");
        }

        public void LoadTab4()
        {
            sql = @"" +
                " SELECT t.[TName], r.[Salary]*cn.[cc] AS sum_salary" +
                " FROM [TEACHERS] t, [REMUNERATIONS] r," +
                " (" +
                " 	SELECT t2.[TNo], COUNT(*) AS cc" +
                " 	FROM [TEACHERS] t2, [COURSES] c2" +
                " 	WHERE t2.[TNo]=c2.[TNo]" +
                " 	GROUP BY t2.[TNo]" +
                " ) AS cn" +
                " WHERE t.[RNo]=r.[RNo]" +
                " 	AND t.[TNo]=cn.[TNo]" +
                " ORDER BY sum_salary DESC";
            table = db.GetBySQL(sql);
            FillListView(listView4, "教师名字", "总工资");
        }

        /* ################## Tab1 ################## */
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";

            TeacherEdit te = new TeacherEdit();
            if (te.ShowDialog() == DialogResult.OK)
            {
                Teacher t = te.t;

                sql = @"" +
                    " INSERT INTO [TEACHERS]" +
                    " VALUES" +
                    " ("+
                    "   '" + t.TNo + "'," +
                    "   '" + t.TName + "'," +
                    "   '" + t.DeptName + "'," +
                    "   '" + t.RNo + "'" +
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

            Teacher t = new Teacher();
            t.SetValue(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[2].Text,
                listView1.SelectedItems[0].SubItems[3].Text
            );
            TeacherEdit te = new TeacherEdit();
            te.t = t;
            if (te.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [TEACHERS]" +
                    " SET" +
                    "   [TNo]='" + t.TNo + "'," +
                    "   [TName]='" + t.TName + "'," +
                    "   [DeptName]='" + t.DeptName + "'," +
                    "   [RNo]='" + t.RNo + "'";
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

            String TNo = listView1.SelectedItems[0].SubItems[0].ToString();

            sql = @"" +
                " DELETE FROM [TEACHERS]" +
                " WHERE [TNo]='" + TNo + "'";
            db.SetBySQL(sql);

            UpdateListView();
        }

        private void DeptSearchBtn_Click(object sender, EventArgs e)
        {
            String DeptName = DeptComb.SelectedItem.ToString();

            sql = @"" +
                " SELECT * FROM [TEACHERS]" +
                " WHERE [DeptName]='" + DeptName + "'";
            table = db.GetBySQL(sql);
            FillListView(listView1, "教师号", "教师名", "所在系", "职称号");
        }


        /* ################## Tab2 ################## */
        private void TNoSearchBtn_Click(object sender, EventArgs e)
        {
            String TNo = TNoComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT t.[TName], c.[CName]" +
                " FROM [TEACHERS] t, [COURSES] c" +
                " WHERE t.[TNo]=c.[TNo]" +
                "   AND t.[TNo]='" + TNo + "'";
            table = db.GetBySQL(sql);

            FillListView(listView2, "教师名", "课程名");

        }

        private void TNameSearchBtn_Click(object sender, EventArgs e)
        {
            String TName = TNameComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT t.[TName], c.[CName]" +
                " FROM [TEACHERS] t, [COURSES] c" +
                " WHERE t.[TNo]=c.[TNo]" +
                "   AND t.[TName]='" + TName + "'";
            table = db.GetBySQL(sql);

            FillListView(listView2, "教师名", "课程名");

        }
    }
}
