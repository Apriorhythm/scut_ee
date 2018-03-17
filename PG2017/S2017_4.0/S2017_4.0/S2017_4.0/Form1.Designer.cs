namespace S2017_4._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.ChangePatientBtn = new System.Windows.Forms.Button();
            this.DeletePatientBtn = new System.Windows.Forms.Button();
            this.DeptSearchBtn = new System.Windows.Forms.Button();
            this.GroupSearchBtn = new System.Windows.Forms.Button();
            this.NameSearchBtn = new System.Windows.Forms.Button();
            this.CombineSearchBtn = new System.Windows.Forms.Button();
            this.DeptComb = new System.Windows.Forms.ComboBox();
            this.GroupComb = new System.Windows.Forms.ComboBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MonthlyComb = new System.Windows.Forms.ComboBox();
            this.MonthSumLabel = new System.Windows.Forms.Label();
            this.MonthSumBtn = new System.Windows.Forms.Button();
            this.AddGroupBtn = new System.Windows.Forms.Button();
            this.ChangeGroupBtn = new System.Windows.Forms.Button();
            this.DeleteGroupBtn = new System.Windows.Forms.Button();
            this.ReloadTab4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeletePatientBtn);
            this.tabPage1.Controls.Add(this.ChangePatientBtn);
            this.tabPage1.Controls.Add(this.AddPatientBtn);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "病人表增删查改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.NameTextbox);
            this.tabPage2.Controls.Add(this.GroupComb);
            this.tabPage2.Controls.Add(this.DeptComb);
            this.tabPage2.Controls.Add(this.CombineSearchBtn);
            this.tabPage2.Controls.Add(this.NameSearchBtn);
            this.tabPage2.Controls.Add(this.GroupSearchBtn);
            this.tabPage2.Controls.Add(this.DeptSearchBtn);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "要求 1)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MonthSumBtn);
            this.tabPage3.Controls.Add(this.MonthSumLabel);
            this.tabPage3.Controls.Add(this.MonthlyComb);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(918, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "要求 3)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ReloadTab4);
            this.tabPage4.Controls.Add(this.DeleteGroupBtn);
            this.tabPage4.Controls.Add(this.ChangeGroupBtn);
            this.tabPage4.Controls.Add(this.AddGroupBtn);
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(918, 434);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "要求 4)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 7);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(905, 354);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(7, 7);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(905, 358);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(4, 4);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(417, 414);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(4, 4);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(911, 377);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.Location = new System.Drawing.Point(62, 377);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPatientBtn.TabIndex = 1;
            this.AddPatientBtn.Text = "添加";
            this.AddPatientBtn.UseVisualStyleBackColor = true;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // ChangePatientBtn
            // 
            this.ChangePatientBtn.Location = new System.Drawing.Point(415, 376);
            this.ChangePatientBtn.Name = "ChangePatientBtn";
            this.ChangePatientBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangePatientBtn.TabIndex = 2;
            this.ChangePatientBtn.Text = "修改";
            this.ChangePatientBtn.UseVisualStyleBackColor = true;
            this.ChangePatientBtn.Click += new System.EventHandler(this.ChangePatientBtn_Click);
            // 
            // DeletePatientBtn
            // 
            this.DeletePatientBtn.Location = new System.Drawing.Point(772, 377);
            this.DeletePatientBtn.Name = "DeletePatientBtn";
            this.DeletePatientBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletePatientBtn.TabIndex = 3;
            this.DeletePatientBtn.Text = "删除";
            this.DeletePatientBtn.UseVisualStyleBackColor = true;
            this.DeletePatientBtn.Click += new System.EventHandler(this.DeletePatientBtn_Click);
            // 
            // DeptSearchBtn
            // 
            this.DeptSearchBtn.Location = new System.Drawing.Point(180, 373);
            this.DeptSearchBtn.Name = "DeptSearchBtn";
            this.DeptSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.DeptSearchBtn.TabIndex = 1;
            this.DeptSearchBtn.Text = "查询";
            this.DeptSearchBtn.UseVisualStyleBackColor = true;
            this.DeptSearchBtn.Click += new System.EventHandler(this.DeptSearchBtn_Click);
            // 
            // GroupSearchBtn
            // 
            this.GroupSearchBtn.Location = new System.Drawing.Point(466, 373);
            this.GroupSearchBtn.Name = "GroupSearchBtn";
            this.GroupSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.GroupSearchBtn.TabIndex = 2;
            this.GroupSearchBtn.Text = "查询";
            this.GroupSearchBtn.UseVisualStyleBackColor = true;
            this.GroupSearchBtn.Click += new System.EventHandler(this.GroupSearchBtn_Click);
            // 
            // NameSearchBtn
            // 
            this.NameSearchBtn.Location = new System.Drawing.Point(724, 372);
            this.NameSearchBtn.Name = "NameSearchBtn";
            this.NameSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.NameSearchBtn.TabIndex = 3;
            this.NameSearchBtn.Text = "查询";
            this.NameSearchBtn.UseVisualStyleBackColor = true;
            this.NameSearchBtn.Click += new System.EventHandler(this.NameSearchBtn_Click);
            // 
            // CombineSearchBtn
            // 
            this.CombineSearchBtn.Location = new System.Drawing.Point(826, 373);
            this.CombineSearchBtn.Name = "CombineSearchBtn";
            this.CombineSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.CombineSearchBtn.TabIndex = 4;
            this.CombineSearchBtn.Text = "组合查询";
            this.CombineSearchBtn.UseVisualStyleBackColor = true;
            this.CombineSearchBtn.Click += new System.EventHandler(this.CombineSearchBtn_Click);
            // 
            // DeptComb
            // 
            this.DeptComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptComb.FormattingEnabled = true;
            this.DeptComb.Location = new System.Drawing.Point(53, 375);
            this.DeptComb.Name = "DeptComb";
            this.DeptComb.Size = new System.Drawing.Size(121, 20);
            this.DeptComb.TabIndex = 5;
            this.DeptComb.SelectedIndexChanged += new System.EventHandler(this.DeptComb_SelectedIndexChanged);
            // 
            // GroupComb
            // 
            this.GroupComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComb.FormattingEnabled = true;
            this.GroupComb.Location = new System.Drawing.Point(339, 375);
            this.GroupComb.Name = "GroupComb";
            this.GroupComb.Size = new System.Drawing.Size(121, 20);
            this.GroupComb.TabIndex = 6;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(618, 373);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 21);
            this.NameTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "大科室";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "小课室";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "病人姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "按小科室月份统计";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "月份";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "人数";
            // 
            // MonthlyComb
            // 
            this.MonthlyComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthlyComb.FormattingEnabled = true;
            this.MonthlyComb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthlyComb.Location = new System.Drawing.Point(510, 73);
            this.MonthlyComb.Name = "MonthlyComb";
            this.MonthlyComb.Size = new System.Drawing.Size(121, 20);
            this.MonthlyComb.TabIndex = 4;
            // 
            // MonthSumLabel
            // 
            this.MonthSumLabel.AutoSize = true;
            this.MonthSumLabel.Location = new System.Drawing.Point(510, 120);
            this.MonthSumLabel.Name = "MonthSumLabel";
            this.MonthSumLabel.Size = new System.Drawing.Size(0, 12);
            this.MonthSumLabel.TabIndex = 5;
            // 
            // MonthSumBtn
            // 
            this.MonthSumBtn.Location = new System.Drawing.Point(657, 71);
            this.MonthSumBtn.Name = "MonthSumBtn";
            this.MonthSumBtn.Size = new System.Drawing.Size(75, 23);
            this.MonthSumBtn.TabIndex = 6;
            this.MonthSumBtn.Text = "查询";
            this.MonthSumBtn.UseVisualStyleBackColor = true;
            this.MonthSumBtn.Click += new System.EventHandler(this.MonthSumBtn_Click);
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.Location = new System.Drawing.Point(60, 388);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.AddGroupBtn.TabIndex = 1;
            this.AddGroupBtn.Text = "添加";
            this.AddGroupBtn.UseVisualStyleBackColor = true;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // ChangeGroupBtn
            // 
            this.ChangeGroupBtn.Location = new System.Drawing.Point(299, 388);
            this.ChangeGroupBtn.Name = "ChangeGroupBtn";
            this.ChangeGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeGroupBtn.TabIndex = 2;
            this.ChangeGroupBtn.Text = "修改";
            this.ChangeGroupBtn.UseVisualStyleBackColor = true;
            this.ChangeGroupBtn.Click += new System.EventHandler(this.ChangeGroupBtn_Click);
            // 
            // DeleteGroupBtn
            // 
            this.DeleteGroupBtn.Location = new System.Drawing.Point(540, 387);
            this.DeleteGroupBtn.Name = "DeleteGroupBtn";
            this.DeleteGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteGroupBtn.TabIndex = 3;
            this.DeleteGroupBtn.Text = "删除";
            this.DeleteGroupBtn.UseVisualStyleBackColor = true;
            this.DeleteGroupBtn.Click += new System.EventHandler(this.DeleteGroupBtn_Click);
            // 
            // ReloadTab4
            // 
            this.ReloadTab4.Location = new System.Drawing.Point(780, 388);
            this.ReloadTab4.Name = "ReloadTab4";
            this.ReloadTab4.Size = new System.Drawing.Size(75, 23);
            this.ReloadTab4.TabIndex = 4;
            this.ReloadTab4.Text = "重新读取所有数据";
            this.ReloadTab4.UseVisualStyleBackColor = true;
            this.ReloadTab4.Click += new System.EventHandler(this.ReloadTab4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 479);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华南理工计算机复试2017";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button DeletePatientBtn;
        private System.Windows.Forms.Button ChangePatientBtn;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.ComboBox GroupComb;
        private System.Windows.Forms.ComboBox DeptComb;
        private System.Windows.Forms.Button CombineSearchBtn;
        private System.Windows.Forms.Button NameSearchBtn;
        private System.Windows.Forms.Button GroupSearchBtn;
        private System.Windows.Forms.Button DeptSearchBtn;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Button MonthSumBtn;
        private System.Windows.Forms.Label MonthSumLabel;
        private System.Windows.Forms.ComboBox MonthlyComb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteGroupBtn;
        private System.Windows.Forms.Button ChangeGroupBtn;
        private System.Windows.Forms.Button AddGroupBtn;
        private System.Windows.Forms.Button ReloadTab4;
    }
}

