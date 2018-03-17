using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public static void FillListView(ListView listView, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //生成每一列 
                ListViewItem listViewItem = new ListViewItem();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        listViewItem.Text = table.Rows[i][j] + "";
                    }
                    else
                    {
                        listViewItem.SubItems.Add(table.Rows[i][j] + "");
                    }
                }
                listView.Items.Add(listViewItem);
            }
        }

        public Form1()
        {
            InitializeComponent();

            db = new DB();

            Intent.dict.Add("EmpNo", "");
            Intent.dict.Add("EmpName", "");
            Intent.dict.Add("EmpAge", "");
            Intent.dict.Add("EmpSex", "");

            Intent.dict.Add("FLAG", "");

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainTab();
            LoadTab31();
            LoadTab32();
            LoadTab33();
        }

        // 读取员工表
        private void LoadMainTab()
        {
            listView1.Clear();
            //生成表头 
            listView1.Columns.Add("员工号", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView1.Columns.Add("员工姓名", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView1.Columns.Add("性别", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView1.Columns.Add("年龄", listView1.Width / 4 - 1, HorizontalAlignment.Left);

            sqlString = @"SELECT * FROM [EMPLOYEE]";
            DataTable table = db.GetBySQL(sqlString);

            listView1.BeginUpdate();
            FillListView(listView1, table);
            listView1.EndUpdate();
        }

        // 读取表3-1
        private void LoadTab31()
        {
            sqlString = @"SELECT [EmpNo] FROM [EMPLOYEE]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBox1.Items.Add(table.Rows[i][0] + "");
            }

            sqlString = @"SELECT [EmpName] FROM [EMPLOYEE]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBox2.Items.Add(table.Rows[i][0] + "");
            }

            if (table.Rows.Count >=0 )
            {
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
        }

        // 读取表3-2
        private void LoadTab32()
        {
            // 生成表头
            listView3.Columns.Add("员工号", listView1.Width / 5 - 1, HorizontalAlignment.Left);
            listView3.Columns.Add("员工姓名", listView1.Width / 5 - 1, HorizontalAlignment.Left);
            listView3.Columns.Add("性别", listView1.Width / 5 - 1, HorizontalAlignment.Left);
            listView3.Columns.Add("年龄", listView1.Width / 5 - 1, HorizontalAlignment.Left);
            listView3.Columns.Add("总工资", listView1.Width / 5 - 1, HorizontalAlignment.Left);

            sqlString = @"" +
                " SELECT T1.[EmpNo], T1.[EmpName], T1.[EmpAge], T1.[EmpSex], T2.[SumSalary]" +
                " FROM " +
                " (" +
                " 	SELECT *" +
                " 	FROM [EMPLOYEE]" +
                " 	WHERE [EmpAge]>=40" +
                " ) AS T1" +
                " JOIN" +
                " (" +
                " 	SELECT [EmpNo] AS [EmpNo], SUM(Salary) AS SumSalary" +
                " 	FROM [WORKS]" +
                " 	GROUP BY [WORKS].[EmpNo]" +
                " ) AS T2 " +
                " ON T1.[EmpNo]=T2.[EmpNo]" +
                " ORDER BY T2.[SumSalary] DESC";

            table = db.GetBySQL(sqlString);
            listView3.BeginUpdate();
            FillListView(listView3, table);
            listView3.EndUpdate();
        }

        // 读取表3-3
        private void LoadTab33()
        {
            // 生成表头
            listView4.Columns.Add("员工姓名", listView1.Width / 2 - 1, HorizontalAlignment.Left);
            listView4.Columns.Add("公司名", listView1.Width / 2 - 1, HorizontalAlignment.Left);


            sqlString = @"" +
                " SELECT a.[EmpName], b.[CmpName]" +
                " FROM [EMPLOYEE] a, [COMPANY] b, [WORKS] c" +
                " WHERE a.[EmpNo] IN" +
                " 	(" +
                " 		SELECT [EmpNo]" +
                " 		FROM [WORKS]" +
                " 		GROUP BY [EmpNo]" +
                " 		HAVING COUNT(*)>=2" +
                " 	)" +
                " 	AND a.[EmpNo]=c.[EmpNo]" +
                " 	AND b.[CmpNo]=c.[CmpNo]";

            table = db.GetBySQL(sqlString);
            listView4.BeginUpdate();
            FillListView(listView4, table);
            listView4.EndUpdate();
        }


        private void empnoSearchBtn_Click(object sender, EventArgs e)
        {
            String EmpNo = comboBox1.SelectedItem.ToString();
            sqlString = @"" +
                " SELECT * " +
                " FROM [EMPLOYEE]" +
                " WHERE [EMPLOYEE].[EmpNo]='" + EmpNo + "'";
            table = db.GetBySQL(sqlString);
            listView2.Clear();
            //生成表头 
            listView2.Columns.Add("员工号", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView2.Columns.Add("员工姓名", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView2.Columns.Add("性别", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView2.Columns.Add("年龄", listView1.Width / 4 - 1, HorizontalAlignment.Left);

            listView2.BeginUpdate();
            FillListView(listView2, table);
            listView2.EndUpdate();
        }

        private void empnameSearchBtn_Click(object sender, EventArgs e)
        {
            String EmpName = comboBox2.SelectedItem.ToString();
            sqlString = @"" +
                " SELECT * " +
                " FROM [EMPLOYEE]" +
                " WHERE [EMPLOYEE].[EmpName]='" + EmpName + "'";
            table = db.GetBySQL(sqlString);
            listView2.Clear();
            //生成表头 
            listView2.Columns.Add("员工号", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView2.Columns.Add("员工姓名", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView2.Columns.Add("性别", listView1.Width / 4 - 1, HorizontalAlignment.Left);
            listView2.Columns.Add("年龄", listView1.Width / 4 - 1, HorizontalAlignment.Left);

            listView2.BeginUpdate();
            FillListView(listView2, table);
            listView2.EndUpdate();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["FLAG"] = "ADD";

            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // 更新数据库
                String EmpNo = Intent.dict["EmpNo"].ToString();
                String EmpName = Intent.dict["EmpName"].ToString();
                String EmpSex = Intent.dict["EmpSex"].ToString();
                String EmpAge = Intent.dict["EmpAge"].ToString();

                sqlString = @"" +
                    " INSERT INTO [EMPLOYEE] VALUES (" +
                    " '" + EmpNo + "'," +
                    " '" + EmpName + "'," +
                    " '" + EmpSex + "'," +
                    " " + EmpAge + "" +
                    ")";
                db.SetBySQL(sqlString);

                // 更新显示
                LoadMainTab();
            }
            listView1.SelectedItems.Clear();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("对不起，请选择一行", "错误");
                return;
            }

            Intent.dict["FLAG"] = "CHANGE";

            String EmpNo = listView1.SelectedItems[0].SubItems[0].Text;
            String EmpName = listView1.SelectedItems[0].SubItems[1].Text;
            String EmpSex = listView1.SelectedItems[0].SubItems[2].Text;
            String EmpAge = listView1.SelectedItems[0].SubItems[3].Text;

            Intent.dict["EmpNo"] = EmpNo;
            Intent.dict["EmpName"] = EmpName;
            Intent.dict["EmpSex"] = EmpSex;
            Intent.dict["EmpAge"] = EmpAge;

            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // 更新数据库
                EmpNo = Intent.dict["EmpNo"].ToString();
                EmpName = Intent.dict["EmpName"].ToString();
                EmpSex = Intent.dict["EmpSex"].ToString();
                EmpAge = Intent.dict["EmpAge"].ToString();

                sqlString = @"" +
                    " UPDATE  [EMPLOYEE]" + 
                    " SET" +
                    "   [EmpNo]='" + EmpNo + "'," +
                    "   [EmpName]='" + EmpName + "'," +
                    "   [EmpSex]='" + EmpSex + "'," +
                    "   [EmpAge]=" + EmpAge + "" +
                    " WHERE [EmpNo]='" + EmpNo + "'";
                db.SetBySQL(sqlString);

                // 更新显示
                LoadMainTab();
            }
            listView1.SelectedItems.Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("对不起，请选择一行", "错误");
                return;
            }
            else
            {
                String EmpNo = listView1.SelectedItems[0].SubItems[0].Text;
                sqlString = @"" +
                    " DELETE FROM [EMPLOYEE]" +
                    " WHERE [EmpNo]='" + EmpNo + "'";
                db.SetBySQL(sqlString);
                LoadMainTab();

            }

        }
    }
}
