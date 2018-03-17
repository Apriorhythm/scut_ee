namespace S2016_2._0
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
            this.CombineSearchBtn = new System.Windows.Forms.Button();
            this.StudentSearchBtn = new System.Windows.Forms.Button();
            this.ClassSearchBtn = new System.Windows.Forms.Button();
            this.DeptSearchBtn = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.ClassComb = new System.Windows.Forms.ComboBox();
            this.DeptComb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.YearSearchBtn = new System.Windows.Forms.Button();
            this.YearComb = new System.Windows.Forms.ComboBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
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
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CombineSearchBtn);
            this.tabPage1.Controls.Add(this.StudentSearchBtn);
            this.tabPage1.Controls.Add(this.ClassSearchBtn);
            this.tabPage1.Controls.Add(this.DeptSearchBtn);
            this.tabPage1.Controls.Add(this.NameText);
            this.tabPage1.Controls.Add(this.ClassComb);
            this.tabPage1.Controls.Add(this.DeptComb);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "要求 (1)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CombineSearchBtn
            // 
            this.CombineSearchBtn.Location = new System.Drawing.Point(917, 378);
            this.CombineSearchBtn.Name = "CombineSearchBtn";
            this.CombineSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.CombineSearchBtn.TabIndex = 10;
            this.CombineSearchBtn.Text = "组合查询";
            this.CombineSearchBtn.UseVisualStyleBackColor = true;
            this.CombineSearchBtn.Click += new System.EventHandler(this.CombineSearchBtn_Click);
            // 
            // StudentSearchBtn
            // 
            this.StudentSearchBtn.Location = new System.Drawing.Point(797, 378);
            this.StudentSearchBtn.Name = "StudentSearchBtn";
            this.StudentSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentSearchBtn.TabIndex = 9;
            this.StudentSearchBtn.Text = "查询";
            this.StudentSearchBtn.UseVisualStyleBackColor = true;
            this.StudentSearchBtn.Click += new System.EventHandler(this.StudentSearchBtn_Click);
            // 
            // ClassSearchBtn
            // 
            this.ClassSearchBtn.Location = new System.Drawing.Point(491, 382);
            this.ClassSearchBtn.Name = "ClassSearchBtn";
            this.ClassSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.ClassSearchBtn.TabIndex = 8;
            this.ClassSearchBtn.Text = "查询";
            this.ClassSearchBtn.UseVisualStyleBackColor = true;
            this.ClassSearchBtn.Click += new System.EventHandler(this.ClassSearchBtn_Click);
            // 
            // DeptSearchBtn
            // 
            this.DeptSearchBtn.Location = new System.Drawing.Point(181, 381);
            this.DeptSearchBtn.Name = "DeptSearchBtn";
            this.DeptSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.DeptSearchBtn.TabIndex = 7;
            this.DeptSearchBtn.Text = "查询";
            this.DeptSearchBtn.UseVisualStyleBackColor = true;
            this.DeptSearchBtn.Click += new System.EventHandler(this.DeptSearchBtn_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(649, 380);
            this.NameText.MaxLength = 10;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(142, 21);
            this.NameText.TabIndex = 6;
            // 
            // ClassComb
            // 
            this.ClassComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComb.FormattingEnabled = true;
            this.ClassComb.Location = new System.Drawing.Point(364, 384);
            this.ClassComb.Name = "ClassComb";
            this.ClassComb.Size = new System.Drawing.Size(121, 20);
            this.ClassComb.TabIndex = 5;
            // 
            // DeptComb
            // 
            this.DeptComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptComb.FormattingEnabled = true;
            this.DeptComb.Location = new System.Drawing.Point(54, 383);
            this.DeptComb.Name = "DeptComb";
            this.DeptComb.Size = new System.Drawing.Size(121, 20);
            this.DeptComb.TabIndex = 4;
            this.DeptComb.SelectedIndexChanged += new System.EventHandler(this.DeptComb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "学生名字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "专业名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "系名称";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 7);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1010, 362);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.YearSearchBtn);
            this.tabPage2.Controls.Add(this.YearComb);
            this.tabPage2.Controls.Add(this.listView4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "要求 (2)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // YearSearchBtn
            // 
            this.YearSearchBtn.Location = new System.Drawing.Point(923, 16);
            this.YearSearchBtn.Name = "YearSearchBtn";
            this.YearSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.YearSearchBtn.TabIndex = 5;
            this.YearSearchBtn.Text = "查询";
            this.YearSearchBtn.UseVisualStyleBackColor = true;
            this.YearSearchBtn.Click += new System.EventHandler(this.YearSearchBtn_Click);
            // 
            // YearComb
            // 
            this.YearComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComb.FormattingEnabled = true;
            this.YearComb.Location = new System.Drawing.Point(752, 19);
            this.YearComb.Name = "YearComb";
            this.YearComb.Size = new System.Drawing.Size(121, 20);
            this.YearComb.TabIndex = 4;
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(570, 59);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(428, 360);
            this.listView4.TabIndex = 3;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "按照入学年份统计学生人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "统计系人数";
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(7, 59);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(419, 375);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteBtn);
            this.tabPage3.Controls.Add(this.ChangeBtn);
            this.tabPage3.Controls.Add(this.AddBtn);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1024, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "要求 (3)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(893, 385);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(486, 385);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "修改";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(34, 385);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(4, 4);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1013, 362);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 476);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华南理工计算机复试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CombineSearchBtn;
        private System.Windows.Forms.Button StudentSearchBtn;
        private System.Windows.Forms.Button ClassSearchBtn;
        private System.Windows.Forms.Button DeptSearchBtn;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.ComboBox ClassComb;
        private System.Windows.Forms.ComboBox DeptComb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button YearSearchBtn;
        private System.Windows.Forms.ComboBox YearComb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}

