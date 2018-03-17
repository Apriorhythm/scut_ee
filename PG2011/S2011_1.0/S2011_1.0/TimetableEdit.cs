using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace S2011_1._0
{
    public partial class TimetableEdit : Form
    {
        DB db;
        String sql;
        DataTable table;

        public Timetable tt;

        public TimetableEdit()
        {
            InitializeComponent();
            db = new DB();
        }

        private void TimetableEdit_Load(object sender, EventArgs e)
        {
            sql = @"SELECT [BlNo] FROM [Buslines]";
            table = db.GetBySQL(sql);
            comboBox1.DataSource = table;
            comboBox1.ValueMember = "BlNo";
            comboBox1.SelectedIndex = 0;

            sql = @"SELECT [DNo] FROM [Driver]";
            table = db.GetBySQL(sql);
            comboBox2.DataSource = table;
            comboBox2.ValueMember = "DNo";
            comboBox2.SelectedIndex = 0;

            sql = @"SELECT [BNo] FROM [Buses]";
            table = db.GetBySQL(sql);
            comboBox3.DataSource = table;
            comboBox3.ValueMember = "BNo";
            comboBox3.SelectedIndex = 0;

            if (Intent.State == "ADD")
            {
                tt = new Timetable();
            }
            else
            {
                comboBox1.SelectedValue = tt.BlNo;
                comboBox2.SelectedValue = tt.DNo;
                comboBox3.SelectedValue = tt.BNo;
                dateTimePicker1.Value = Convert.ToDateTime(tt.FirstLaunch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tt.SetValue(
                comboBox1.SelectedValue.ToString(),
                comboBox2.SelectedValue.ToString(),
                comboBox3.SelectedValue.ToString(),
                dateTimePicker1.Value.ToString()
            );


            sql = @"" +
                " SELECT * FROM [Timetable]" +
                " WHERE [BlNo]=" + tt.BlNo + "";
            table = db.GetBySQL(sql);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("路线编号重复，请修改");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
