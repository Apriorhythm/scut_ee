using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2017
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

            Intent.dict.Add("ADD_OR_CHANGE", "");

        }

        // 填充ListView
        public void FillListView(ListView listview, DataTable table)
        {
            listview.BeginUpdate();
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
                        if(table.Rows[i][j].GetType() == typeof(DateTime))
                            item.SubItems.Add(Convert.ToDateTime(table.Rows[i][j].ToString()).ToShortDateString());
                        else
                            item.SubItems.Add(table.Rows[i][j].ToString());

                    }
                }
                listview.Items.Add(item);
            }


            listview.EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();

            loadMISC();
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
            comboBox1.Items.Clear();
            sqlString = @"SELECT [DeptName] FROM [Department]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox1.Items.Add(table.Rows[i][0]);
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            sqlString = @"SELECT [GroupName] FROM [Group]";
            table = db.GetBySQL(sqlString);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox2.Items.Add(table.Rows[i][0]);
            comboBox2.SelectedIndex = 0;

        }

        public void LoadTab3()
        {
            listView3.Clear();

            // 设置表头
            listView3.Columns.Add("小科室编号", listView1.Width / 5 - 1);
            listView3.Columns.Add("小科室名", listView1.Width / 5 - 1);
            listView3.Columns.Add("所属大科室编号", listView1.Width / 5 - 1);
            listView3.Columns.Add("统计月份", listView1.Width / 5 - 1);
            listView3.Columns.Add(" 病人人数", listView1.Width / 5 - 1);

            // 填充数据
            sqlString = @"SELECT * FROM [Group]";
            table = db.GetBySQL(sqlString);
            FillListView(listView3, table);

            sqlString = @"" +
                " SELECT g.[GroupName]" +
                " FROM[Group] g" +
                " WHERE G.[GroupNo] NOT IN" +
                " (" +
                " SELECT g1.[GroupNo]" +
                "     FROM [Group] g1, [Group] g2" +
                "    WHERE g1.[Number]< g2.[Number]" +
                " )";
            maxNumberGroup.Text = db.GetBySQL(sqlString).Rows[0][0].ToString();

            sqlString = @"" +
                " SELECT g.[GroupName]" +
                " FROM[Group] g" +
                " WHERE G.[GroupNo] NOT IN" +
                " (" +
                " SELECT g1.[GroupNo]" +
                "     FROM [Group] g1, [Group] g2" +
                "    WHERE g1.[Number]> g2.[Number]" +
                " )";
            miniNumberGroup.Text = db.GetBySQL(sqlString).Rows[0][0].ToString();


        }

        public void loadMISC()
        {
            sqlString = @"SELECT COUNT(*) FROM [Patient]";
            String sumAllPatient = db.GetBySQL(sqlString).Rows[0][0].ToString();
            AllPatientLabel.Text = sumAllPatient;

            monthComb.SelectedIndex = 0;
        }


        private void addPatient_Click(object sender, EventArgs e)
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
                    " '" + PID + "'," +
                    " '" + PName + "'," +
                    " '" + Date + "'," +
                    " " + GroupNo + "" +
                    " )";
                db.SetBySQL(sqlString);

                LoadTab1();
            }

        }

        private void changePatient_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Intent.dict["ADD_OR_CHANGE"] = "CHANGE";

            String OldPID = listView1.SelectedItems[0].SubItems[0].Text;

            Intent.dict["PID"] = listView1.SelectedItems[0].SubItems[0].Text;
            Intent.dict["PName"] = listView1.SelectedItems[0].SubItems[1].Text;
            Intent.dict["Date"] = listView1.SelectedItems[0].SubItems[2].Text;
            Intent.dict["GroupNo"] = listView1.SelectedItems[0].SubItems[3].Text;

            PatientEdit pe = new PatientEdit();

            if (pe.ShowDialog() == DialogResult.OK)
            {
                String PID = Intent.dict["PID"].ToString();
                String PName = Intent.dict["PName"].ToString();
                String Date = Intent.dict["Date"].ToString();
                String GroupNo = Intent.dict["GroupNo"].ToString();

                sqlString = @"" +
                    " UPDATE  [Patient]" +
                    " SET" +
                    "   [PID]='" + PID + "'," +
                    "   [PName]='" + PName + "'," +
                    "   [Date]='" + Date + "'," +
                    "   [GroupNo]=" + GroupNo + "" +
                    " WHERE PID='" + OldPID + "'";
                db.SetBySQL(sqlString);

                LoadTab1();
            }

            listView1.SelectedItems.Clear();
        }

        private void deletePatient_Click(object sender, EventArgs e)
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

        }

        private void departmentSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView2.Width / 3 - 1);

            String DeptName = comboBox1.SelectedItem.ToString();
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " 	AND g.[GroupNo]=p.[GroupNo]" +
                "   AND d.[DeptName]='" + DeptName + "'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";
            table = db.GetBySQL(sqlString);
            FillListView(listView2, table);
        }

        private void groupSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView2.Width / 3 - 1);

            String GroupName = comboBox2.SelectedItem.ToString();
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " 	AND g.[GroupNo]=p.[GroupNo]" +
                "   AND g.[GroupName]='" + GroupName + "'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";
            table = db.GetBySQL(sqlString);
            FillListView(listView2, table);
        }

        private void nameSearchBtn_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            // 设置表头
            listView2.Columns.Add("大科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("小科室名", listView2.Width / 3 - 1);
            listView2.Columns.Add("病人姓名", listView2.Width / 3 - 1);

            String PName = textBox1.Text;
            sqlString = @"" +
                " SELECT d.[DeptName], g.[GroupName], p.[PName]" +
                " FROM [Department] d, [Group] g, [Patient] p" +
                " WHERE d.[DeptNo]=g.[DeptNo]" +
                " 	AND g.[GroupNo]=p.[GroupNo]" +
                "   AND p.[PName] LIKE '%" + PName + "%'" +
                " ORDER BY d.[DeptName] DESC, g.[GroupName] ASC, p.[PName] DESC";
            table = db.GetBySQL(sqlString);
            FillListView(listView2, table);
        }

        private void monthlySearchBtn_Click(object sender, EventArgs e)
        {
            String month = monthComb.SelectedItem.ToString();

            sqlString = @"" +
                " SELECT SUM(Number)" +
                " FROM [Group]" +
                " WHERE [Month]=" + month + "" +
                " GROUP BY [Month]";
            table = db.GetBySQL(sqlString);
            if (table.Rows.Count > 0)
                MonthlyPatientLabel.Text = table.Rows[0][0].ToString();
            else
                MonthlyPatientLabel.Text = "0";
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
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
                    " " + GroupNo + "," +
                    " '" + GroupName + "'," +
                    " " + DeptNo + "," +
                    " " + Month + "," +
                    " " + Number + "" +
                    " )";
                db.SetBySQL(sqlString);

                LoadTab3();
            }
        }

        private void changeGroupBtn_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Intent.dict["ADD_OR_CHANGE"] = "CHANGE";

            String OldGroupNo = listView3.SelectedItems[0].SubItems[0].Text;

            Intent.dict["GroupNo"] = listView3.SelectedItems[0].SubItems[0].Text;
            Intent.dict["GroupName"] = listView3.SelectedItems[0].SubItems[1].Text;
            Intent.dict["DeptNo"] = listView3.SelectedItems[0].SubItems[2].Text;
            Intent.dict["Month"] = listView3.SelectedItems[0].SubItems[3].Text;
            Intent.dict["Number"] = listView3.SelectedItems[0].SubItems[4].Text;

            GroupEdit ge = new GroupEdit();

            if (ge.ShowDialog() == DialogResult.OK)
            {
                String GroupNo = Intent.dict["GroupNo"].ToString();
                String GroupName = Intent.dict["GroupName"].ToString();
                String DeptNo = Intent.dict["DeptNo"].ToString();
                String Month = Intent.dict["Month"].ToString();
                String Number = Intent.dict["Number"].ToString();

                sqlString = @"" +
                    " UPDATE  [Group]" +
                    " SET" +
                    "   [GroupNo]=" + GroupNo + "," +
                    "   [GroupName]='" + GroupName + "'," +
                    "   [DeptNo]=" + DeptNo + "," +
                    "   [Month]=" + Month + "," +
                    "   [Number]=" + Number + "" +
                    " WHERE GroupNo=" + OldGroupNo + "";
                db.SetBySQL(sqlString);

                LoadTab3();
            }
            listView3.SelectedItems.Clear();

        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String GroupNo = listView3.SelectedItems[0].SubItems[0].Text;

            sqlString = @"" +
                " DELETE FROM [Group]" +
                " WHERE [GroupNo]='" + GroupNo + "'";
            db.SetBySQL(sqlString);

            LoadTab3();
            listView1.SelectedItems.Clear();
        }
    }
}

