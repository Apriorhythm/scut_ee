using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2017_4._0
{
    public partial class Form1 : Form
    {
        DB db;
        String sqlString;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        public void FillListView(ListView view)
        {
            view.BeginUpdate();
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


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            LoadMisc();
        }

        public void UpdateListView()
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            LoadMisc();

            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();
        }

        public void LoadTab1()
        {
            listView1.Clear();

            // 设置表头
            listView1.Columns.Add("病人编号", listView1.Width / 4 - 1);
            listView1.Columns.Add("姓名", listView1.Width / 4 - 1);
            listView1.Columns.Add("生日", listView1.Width / 4 - 1);
            listView1.Columns.Add("小科室号", listView1.Width / 4 - 1);

            // 填充数据
            sqlString = @"SELECT * FROM [Patient]";
            table = db.GetBySQL(sqlString);
            FillListView(listView1);
        }

        public void LoadTab2()
        {
            sqlString = @"SELECT [DeptName] From [Department]";
            table = db.GetBySQL(sqlString);
            DeptComb.DataSource = table;
            DeptComb.ValueMember = "DeptName";

            sqlString = @"" +
                " SELECT g.[GroupName]" +
                " From [Group] g, [Department] d" +
                " WHERE g.[DeptNo] = d.[DeptNo]" +
                " AND d.[DeptName]='" + DeptComb.SelectedValue + "'";
            table = db.GetBySQL(sqlString);
            GroupComb.DataSource = table;
            GroupComb.ValueMember = "GroupName";
        }

        public void LoadTab3()
        {
            listView3.Clear();

            // 设置表头
            listView3.Columns.Add("病人编号", listView3.Width / 2 - 1);
            listView3.Columns.Add("姓名", listView3.Width / 2 - 1);

            // 填充数据
            sqlString = @"" +
                " SELECT d.[DeptName], SUM(g.[Number])" +
                " FROM [Department] d, [Group] g" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " GROUP BY d.[DeptName]";
            table = db.GetBySQL(sqlString);
            FillListView(listView3);

            MonthlyComb.SelectedIndex = 0;
        }

        public void LoadTab4()
        {
            listView4.Clear();

            // 设置表头
            listView4.Columns.Add("小科室号", listView4.Width / 5 - 1);
            listView4.Columns.Add("小科室名", listView4.Width / 5 - 1);
            listView4.Columns.Add("所属大科室号", listView4.Width / 5 - 1);
            listView4.Columns.Add("统计月份", listView4.Width / 5 - 1);
            listView4.Columns.Add("病人人数", listView4.Width / 5 - 1);

            // 填充数据
            sqlString = @"SELECT * FROM [Group]";
            table = db.GetBySQL(sqlString);
            FillListView(listView4);
        }

        public void LoadMisc()
        {

        }

        /* ################ Tab1 ################ */
        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["ADD_OR_CHANGE"] = "ADD";

            PatientEdit pe = new PatientEdit();

            if (pe.ShowDialog() == DialogResult.OK)
            {
                Patient p = pe.p;

                sqlString = @"" +
                    " INSERT INTO [Patient]" +
                    " VALUES" +
                    " (" +
                    "   '" + p.PID + "'," +
                    "   '" + p.PName + "'," +
                    "   '" + p.Date + "'," +
                    "   " + p.GroupNo + "" +
                    " )";
                db.SetBySQL(sqlString);
            }

            UpdateListView();
        }

        private void ChangePatientBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }


            Intent.dict["ADD_OR_CHANGE"] = "CHANGE";

            PatientEdit pe = new PatientEdit();
            Patient p = new Patient();
            p.SetValue(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[2].Text,
                listView1.SelectedItems[0].SubItems[3].Text
            );
            pe.p = p;
            Intent.dict["OLD_ID"] = p.PID;

            if (pe.ShowDialog() == DialogResult.OK)
            {

                sqlString = @"" +
                    " UPDATE [Patient]" +
                    " SET" +
                    "   [PID]='" + p.PID + "'," +
                    "   [PName]='" + p.PName + "'," +
                    "   [Date]='" + p.Date + "'," +
                    "   [GroupNo]=" + p.GroupNo +
                    " WHERE [PID]='" + Intent.dict["OLD_ID"] + "'";
                db.SetBySQL(sqlString);
            }

            UpdateListView();

        }

        private void DeletePatientBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String PID = listView1.SelectedItems[0].SubItems[0].Text;

            sqlString = @"" +
                " DELETE FROM [Patient]" +
                " WHERE [PID]='" + PID + "'";
            db.SetBySQL(sqlString);

            UpdateListView();
        }
        /* ================ Tab1 ================ */


        /* ################ Tab2 ################ */
        private void DeptComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlString = @"" +
                " SELECT g.[GroupName]" +
                " From [Group] g, [Department] d" +
                " WHERE g.[DeptNo] = d.[DeptNo]" +
                " AND d.[DeptName]='" + DeptComb.SelectedValue + "'";
            table = db.GetBySQL(sqlString);
            GroupComb.DataSource = table;
            GroupComb.ValueMember = "GroupName";
        }

        private void DeptSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView1.Width / 3 - 1);

            // 填充数据
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                "   AND g.[GroupNo]=p.[GroupNo]" +
                "   AND d.[DeptName]='" + DeptComb.SelectedValue + "'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";


            table = db.GetBySQL(sqlString);

            FillListView(listView2);
        }

        private void GroupSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView1.Width / 3 - 1);

            // 填充数据
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                "   AND g.[GroupNo]=p.[GroupNo]" +
                "   AND g.[GroupName]='" + GroupComb.SelectedValue + "'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";

            table = db.GetBySQL(sqlString);

            FillListView(listView2);
        }

        private void NameSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView1.Width / 3 - 1);

            // 填充数据
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                "   AND g.[GroupNo]=p.[GroupNo]" +
                "   AND p.[PName] LIKE '%" + NameTextbox.Text + "%'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";

            table = db.GetBySQL(sqlString);

            FillListView(listView2);
        }

        private void CombineSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView1.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView1.Width / 3 - 1);

            // 填充数据
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                "   AND g.[GroupNo]=p.[GroupNo]" +
                "   AND d.[DeptName]='" + DeptComb.SelectedValue + "'" +
                "   AND g.[GroupName]='" + GroupComb.SelectedValue + "'" +
                "   AND p.[PName] LIKE '%" + NameTextbox.Text + "%'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";

            table = db.GetBySQL(sqlString);

            FillListView(listView2);
        }
        /* ================ Tab2 ================ */

        /* ################ Tab3 ################ */
        private void MonthSumBtn_Click(object sender, EventArgs e)
        {
            sqlString = @"" +
                " SELECT SUM([Number])" +
                " FROM [Group]" +
                " WHERE [Month]=" + MonthlyComb.SelectedItem.ToString();

            table = db.GetBySQL(sqlString);
            if ("" != table.Rows[0][0].ToString())
                MonthSumLabel.Text = table.Rows[0][0].ToString();
            else
                MonthSumLabel.Text = "无";
        }
        /* ================ Tab3 ================ */

        /* ################ Tab4 ################ */
        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["ADD_OR_CHANGE"] = "ADD";

            GroupEdit ge = new GroupEdit();

            if (ge.ShowDialog() == DialogResult.OK)
            {
                Group g = ge.g;

                sqlString = @"" +
                    " INSERT INTO [Group]" +
                    " VALUES" +
                    " (" +
                    "   " + g.GroupNo + "," +
                    "   '" + g.GroupName + "'," +
                    "   '" + g.DeptNo + "'," +
                    "   " + g.Month + "," +
                    "   " + g.Number + "" +
                    " )";
                db.SetBySQL(sqlString);
            }

            UpdateListView();

        }

        private void ChangeGroupBtn_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }


            Intent.dict["ADD_OR_CHANGE"] = "CHANGE";

            GroupEdit ge = new GroupEdit();
            Group g = new Group();
            g.SetValue(
                listView4.SelectedItems[0].SubItems[0].Text,
                listView4.SelectedItems[0].SubItems[1].Text,
                listView4.SelectedItems[0].SubItems[2].Text,
                listView4.SelectedItems[0].SubItems[3].Text,
                listView4.SelectedItems[0].SubItems[4].Text
            );
            ge.g = g;
            Intent.dict["OLD_ID"] = g.GroupNo;

            if (ge.ShowDialog() == DialogResult.OK)
            {

                sqlString = @"" +
                    " UPDATE [Group]" +
                    " SET" +
                    "   [GroupNo]=" + g.GroupNo + "," +
                    "   [GroupName]='" + g.GroupName + "'," +
                    "   [DeptNo]='" + g.DeptNo + "'," +
                    "   [Month]=" + g.Month + "," +
                    "   [Number]=" + g.Number +
                    " WHERE [GroupNo]=" + Intent.dict["OLD_ID"] + "";
                db.SetBySQL(sqlString);
                UpdateListView();


                // 最多病人和最少病人查询
                sqlString = @"" +
                    " SELECT *" +
                    " FROM [Group]" +
                    " WHERE [GroupNo] NOT IN" +
                    " (" +
                    " 	SELECT g1.[GroupNo]" +
                    " 	FROM [Group] g1, [Group] g2" +
                    " 	WHERE g1.[Number]<g2.[Number]" +
                    " )" +
                    " UNION" +
                    " SELECT *" +
                    " FROM [Group]" +
                    " WHERE [GroupNo] NOT IN" +
                    " (" +
                    " 	SELECT g1.[GroupNo]" +
                    " 	FROM [Group] g1, [Group] g2" +
                    " 	WHERE g1.[Number]>g2.[Number]" +
                    " )";

                table = db.GetBySQL(sqlString);
                listView4.Clear();

                // 设置表头
                listView4.Columns.Add("小科室号", listView4.Width / 5 - 1);
                listView4.Columns.Add("小科室名", listView4.Width / 5 - 1);
                listView4.Columns.Add("所属大科室号", listView4.Width / 5 - 1);
                listView4.Columns.Add("统计月份", listView4.Width / 5 - 1);
                listView4.Columns.Add("病人人数", listView4.Width / 5 - 1);

                FillListView(listView4);
                MessageBox.Show("请查看最多病人和最少病人的小科室!");
            }


        }

        private void DeleteGroupBtn_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String GroupNo = listView4.SelectedItems[0].SubItems[0].Text;

            sqlString = @"" +
                " DELETE FROM [Group]" +
                " WHERE [GroupNo]=" + GroupNo + "";
            db.SetBySQL(sqlString);

            UpdateListView();

        }

        private void ReloadTab4_Click(object sender, EventArgs e)
        {
            LoadTab4();
        }
        /* ================ Tab4 ================ */



    }
}
