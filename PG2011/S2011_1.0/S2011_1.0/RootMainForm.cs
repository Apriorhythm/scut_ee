using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class RootMainForm : Form
    {
        DB db;
        String sql;
        DataTable table;

        public RootMainForm()
        {
            InitializeComponent();
            db = new DB();
        }

        /* ListView填充通用方法 */
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
                    if (j <=0)
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
            LoadTab5();

            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();
            listView5.SelectedItems.Clear();

        }

        private void RootMainForm_Load(object sender, EventArgs e)
        {
            LoadTab1();
            LoadTab2();
            LoadTab3();
            LoadTab4();
            LoadTab5();
        }

        /* 读取所有Tab */
        public void LoadTab1()
        {
            sql = @"SELECT * FROM [Buses]";
            table = db.GetBySQL(sql);
            FillListView(listView1, "车牌号", "生产厂商");
        }

        public void LoadTab2()
        {
            sql = @"SELECT * FROM [Driver]";
            table = db.GetBySQL(sql);
            FillListView(listView2, "员工号", "姓名", "性别", "年龄", "电话号码", "密码");
        }

        public void LoadTab3()
        {
            sql = @"SELECT * FROM [Buslines]";
            table = db.GetBySQL(sql);
            FillListView(listView3, "路线编号", "始发站", "终点站", "距离");

            BlNoComb.DataSource = table;
            BlNoComb.ValueMember = "BlNo";
            BlNoComb.SelectedIndex = 0;

            StartComb.DataSource = table;
            StartComb.ValueMember = "Start";
            StartComb.SelectedIndex = 0;

        }

        public void LoadTab4()
        {
            sql = @"SELECT * FROM [Timetable]";
            table = db.GetBySQL(sql);
            FillListView(listView4, "路线编号", "员工号", "车牌号", "发车时间");
        }

        public void LoadTab5()
        {
            sql = @"" +
                " SELECT d.[DNo], d.[DName], COUNT(*)" +
                " FROM [Driver] d, [Timetable] t" +
                " WHERE d.[DNo]=t.[DNo]" +
                " GROUP BY d.[DNo], d.[DName]";
            table = db.GetBySQL(sql);
            FillListView(listView5, "员工号", "员工姓名", "发车次数");
        }


        /* Tab1所有功能 */
        private void AddBtn1_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";
            BusEdit be = new BusEdit();
            if (be.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [Buses]" +
                    " VALUES" +
                    " (" +
                    "   '" + be.b.BNo + "'," +
                    "   '" + be.b.Producer + "'" +
                    " )";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void ChangeBtn1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Intent.State = "CHANGE";
            BusEdit be = new BusEdit();
            Bus b = new Bus();
            b.SetValue(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text
            );
            be.b = b;
            Intent.OLD_ID = b.BNo;

            if (be.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Buses]" +
                    " SET" +
                    "   [BNo]='" + be.b.BNo + "'," +
                    "   [Producer]='" + be.b.Producer + "'" +
                    " WHERE [BNo]='" + Intent.OLD_ID + "'";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void DeleteBtn1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String BNo = listView1.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [Buses]" +
                " WHERE [BNo]='" + BNo + "'";
            db.SetBySQL(sql);

            UpdateListView();
        }

        /* Tab2所有功能 */
        private void AddBtn2_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";
            DriverEdit de = new DriverEdit();
            if (de.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [Driver]" +
                    " VALUES" +
                    " (" +
                    "   '" + de.d.DNo + "'," +
                    "   '" + de.d.DName + "'," +
                    "   '" + de.d.Gender + "'," +
                    "   " + de.d.Age + "," +
                    "   '" + de.d.Phone + "'," +
                    "   '" + de.d.Password + "'" +
                    " )";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void ChangeBtn2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Intent.State = "CHANGE";
            DriverEdit de = new DriverEdit();
            Driver d = new Driver();
            d.SetValue(
                listView2.SelectedItems[0].SubItems[0].Text,
                listView2.SelectedItems[0].SubItems[1].Text,
                listView2.SelectedItems[0].SubItems[2].Text,
                listView2.SelectedItems[0].SubItems[3].Text,
                listView2.SelectedItems[0].SubItems[4].Text,
                listView2.SelectedItems[0].SubItems[5].Text
            );
            de.d = d;
            Intent.OLD_ID = d.DNo;

            if (de.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Driver]" +
                    " SET" +
                    "   [DNo]='" + de.d.DNo + "'," +
                    "   [DName]='" + de.d.DName + "'," +
                    "   [Gender]='" + de.d.Gender + "'," +
                    "   [Age]=" + de.d.Age + "," +
                    "   [Phone]='" + de.d.Phone + "'," +
                    "   [Password]='" + de.d.Password + "'" +
                    " WHERE [DNo]='" + Intent.OLD_ID + "'";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void DeleteBtn2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String DNo = listView2.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [Driver]" +
                " WHERE [DNo]='" + DNo + "'";
            db.SetBySQL(sql);

            UpdateListView();
        }

        /* Tab3所有功能 */
        private void AddBtn3_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";
            BuslineEdit ble = new BuslineEdit();
            if (ble.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [Buslines]" +
                    " VALUES" +
                    " (" +
                    "   " + ble.bl.BlNo + "," +
                    "   '" + ble.bl.Start + "'," +
                    "   '" + ble.bl.End + "'," +
                    "   " + ble.bl.Distance + "" +
                    " )";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void ChangeBtn3_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Intent.State = "CHANGE";
            BuslineEdit ble = new BuslineEdit();
            Busline bl = new Busline();
            bl.SetValue(
                listView3.SelectedItems[0].SubItems[0].Text,
                listView3.SelectedItems[0].SubItems[1].Text,
                listView3.SelectedItems[0].SubItems[2].Text,
                listView3.SelectedItems[0].SubItems[3].Text
            );
            ble.bl = bl;
            Intent.OLD_ID = bl.BlNo;

            if (ble.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Buslines]" +
                    " SET" +
                    "   [BlNo]=" + ble.bl.BlNo + "," +
                    "   [Start]='" + ble.bl.Start + "'," +
                    "   [End]='" + ble.bl.End + "'," +
                    "   [Distance]=" + ble.bl.Distance + "" +
                    " WHERE [BlNo]=" + Intent.OLD_ID + "";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void DeleteBtn3_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String BlNo = listView3.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [Buslines]" +
                " WHERE [BlNo]=" + BlNo + "";
            db.SetBySQL(sql);

            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String BlNo = BlNoComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT bl.[BlNo], bl.[Start], bl.[End], bl.[Distance], d.[DNo], d.[DName], t.[BNo], t.[FirstLaunch]" +
                " FROM [Driver] d, [Buslines] bl, [Timetable] t" +
                " WHERE d.[DNo]=t.[DNo]" +
                " 	AND bl.[BlNo]=t.[BlNo]" +
                " 	AND t.[BlNo]=" + BlNo;
            table = db.GetBySQL(sql);
            FillListView(listView3, "路线编号", "始发站", "终点站", "距离", "员工号", "员工姓名", "车牌号", "发车时间");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Start = StartComb.SelectedValue.ToString();
            sql = @"" +
                " SELECT bl.[BlNo], bl.[Start], bl.[End], bl.[Distance], d.[DNo], d.[DName], t.[BNo], t.[FirstLaunch]" +
                " FROM [Driver] d, [Buslines] bl, [Timetable] t" +
                " WHERE d.[DNo]=t.[DNo]" +
                " 	AND bl.[BlNo]=t.[BlNo]" +
                " 	AND bl.[Start]='" + Start + "'";
            table = db.GetBySQL(sql);
            FillListView(listView3, "路线编号", "始发站", "终点站", "距离", "员工号", "员工姓名", "车牌号", "发车时间");
        }

        /* Tab4所有功能 */
        private void AddBtn4_Click(object sender, EventArgs e)
        {
            Intent.State = "ADD";
            TimetableEdit te = new TimetableEdit();

            if (te.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " INSERT INTO [Timetable]" +
                    " VALUES" +
                    " (" +
                    "   " + te.tt.BlNo + "," +
                    "   '" + te.tt.DNo + "'," +
                    "   '" + te.tt.BNo + "'," +
                    "   '" + te.tt.FirstLaunch + "'" +
                    " )";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void ChangeBtn4_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            Intent.State = "CHANGE";
            TimetableEdit te = new TimetableEdit();
            Timetable tt = new Timetable();
            tt.SetValue(
                listView4.SelectedItems[0].SubItems[0].Text,
                listView4.SelectedItems[0].SubItems[1].Text,
                listView4.SelectedItems[0].SubItems[2].Text,
                listView4.SelectedItems[0].SubItems[3].Text
            );
            te.tt = tt;
            Intent.OLD_ID = tt.BlNo;

            if (te.ShowDialog() == DialogResult.OK)
            {
                sql = @"" +
                    " UPDATE [Timetable]" +
                    " SET" +
                    "   [BlNo]=" + te.tt.BlNo + "," +
                    "   [DNo]='" + te.tt.DNo + "'," +
                    "   [BNo]='" + te.tt.BNo + "'," +
                    "   [FirstLaunch]='" + te.tt.FirstLaunch + "'" +
                    " WHERE [BlNo]=" + Intent.OLD_ID + "";
                db.SetBySQL(sql);

                UpdateListView();
            }
        }

        private void DeleteBtn4_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }

            String BlNo = listView4.SelectedItems[0].SubItems[0].Text;
            sql = @"" +
                " DELETE FROM [Timetable]" +
                " WHERE [BlNo]=" + BlNo + "";
            db.SetBySQL(sql);

            UpdateListView();
        }


    }
}
