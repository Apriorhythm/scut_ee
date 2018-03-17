namespace S2017_2._0
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.ChangePatientBtn = new System.Windows.Forms.Button();
            this.DeletePatientBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentDrop = new System.Windows.Forms.ComboBox();
            this.GroupDrop = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.departSearchBtn = new System.Windows.Forms.Button();
            this.GroupSearchBtn = new System.Windows.Forms.Button();
            this.NameSearchBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.monthlySearchComb = new System.Windows.Forms.ComboBox();
            this.monthlySearchBtn = new System.Windows.Forms.Button();
            this.monthlySearchLabel = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.AddGroupBtn = new System.Windows.Forms.Button();
            this.ChangeGroupBtn = new System.Windows.Forms.Button();
            this.DeleteGroupBtn = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 484);
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
            this.tabPage1.Size = new System.Drawing.Size(889, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "病人信息增删查改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NameSearchBtn);
            this.tabPage2.Controls.Add(this.GroupSearchBtn);
            this.tabPage2.Controls.Add(this.departSearchBtn);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.GroupDrop);
            this.tabPage2.Controls.Add(this.departmentDrop);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "要求2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.monthlySearchLabel);
            this.tabPage3.Controls.Add(this.monthlySearchBtn);
            this.tabPage3.Controls.Add(this.monthlySearchComb);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(889, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "要求3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 371);
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
            this.listView2.Size = new System.Drawing.Size(876, 366);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.Location = new System.Drawing.Point(38, 410);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPatientBtn.TabIndex = 1;
            this.AddPatientBtn.Text = "添加";
            this.AddPatientBtn.UseVisualStyleBackColor = true;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // ChangePatientBtn
            // 
            this.ChangePatientBtn.Location = new System.Drawing.Point(378, 410);
            this.ChangePatientBtn.Name = "ChangePatientBtn";
            this.ChangePatientBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangePatientBtn.TabIndex = 2;
            this.ChangePatientBtn.Text = "修改";
            this.ChangePatientBtn.UseVisualStyleBackColor = true;
            this.ChangePatientBtn.Click += new System.EventHandler(this.ChangePatientBtn_Click);
            // 
            // DeletePatientBtn
            // 
            this.DeletePatientBtn.Location = new System.Drawing.Point(721, 410);
            this.DeletePatientBtn.Name = "DeletePatientBtn";
            this.DeletePatientBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletePatientBtn.TabIndex = 3;
            this.DeletePatientBtn.Text = "删除";
            this.DeletePatientBtn.UseVisualStyleBackColor = true;
            this.DeletePatientBtn.Click += new System.EventHandler(this.DeletePatientBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "大科室名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "小科室名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "病人姓名";
            // 
            // departmentDrop
            // 
            this.departmentDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentDrop.FormattingEnabled = true;
            this.departmentDrop.Location = new System.Drawing.Point(76, 406);
            this.departmentDrop.Name = "departmentDrop";
            this.departmentDrop.Size = new System.Drawing.Size(121, 20);
            this.departmentDrop.TabIndex = 4;
            // 
            // GroupDrop
            // 
            this.GroupDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupDrop.FormattingEnabled = true;
            this.GroupDrop.Location = new System.Drawing.Point(379, 406);
            this.GroupDrop.Name = "GroupDrop";
            this.GroupDrop.Size = new System.Drawing.Size(121, 20);
            this.GroupDrop.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(684, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // departSearchBtn
            // 
            this.departSearchBtn.Location = new System.Drawing.Point(203, 404);
            this.departSearchBtn.Name = "departSearchBtn";
            this.departSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.departSearchBtn.TabIndex = 7;
            this.departSearchBtn.Text = "查询";
            this.departSearchBtn.UseVisualStyleBackColor = true;
            this.departSearchBtn.Click += new System.EventHandler(this.departSearchBtn_Click);
            // 
            // GroupSearchBtn
            // 
            this.GroupSearchBtn.Location = new System.Drawing.Point(506, 404);
            this.GroupSearchBtn.Name = "GroupSearchBtn";
            this.GroupSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.GroupSearchBtn.TabIndex = 8;
            this.GroupSearchBtn.Text = "查询";
            this.GroupSearchBtn.UseVisualStyleBackColor = true;
            this.GroupSearchBtn.Click += new System.EventHandler(this.GroupSearchBtn_Click);
            // 
            // NameSearchBtn
            // 
            this.NameSearchBtn.Location = new System.Drawing.Point(790, 404);
            this.NameSearchBtn.Name = "NameSearchBtn";
            this.NameSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.NameSearchBtn.TabIndex = 9;
            this.NameSearchBtn.Text = "查询";
            this.NameSearchBtn.UseVisualStyleBackColor = true;
            this.NameSearchBtn.Click += new System.EventHandler(this.NameSearchBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeleteGroupBtn);
            this.tabPage4.Controls.Add(this.ChangeGroupBtn);
            this.tabPage4.Controls.Add(this.AddGroupBtn);
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(889, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "要求4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(3, 3);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(466, 452);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "小科室按月份统计";
            // 
            // monthlySearchComb
            // 
            this.monthlySearchComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthlySearchComb.FormattingEnabled = true;
            this.monthlySearchComb.Items.AddRange(new object[] {
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
            this.monthlySearchComb.Location = new System.Drawing.Point(501, 122);
            this.monthlySearchComb.Name = "monthlySearchComb";
            this.monthlySearchComb.Size = new System.Drawing.Size(140, 20);
            this.monthlySearchComb.TabIndex = 2;
            // 
            // monthlySearchBtn
            // 
            this.monthlySearchBtn.Location = new System.Drawing.Point(677, 122);
            this.monthlySearchBtn.Name = "monthlySearchBtn";
            this.monthlySearchBtn.Size = new System.Drawing.Size(75, 23);
            this.monthlySearchBtn.TabIndex = 3;
            this.monthlySearchBtn.Text = "确定";
            this.monthlySearchBtn.UseVisualStyleBackColor = true;
            this.monthlySearchBtn.Click += new System.EventHandler(this.monthlySearchBtn_Click);
            // 
            // monthlySearchLabel
            // 
            this.monthlySearchLabel.AutoSize = true;
            this.monthlySearchLabel.Location = new System.Drawing.Point(642, 87);
            this.monthlySearchLabel.Name = "monthlySearchLabel";
            this.monthlySearchLabel.Size = new System.Drawing.Size(0, 12);
            this.monthlySearchLabel.TabIndex = 4;
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(3, 3);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(883, 399);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.Location = new System.Drawing.Point(43, 408);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.AddGroupBtn.TabIndex = 1;
            this.AddGroupBtn.Text = "添加";
            this.AddGroupBtn.UseVisualStyleBackColor = true;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // ChangeGroupBtn
            // 
            this.ChangeGroupBtn.Location = new System.Drawing.Point(401, 408);
            this.ChangeGroupBtn.Name = "ChangeGroupBtn";
            this.ChangeGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeGroupBtn.TabIndex = 2;
            this.ChangeGroupBtn.Text = "修改";
            this.ChangeGroupBtn.UseVisualStyleBackColor = true;
            this.ChangeGroupBtn.Click += new System.EventHandler(this.ChangeGroupBtn_Click);
            // 
            // DeleteGroupBtn
            // 
            this.DeleteGroupBtn.Location = new System.Drawing.Point(744, 408);
            this.DeleteGroupBtn.Name = "DeleteGroupBtn";
            this.DeleteGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteGroupBtn.TabIndex = 3;
            this.DeleteGroupBtn.Text = "删除";
            this.DeleteGroupBtn.UseVisualStyleBackColor = true;
            this.DeleteGroupBtn.Click += new System.EventHandler(this.DeleteGroupBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 503);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Button DeletePatientBtn;
        private System.Windows.Forms.Button ChangePatientBtn;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button NameSearchBtn;
        private System.Windows.Forms.Button GroupSearchBtn;
        private System.Windows.Forms.Button departSearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox GroupDrop;
        private System.Windows.Forms.ComboBox departmentDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label monthlySearchLabel;
        private System.Windows.Forms.Button monthlySearchBtn;
        private System.Windows.Forms.ComboBox monthlySearchComb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteGroupBtn;
        private System.Windows.Forms.Button ChangeGroupBtn;
        private System.Windows.Forms.Button AddGroupBtn;
        private System.Windows.Forms.ListView listView4;
    }
}

