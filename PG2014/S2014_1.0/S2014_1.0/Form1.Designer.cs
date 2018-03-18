namespace S2014_1._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeptComb = new System.Windows.Forms.ComboBox();
            this.DeptSearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TNameSearchBtn = new System.Windows.Forms.Button();
            this.TNoSearchBtn = new System.Windows.Forms.Button();
            this.TNameComb = new System.Windows.Forms.ComboBox();
            this.TNoComb = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
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
            this.tabControl1.Size = new System.Drawing.Size(895, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DeptComb);
            this.tabPage1.Controls.Add(this.DeptSearchBtn);
            this.tabPage1.Controls.Add(this.DeleteBtn);
            this.tabPage1.Controls.Add(this.ChangeBtn);
            this.tabPage1.Controls.Add(this.AddBtn);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "要求1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "学院";
            // 
            // DeptComb
            // 
            this.DeptComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptComb.FormattingEnabled = true;
            this.DeptComb.Items.AddRange(new object[] {
            "计算机",
            "物理",
            "数学"});
            this.DeptComb.Location = new System.Drawing.Point(636, 414);
            this.DeptComb.Name = "DeptComb";
            this.DeptComb.Size = new System.Drawing.Size(121, 20);
            this.DeptComb.TabIndex = 5;
            // 
            // DeptSearchBtn
            // 
            this.DeptSearchBtn.Location = new System.Drawing.Point(779, 411);
            this.DeptSearchBtn.Name = "DeptSearchBtn";
            this.DeptSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.DeptSearchBtn.TabIndex = 4;
            this.DeptSearchBtn.Text = "查询";
            this.DeptSearchBtn.UseVisualStyleBackColor = true;
            this.DeptSearchBtn.Click += new System.EventHandler(this.DeptSearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(304, 411);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(162, 411);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "修改";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(27, 411);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 7);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(874, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TNameSearchBtn);
            this.tabPage2.Controls.Add(this.TNoSearchBtn);
            this.tabPage2.Controls.Add(this.TNameComb);
            this.tabPage2.Controls.Add(this.TNoComb);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "要求2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TNameSearchBtn
            // 
            this.TNameSearchBtn.Location = new System.Drawing.Point(703, 411);
            this.TNameSearchBtn.Name = "TNameSearchBtn";
            this.TNameSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.TNameSearchBtn.TabIndex = 4;
            this.TNameSearchBtn.Text = "查询";
            this.TNameSearchBtn.UseVisualStyleBackColor = true;
            this.TNameSearchBtn.Click += new System.EventHandler(this.TNameSearchBtn_Click);
            // 
            // TNoSearchBtn
            // 
            this.TNoSearchBtn.Location = new System.Drawing.Point(207, 411);
            this.TNoSearchBtn.Name = "TNoSearchBtn";
            this.TNoSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.TNoSearchBtn.TabIndex = 3;
            this.TNoSearchBtn.Text = "查询";
            this.TNoSearchBtn.UseVisualStyleBackColor = true;
            this.TNoSearchBtn.Click += new System.EventHandler(this.TNoSearchBtn_Click);
            // 
            // TNameComb
            // 
            this.TNameComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TNameComb.FormattingEnabled = true;
            this.TNameComb.Location = new System.Drawing.Point(556, 414);
            this.TNameComb.Name = "TNameComb";
            this.TNameComb.Size = new System.Drawing.Size(121, 20);
            this.TNameComb.TabIndex = 2;
            // 
            // TNoComb
            // 
            this.TNoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TNoComb.FormattingEnabled = true;
            this.TNoComb.Location = new System.Drawing.Point(36, 414);
            this.TNoComb.Name = "TNoComb";
            this.TNoComb.Size = new System.Drawing.Size(121, 20);
            this.TNoComb.TabIndex = 1;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(7, 7);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(874, 378);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(887, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "要求3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "统计只上一门课的教师";
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(3, 55);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(881, 409);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(887, 467);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "要求4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "统计教师总工资";
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(4, 56);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(880, 408);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华南理工计算机复试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeptComb;
        private System.Windows.Forms.Button DeptSearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Button TNameSearchBtn;
        private System.Windows.Forms.Button TNoSearchBtn;
        private System.Windows.Forms.ComboBox TNameComb;
        private System.Windows.Forms.ComboBox TNoComb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

