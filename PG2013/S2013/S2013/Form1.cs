using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2013
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

        /* 填充ListView通用方法 */
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

        /* 读取所有Tab */
        public void LoadTab1()
        {
            sql = @"SELECT * FROM [TEACHERS]";
            table = db.GetBySQL(sql);
            FillListView(listView1, "教师号", "教师名", "教师性别");

            GenderComb.SelectedIndex = 0;
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
            sql = @"SELECT DISTINCT [Year] FROM [WORKS]";
            table = db.GetBySQL(sql);
            YearComb.DataSource = table;
            YearComb.ValueMember = "Year";

        }

        public void LoadTab4()
        {
            sql = @"" +
                " SELECT t.[TName], c.[CName]" +
                " FROM [TEACHERS] t, [COURSES] c, [WORKS] w" +
                " WHERE t.[TNo]=w.[TNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " 	AND t.[TNo] IN" +
                " 	(" +
                " 		SELECT [TNo] AS TNo" +
                " 		FROM [WORKS]" +
                " 		GROUP BY [TNo]" +
                " 		HAVING COUNT(*)>=2" +
                " 	)";
            table = db.GetBySQL(sql);
            FillListView(listView4, "教师名", "课程名");

        }

        /* Tab1 */
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";
            TeacherEdit te = new TeacherEdit();
            if (te.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [TEACHERS]" +
                    " VALUES" +
                    " (" +
                    "   '" + te.t.TNo + "'," +
                    "   '" + te.t.TName + "'," +
                    "   '" + te.t.Gender + "'" +
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

            TeacherEdit te = new TeacherEdit();

            Teacher t = new Teacher();
            t.SetValue(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[2].Text
            );
            te.t = t;
            Intent.OLD_ID = t.TNo;

            if (te.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [TEACHERS]" +
                    " SET" +
                    "   [TNo]='" + t.TNo + "'," +
                    "   [TName]='" + t.TName + "'," +
                    "   [Gender]='" + t.Gender + "'" +
                    " WHERE [TNo]='" + Intent.OLD_ID + "'";
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

            String TNo = listView1.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [TEACHERS]" +
                " WHERE [TNo]='" + TNo + "'";
            db.SetBySQL(sql);

            UpdateListView();
        }

        private void GenderBtn_Click(object sender, EventArgs e)
        {
            String Gender = GenderComb.SelectedItem.ToString();

            sql = @"" +
                " SELECT * FROM [TEACHERS]" +
                " WHERE [Gender]='" + Gender + "'";
            table = db.GetBySQL(sql);
            FillListView(listView1, "教师号", "教师名", "教师性别");
        }

        /* Tab2 */
        private void TNoBtn_Click(object sender, EventArgs e)
        {
            String TNo = TNoComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT t.[TNo], t.[TName], c.[CName]" +
                " FROM [TEACHERS] t, [COURSES] c, [WORKS] w" +
                " WHERE t.[TNo]=w.[TNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " 	AND t.[TNo]='" + TNo + "'";

            table = db.GetBySQL(sql);
            FillListView(listView2, "教师号", "教师名字", "课程名");

        }

        private void TNameBtn_Click(object sender, EventArgs e)
        {
            String TName = TNameComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT t.[TNo], t.[TName], c.[CName]" +
                " FROM [TEACHERS] t, [COURSES] c, [WORKS] w" +
                " WHERE t.[TNo]=w.[TNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " 	AND t.[TName]='" + TName + "'";

            table = db.GetBySQL(sql);
            FillListView(listView2, "教师号", "教师名字", "课程名");
        }

        /* Tab3 */
        private void YearSearchBtn_Click(object sender, EventArgs e)
        {
            String Year = YearComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT t.[TNo], t.[TName], c.[CName],c.[Duration], w.[Year]" +
                " FROM [TEACHERS] t, [COURSES] c, [WORKS] w" +
                " WHERE t.[TNo]=w.[TNo]" +
                " 	AND c.[CNo]=w.[CNo]" +
                " 	AND w.[Year]=" + Year;
            table = db.GetBySQL(sql);
            FillListView(listView3, "教师号", "教师名", "课程名", "学时", "年份");

        }
    }
}
