using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2017_2._0
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            LoadMISC();

        }

        public void FillListView(ListView listView, DataTable table)
        {
            listView.BeginUpdate();
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
                            item.SubItems.Add(Convert.ToDateTime(table.Rows[i][j].ToString()).ToShortDateString());
                        else
                            item.SubItems.Add(table.Rows[i][j].ToString());
                    }
                }
                listView.Items.Add(item);
            }

            listView.EndUpdate();
        }



        public void LoadTab1()
        {
            listView1.Clear();

            // 设置表头
            listView1.Columns.Add("病人编号", listView1.Width / 4 - 1);
            listView1.Columns.Add("病人姓名", listView1.Width / 4 - 1);
            listView1.Columns.Add("出生日期", listView1.Width / 4 - 1);
            listView1.Columns.Add("小科室编号", listView1.Width / 4 - 1);


            // 填充数据
            sqlString = @"SELECT * FROM [Patient]";
            table = db.GetBySQL(sqlString);
            FillListView(listView1, table);

        }

        public void LoadTab2()
        {
            sqlString = @"SELECT [DeptName] FROM [Department]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                departmentDrop.Items.Add(table.Rows[i][0]);
            }
            departmentDrop.SelectedIndex = 0;

            sqlString = @"SELECT [GroupName] FROM [Group]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                GroupDrop.Items.Add(table.Rows[i][0]);
            }
            GroupDrop.SelectedIndex = 0;
        }

        public void LoadTab3()
        {
            monthlySearchComb.SelectedIndex = 0;


            listView3.Clear();
            // 设置表头
            listView3.Columns.Add("大科室名", listView3.Width / 2 - 1);
            listView3.Columns.Add("病人总数", listView3.Width / 2 - 1);

            // 填充数据
            sqlString = @"" +
                " SELECT d.[DeptName], SUM(Number)" +
                " FROM [Department] d, [Group] g" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " GROUP BY d.[DeptName]";

            table = db.GetBySQL(sqlString);
            FillListView(listView3, table);

        }

        public void LoadTab4()
        {
            listView4.Clear();

            // 设置表头
            listView4.Columns.Add("小科室编号", listView4.Width / 5 - 1);
            listView4.Columns.Add("小科室名", listView4.Width / 5 - 1);
            listView4.Columns.Add("所属大科室编号", listView4.Width / 5 - 1);
            listView4.Columns.Add("统计月份", listView4.Width / 5 - 1);
            listView4.Columns.Add("病人人数", listView4.Width / 5 - 1);

            // 填充数据
            sqlString = @"SELECT * FROM [Group]";
            table = db.GetBySQL(sqlString);
            FillListView(listView4, table);

        }


        public void LoadMISC()
        {

        }

        /* ============== 要求1 ================= */
        // 添加病人信息
        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["ADD_OR_CHANGE"] = "ADD";

            PatientEdit pe = new PatientEdit();

            if (pe.ShowDialog() == DialogResult.OK)
            {
                String PID = Intent.dict["PID"].ToString();
                String PName = Intent.dict["PName"].ToString();
                String Date = Intent.dict["Date"].ToString();
                String GroupNo = Intent.dict["GroupNo"].ToString();

                sqlString = @"" +
                    " INSERT INTO [Patient]" +
                    " VALUES" +
                    " (" +
                    "   '" + PID + "'," +
                    "   '" + PName + "'," +
                    "   '" + Date + "'," +
                    "   " + GroupNo + "" +
                    " )";
                db.SetBySQL(sqlString);
            }

            LoadTab1();
            LoadTab2();
            listView1.SelectedItems.Clear();
        }

        // 修改病人信息
        private void ChangePatientBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["ADD_OR_CHANGE"] = "CHANGE";

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String OldPID = listView1.SelectedItems[0].SubItems[0].Text;


            String PID = listView1.SelectedItems[0].SubItems[0].Text;
            String PName = listView1.SelectedItems[0].SubItems[1].Text;
            String Date = listView1.SelectedItems[0].SubItems[2].Text;
            String GroupNo = listView1.SelectedItems[0].SubItems[3].Text;

            Intent.dict["PID"] = PID;
            Intent.dict["PName"] = PName;
            Intent.dict["Date"] = Date;
            Intent.dict["GroupNo"] = GroupNo;

            PatientEdit pe = new PatientEdit();
            if (pe.ShowDialog() == DialogResult.OK)
            {
                PID = Intent.dict["PID"].ToString();
                PName = Intent.dict["PName"].ToString();
                Date = Intent.dict["Date"].ToString();
                GroupNo = Intent.dict["GroupNo"].ToString();

                sqlString = @"" +
                    " UPDATE [Patient]" +
                    " SET" +
                    "   [PID]='" + PID + "'," +
                    "   [PName]='" + PName + "'," +
                    "   [Date]='" + Date + "'," +
                    "   [GroupNo]=" + GroupNo + "" +
                    " WHERE [PID]='" + OldPID + "'";
                db.SetBySQL(sqlString);
            }

            LoadTab1();
            LoadTab2();
            listView1.SelectedItems.Clear();
        }

        // 删除病人信息
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

            LoadTab1();
            LoadTab2();
            listView1.SelectedItems.Clear();
        }
        /* ============== 要求1 ================= */




        /* ============== 要求2 ================= */
        // 大科目查找
        private void departSearchBtn_Click(object sender, EventArgs e)
        {
            String DeptName = departmentDrop.SelectedItem.ToString();

            listView2.Clear();
            // 设置表头
            listView2.Columns.Add("大科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView2.Width / 3 - 1);


            // 填充数据

            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " 	AND p.[GroupNo]=g.[GroupNo]" +
                " 	AND d.[DeptName]='" + DeptName + "'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";
            table = db.GetBySQL(sqlString);
            FillListView(listView2, table);
        }

        // 小科目查找
        private void GroupSearchBtn_Click(object sender, EventArgs e)
        {
            String GroupName = GroupDrop.SelectedItem.ToString();

            listView2.Clear();
            // 设置表头
            listView2.Columns.Add("大科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView2.Width / 3 - 1);


            // 填充数据

            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " 	AND p.[GroupNo]=g.[GroupNo]" +
                " 	AND g.[GroupName]='" + GroupName + "'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";

            table = db.GetBySQL(sqlString);
            FillListView(listView2, table);
        }

        // 姓名查找
        private void NameSearchBtn_Click(object sender, EventArgs e)
        {
            String PName = textBox1.Text;

            listView2.Clear();
            // 设置表头
            listView2.Columns.Add("大科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView2.Width / 3 - 1);


            // 填充数据

            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " 	AND p.[GroupNo]=g.[GroupNo]" +
                " 	AND p.[PName] LIKE'%" + PName + "%'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";

            table = db.GetBySQL(sqlString);
            FillListView(listView2, table);
        }
        /* ============== 要求2 ================= */



        /* ============== 要求3 ================= */
        // 小科室按照月份统计病人数量
        private void monthlySearchBtn_Click(object sender, EventArgs e)
        {
            String month = monthlySearchComb.SelectedItem.ToString();

            sqlString = @"" +
                " SELECT SUM([Number])" +
                " FROM [Group]" +
                " WHERE [Month]=" + month + "" +
                " GROUP BY [Month]";
            table = db.GetBySQL(sqlString);
            if (table.Rows.Count == 0)
                monthlySearchLabel.Text = "0";
            else
                monthlySearchLabel.Text = table.Rows[0][0].ToString();

        }
        /* ============== 要求3 ================= */



        /* ============== 要求4 ================= */

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["ADD_OR_CHANGE"] = "ADD";

            GroupEdit ge = new GroupEdit();

            if (ge.ShowDialog() == DialogResult.OK)
            {
                String GroupNo = Intent.dict["GroupNo"].ToString();
                String GroupName = Intent.dict["GroupName"].ToString();
                String DeptNo = Intent.dict["DeptNo"].ToString();
                String Month = Intent.dict["Month"].ToString();
                String Number = Intent.dict["Number"].ToString();

                sqlString = @"" +
                    " INSERT INTO [Group]" +
                    " VALUES" +
                    " (" +
                    "   " + GroupNo + "," +
                    "   '" + GroupName + "'," +
                    "   " + DeptNo + "," +
                    "   " + Month + "," +
                    "   " + Number + "" +
                    " )";
                db.SetBySQL(sqlString);
            }

            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            listView4.SelectedItems.Clear();
        }

        private void ChangeGroupBtn_Click(object sender, EventArgs e)
        {
            Intent.dict["ADD_OR_CHANGE"] = "CHANGE";

            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String OldGroupNo = listView4.SelectedItems[0].SubItems[0].Text;


            String GroupNo = listView4.SelectedItems[0].SubItems[0].Text;
            String GroupName = listView4.SelectedItems[0].SubItems[1].Text;
            String DeptNo = listView4.SelectedItems[0].SubItems[2].Text;
            String Month = listView4.SelectedItems[0].SubItems[3].Text;
            String Number = listView4.SelectedItems[0].SubItems[4].Text;

            Intent.dict["GroupNo"] = GroupNo;
            Intent.dict["GroupName"] = GroupName;
            Intent.dict["DeptNo"] = DeptNo;
            Intent.dict["Month"] = Month;
            Intent.dict["Number"] = Number;

            GroupEdit ge = new GroupEdit();
            if (ge.ShowDialog() == DialogResult.OK)
            {
                GroupNo = Intent.dict["GroupNo"].ToString();
                GroupName = Intent.dict["GroupName"].ToString();
                DeptNo = Intent.dict["DeptNo"].ToString();
                Month = Intent.dict["Month"].ToString();
                Number = Intent.dict["Number"].ToString();

                sqlString = @"" +
                    " UPDATE [Group]" +
                    " SET" +
                    "   [GroupNo]=" + GroupNo + "," +
                    "   [GroupName]='" + GroupName + "'," +
                    "   [DeptNo]=" + DeptNo + "," +
                    "   [Month]=" + Month + "," +
                    "   [Number]=" + Number + "" +
                    " WHERE [GroupNo]='" + OldGroupNo + "'";
                db.SetBySQL(sqlString);
            }

            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            listView4.SelectedItems.Clear();
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
                " WHERE [GroupNo]='" + GroupNo + "'";
            db.SetBySQL(sqlString);

            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            listView4.SelectedItems.Clear();
        }




        /* ============== 要求4 ================= */




    }
}
