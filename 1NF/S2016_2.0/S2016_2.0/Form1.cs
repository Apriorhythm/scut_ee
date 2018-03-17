using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace S2016_2._0
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
            LoadTabs();
        }

        /* ###################### 通用方法 ###################### */
        public void FillListView(ListView view, params String[] title)
        {
            view.Clear();
            view.BeginUpdate();

            // 添加标题
            for (int i = 0; i < title.Length; i++)
            {
                view.Columns.Add(title[i], view.Width / title.Length - 1);
            }

            // 添加数据
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
                        // 处理时间类型
                        if (table.Rows[i][j].GetType() == typeof(DateTime))
                            item.SubItems.Add(Convert.ToDateTime(table.Rows[i][j]).ToShortDateString());
                        else
                            item.SubItems.Add(table.Rows[i][j].ToString());
                    }
                }
                view.Items.Add(item);
            }

            view.EndUpdate();
        }

        public void LoadTabs()
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();

            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
        }

        public void LoadTab1()
        {
            sql = @"" +
                " SELECT d.[deptName], c.[specName], s.[SName]" +
                " FROM [Department] d, [CLASS] c, [Student] s" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND s.[classNo]=c.[classNo]";
            table = db.GetBySQL(sql, null);
            FillListView(listView1, "系名", "专业名称", "学生姓名");


            sql = @"SELECT [DeptName] FROM [Department]";
            table = db.GetBySQL(sql, null);
            DeptComb.DataSource = table;
            DeptComb.ValueMember = "DeptName";

            String deptName = DeptComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT c.[specName]" +
                " FROM [Department] d, [CLASS] c" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND d.[deptName]='" + deptName + "'";

            table = db.GetBySQL(sql, null);
            ClassComb.DataSource = table;
            ClassComb.ValueMember = "specName";
        }

        public void LoadTab2()
        {
            sql = @"" +
                " SELECT d.[deptName], SUM(c.[num])" +
                " FROM [Department] d, [CLASS] c" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " GROUP BY d.[deptName]";
            table = db.GetBySQL(sql, null);
            FillListView(listView2, "系名称", "人数");

            sql = @"" +
                " SELECT DISTINCT YEAR([Date]) AS y " +
                " FROM [Student]";
            table = db.GetBySQL(sql, null);
            YearComb.DataSource = table;
            YearComb.ValueMember = "y";

        }

        public void LoadTab3()
        {
            sql = @"SELECT * FROM [Student]";
            table = db.GetBySQL(sql, null);
            FillListView(listView3, "学号", "姓名", "出生日期", "班号");
        }

        /* ###################### 要求一 ###################### */
        private void DeptSearchBtn_Click(object sender, EventArgs e)
        {
            String deptName = DeptComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT d.[deptName], c.[specName], s.[SName]" +
                " FROM [Department] d, [CLASS] c, [Student] s" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND s.[classNo]=c.[classNo]" +
                " 	AND d.[deptName]=@deptName" +
                " ORDER BY d.[deptName] DESC, c.[specName] ASC, s.[SName] DESC";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@deptName", deptName)
            };

            table = db.GetBySQL(sql, sqlParams);

            FillListView(listView1, "系名", "专业名称", "学生姓名");
        }

        private void ClassSearchBtn_Click(object sender, EventArgs e)
        {
            String specName = ClassComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT d.[deptName], c.[specName], s.[SName]" +
                " FROM [Department] d, [CLASS] c, [Student] s" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND s.[classNo]=c.[classNo]" +
                " 	AND c.[specName]=@specName" +
                " ORDER BY d.[deptName] DESC, c.[specName] ASC, s.[SName] DESC";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@specName", specName)
            };

            table = db.GetBySQL(sql, sqlParams);

            FillListView(listView1, "系名", "专业名称", "学生姓名");
        }

        private void StudentSearchBtn_Click(object sender, EventArgs e)
        {
            String SName = NameText.Text;
            sql = @"" +
                " SELECT d.[deptName], c.[specName], s.[SName]" +
                " FROM [Department] d, [CLASS] c, [Student] s" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND s.[classNo]=c.[classNo]" +
                " 	AND s.[SName] LIKE @SName" +
                " ORDER BY d.[deptName] DESC, c.[specName] ASC, s.[SName] DESC";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@SName", "%" + SName + "%")
            };

            table = db.GetBySQL(sql, sqlParams);

            FillListView(listView1, "系名", "专业名称", "学生姓名");

        }

        private void CombineSearchBtn_Click(object sender, EventArgs e)
        {
            String deptName = DeptComb.SelectedValue.ToString();
            String specName = ClassComb.SelectedValue.ToString();
            String SName = NameText.Text;
            sql = @"" +
                " SELECT d.[deptName], c.[specName], s.[SName]" +
                " FROM [Department] d, [CLASS] c, [Student] s" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND s.[classNo]=c.[classNo]" +
                " 	AND d.[deptName]=@deptName" +
                " 	AND c.[specName]=@specName" +
                " 	AND s.[SName] LIKE @SName" +
                " ORDER BY d.[deptName] DESC, c.[specName] ASC, s.[SName] DESC";

            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@deptName", deptName),
                new SqlParameter("@specName", specName),
                new SqlParameter("@SName", "%" + SName + "%")
            };


            table = db.GetBySQL(sql, sqlParams);

            FillListView(listView1, "系名", "专业名称", "学生姓名");

        }

        private void DeptComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String deptName = DeptComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT c.[specName]" +
                " FROM [Department] d, [CLASS] c" +
                " WHERE d.[deptNo]=c.[deptNo]" +
                " 	AND d.[deptName]=@deptName";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@deptName", deptName)
            };

            table = db.GetBySQL(sql, sqlParams);
            ClassComb.DataSource = table;
            ClassComb.ValueMember = "specName";

        }

        /* ###################### 要求二 ###################### */
        private void YearSearchBtn_Click(object sender, EventArgs e)
        {
            String Year = YearComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT t.y, COUNT(*)" +
                " FROM" +
                " (" +
                " 	SELECT  YEAR([Date]) AS y" +
                " 	FROM [Student]" +
                " ) AS t" +
                " WHERE t.y=@Year" +
                " GROUP BY t.y";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Year", Year)
            };

            table = db.GetBySQL(sql, sqlParams);

            FillListView(listView4, "年份", "人数");
        }

        /* ###################### 要求三 ###################### */
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Intent.STATE = "ADD";

            StudentEdit se = new StudentEdit();
            if (se.ShowDialog() == DialogResult.OK)
            {
                Student s = se.s;

                sql = @"" +
                    " INSERT INTO [Student]" +
                    " VALUES" +
                    " (@SNo, @SName, @Date, @classNo)";

                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@SNo", s.SNo),
                    new SqlParameter("@SName", s.SName),
                    new SqlParameter("@Date", s.Date),
                    new SqlParameter("@classNo", s.classNo),

                };

                table = db.GetBySQL(sql, sqlParams);
            }                          

            LoadTabs();

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Intent.STATE = "CHANGE";

            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Student s = new Student();
            s.SetValue(
                listView3.SelectedItems[0].SubItems[0].Text,
                listView3.SelectedItems[0].SubItems[1].Text,
                listView3.SelectedItems[0].SubItems[2].Text,
                listView3.SelectedItems[0].SubItems[3].Text
            );

            StudentEdit se = new StudentEdit();
            se.s = s;
            Intent.OLD_ID = s.SNo;
            if (se.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Student]" +
                    " SET" +
                    "   [Sno]=@SNo," +
                    "   [SName]=@SName," +
                    "   [Date]=@Date," +
                    "   [classNo]=@classNo" +
                    " WHERE [Sno]=@OLD_ID";
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@SNo", s.SNo),
                    new SqlParameter("@SName", s.SName),
                    new SqlParameter("@Date", s.Date),
                    new SqlParameter("@classNo", s.classNo),
                    new SqlParameter("@OLD_ID", Intent.OLD_ID.ToString())
                };

                table = db.GetBySQL(sql, sqlParams);
            }
            LoadTabs();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String SNo = listView3.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [Student]" +
                " WHERE [SNo]=@SNo";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@SNo", SNo),
            };

            table = db.GetBySQL(sql, sqlParams);

            LoadTabs();

        }
    }
}
