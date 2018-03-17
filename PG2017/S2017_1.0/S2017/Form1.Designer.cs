namespace S2017
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.addPatient = new System.Windows.Forms.Button();
            this.changePatient = new System.Windows.Forms.Button();
            this.deletePatient = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.departmentSearchBtn = new System.Windows.Forms.Button();
            this.groupSearchBtn = new System.Windows.Forms.Button();
            this.nameSearchBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelll = new System.Windows.Forms.Label();
            this.AllPatientLabel = new System.Windows.Forms.Label();
            this.MonthlyPatientLabel = new System.Windows.Forms.Label();
            this.monthComb = new System.Windows.Forms.ComboBox();
            this.monthlySearchBtn = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.changeGroupBtn = new System.Windows.Forms.Button();
            this.deleteGroupBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxNumberGroup = new System.Windows.Forms.Label();
            this.miniNumberGroup = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deletePatient);
            this.tabPage1.Controls.Add(this.changePatient);
            this.tabPage1.Controls.Add(this.addPatient);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "病人增删查改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nameSearchBtn);
            this.tabPage2.Controls.Add(this.groupSearchBtn);
            this.tabPage2.Controls.Add(this.departmentSearchBtn);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "要求2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 7);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 318);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(30, 355);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(75, 23);
            this.addPatient.TabIndex = 1;
            this.addPatient.Text = "添加";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // changePatient
            // 
            this.changePatient.Location = new System.Drawing.Point(323, 355);
            this.changePatient.Name = "changePatient";
            this.changePatient.Size = new System.Drawing.Size(75, 23);
            this.changePatient.TabIndex = 2;
            this.changePatient.Text = "修改";
            this.changePatient.UseVisualStyleBackColor = true;
            this.changePatient.Click += new System.EventHandler(this.changePatient_Click);
            // 
            // deletePatient
            // 
            this.deletePatient.Location = new System.Drawing.Point(624, 355);
            this.deletePatient.Name = "deletePatient";
            this.deletePatient.Size = new System.Drawing.Size(75, 23);
            this.deletePatient.TabIndex = 3;
            this.deletePatient.Text = "删除";
            this.deletePatient.UseVisualStyleBackColor = true;
            this.deletePatient.Click += new System.EventHandler(this.deletePatient_Click);
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(7, 7);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(755, 339);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 352);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(286, 355);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 21);
            this.textBox1.TabIndex = 3;
            // 
            // departmentSearchBtn
            // 
            this.departmentSearchBtn.Location = new System.Drawing.Point(142, 352);
            this.departmentSearchBtn.Name = "departmentSearchBtn";
            this.departmentSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.departmentSearchBtn.TabIndex = 4;
            this.departmentSearchBtn.Text = "查询";
            this.departmentSearchBtn.UseVisualStyleBackColor = true;
            this.departmentSearchBtn.Click += new System.EventHandler(this.departmentSearchBtn_Click);
            // 
            // groupSearchBtn
            // 
            this.groupSearchBtn.Location = new System.Drawing.Point(413, 355);
            this.groupSearchBtn.Name = "groupSearchBtn";
            this.groupSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.groupSearchBtn.TabIndex = 5;
            this.groupSearchBtn.Text = "查询";
            this.groupSearchBtn.UseVisualStyleBackColor = true;
            this.groupSearchBtn.Click += new System.EventHandler(this.groupSearchBtn_Click);
            // 
            // nameSearchBtn
            // 
            this.nameSearchBtn.Location = new System.Drawing.Point(656, 357);
            this.nameSearchBtn.Name = "nameSearchBtn";
            this.nameSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.nameSearchBtn.TabIndex = 6;
            this.nameSearchBtn.Text = "查询";
            this.nameSearchBtn.UseVisualStyleBackColor = true;
            this.nameSearchBtn.Click += new System.EventHandler(this.nameSearchBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteGroupBtn);
            this.tabPage3.Controls.Add(this.changeGroupBtn);
            this.tabPage3.Controls.Add(this.addGroupBtn);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "要求4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "总   病   人   数";
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Location = new System.Drawing.Point(826, 112);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(113, 12);
            this.labelll.TabIndex = 1;
            this.labelll.Text = "按月份统计病人总数";
            // 
            // AllPatientLabel
            // 
            this.AllPatientLabel.AutoSize = true;
            this.AllPatientLabel.Location = new System.Drawing.Point(960, 70);
            this.AllPatientLabel.Name = "AllPatientLabel";
            this.AllPatientLabel.Size = new System.Drawing.Size(0, 12);
            this.AllPatientLabel.TabIndex = 2;
            // 
            // MonthlyPatientLabel
            // 
            this.MonthlyPatientLabel.AutoSize = true;
            this.MonthlyPatientLabel.Location = new System.Drawing.Point(962, 111);
            this.MonthlyPatientLabel.Name = "MonthlyPatientLabel";
            this.MonthlyPatientLabel.Size = new System.Drawing.Size(0, 12);
            this.MonthlyPatientLabel.TabIndex = 3;
            // 
            // monthComb
            // 
            this.monthComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComb.FormattingEnabled = true;
            this.monthComb.Items.AddRange(new object[] {
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
            this.monthComb.Location = new System.Drawing.Point(828, 150);
            this.monthComb.Name = "monthComb";
            this.monthComb.Size = new System.Drawing.Size(121, 20);
            this.monthComb.TabIndex = 4;
            // 
            // monthlySearchBtn
            // 
            this.monthlySearchBtn.Location = new System.Drawing.Point(973, 150);
            this.monthlySearchBtn.Name = "monthlySearchBtn";
            this.monthlySearchBtn.Size = new System.Drawing.Size(75, 23);
            this.monthlySearchBtn.TabIndex = 5;
            this.monthlySearchBtn.Text = "查询";
            this.monthlySearchBtn.UseVisualStyleBackColor = true;
            this.monthlySearchBtn.Click += new System.EventHandler(this.monthlySearchBtn_Click);
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(4, 4);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(761, 336);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(20, 358);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.addGroupBtn.TabIndex = 1;
            this.addGroupBtn.Text = "添加";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // changeGroupBtn
            // 
            this.changeGroupBtn.Location = new System.Drawing.Point(353, 358);
            this.changeGroupBtn.Name = "changeGroupBtn";
            this.changeGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.changeGroupBtn.TabIndex = 2;
            this.changeGroupBtn.Text = "修改";
            this.changeGroupBtn.UseVisualStyleBackColor = true;
            this.changeGroupBtn.Click += new System.EventHandler(this.changeGroupBtn_Click);
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.Location = new System.Drawing.Point(643, 358);
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteGroupBtn.TabIndex = 3;
            this.deleteGroupBtn.Text = "删除";
            this.deleteGroupBtn.UseVisualStyleBackColor = true;
            this.deleteGroupBtn.Click += new System.EventHandler(this.deleteGroupBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "病人数最多小科室";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "病人数最少小科室";
            // 
            // maxNumberGroup
            // 
            this.maxNumberGroup.AutoSize = true;
            this.maxNumberGroup.Location = new System.Drawing.Point(961, 340);
            this.maxNumberGroup.Name = "maxNumberGroup";
            this.maxNumberGroup.Size = new System.Drawing.Size(0, 12);
            this.maxNumberGroup.TabIndex = 8;
            // 
            // miniNumberGroup
            // 
            this.miniNumberGroup.AutoSize = true;
            this.miniNumberGroup.Location = new System.Drawing.Point(960, 389);
            this.miniNumberGroup.Name = "miniNumberGroup";
            this.miniNumberGroup.Size = new System.Drawing.Size(0, 12);
            this.miniNumberGroup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(826, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "要求3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.miniNumberGroup);
            this.Controls.Add(this.maxNumberGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthlySearchBtn);
            this.Controls.Add(this.monthComb);
            this.Controls.Add(this.MonthlyPatientLabel);
            this.Controls.Add(this.AllPatientLabel);
            this.Controls.Add(this.labelll);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button deletePatient;
        private System.Windows.Forms.Button changePatient;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button nameSearchBtn;
        private System.Windows.Forms.Button groupSearchBtn;
        private System.Windows.Forms.Button departmentSearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label AllPatientLabel;
        private System.Windows.Forms.Label MonthlyPatientLabel;
        private System.Windows.Forms.ComboBox monthComb;
        private System.Windows.Forms.Button monthlySearchBtn;
        private System.Windows.Forms.Button deleteGroupBtn;
        private System.Windows.Forms.Button changeGroupBtn;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maxNumberGroup;
        private System.Windows.Forms.Label miniNumberGroup;
        private System.Windows.Forms.Label label4;
    }
}

