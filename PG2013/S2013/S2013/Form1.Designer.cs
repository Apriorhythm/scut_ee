namespace S2013
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.GenderBtn = new System.Windows.Forms.Button();
            this.GenderComb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNoComb = new System.Windows.Forms.ComboBox();
            this.TNameComb = new System.Windows.Forms.ComboBox();
            this.TNoBtn = new System.Windows.Forms.Button();
            this.TNameBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YearComb = new System.Windows.Forms.ComboBox();
            this.YearSearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GenderComb);
            this.tabPage1.Controls.Add(this.GenderBtn);
            this.tabPage1.Controls.Add(this.DeleteBtn);
            this.tabPage1.Controls.Add(this.ChangeBtn);
            this.tabPage1.Controls.Add(this.AddBtn);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "要求2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TNameBtn);
            this.tabPage2.Controls.Add(this.TNoBtn);
            this.tabPage2.Controls.Add(this.TNameComb);
            this.tabPage2.Controls.Add(this.TNoComb);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "要求3.1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.YearSearchBtn);
            this.tabPage3.Controls.Add(this.YearComb);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "要求3.2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(767, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "要求3.3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 7);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(4, 7);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(757, 328);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(4, 3);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(760, 337);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(4, 48);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(760, 348);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(22, 347);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(184, 346);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "修改";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(370, 346);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // GenderBtn
            // 
            this.GenderBtn.Location = new System.Drawing.Point(673, 347);
            this.GenderBtn.Name = "GenderBtn";
            this.GenderBtn.Size = new System.Drawing.Size(75, 23);
            this.GenderBtn.TabIndex = 4;
            this.GenderBtn.Text = "查询";
            this.GenderBtn.UseVisualStyleBackColor = true;
            this.GenderBtn.Click += new System.EventHandler(this.GenderBtn_Click);
            // 
            // GenderComb
            // 
            this.GenderComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComb.FormattingEnabled = true;
            this.GenderComb.Items.AddRange(new object[] {
            "男",
            "女"});
            this.GenderComb.Location = new System.Drawing.Point(532, 350);
            this.GenderComb.Name = "GenderComb";
            this.GenderComb.Size = new System.Drawing.Size(121, 20);
            this.GenderComb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "教师号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "教师名";
            // 
            // TNoComb
            // 
            this.TNoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TNoComb.FormattingEnabled = true;
            this.TNoComb.Location = new System.Drawing.Point(108, 352);
            this.TNoComb.Name = "TNoComb";
            this.TNoComb.Size = new System.Drawing.Size(121, 20);
            this.TNoComb.TabIndex = 3;
            // 
            // TNameComb
            // 
            this.TNameComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TNameComb.FormattingEnabled = true;
            this.TNameComb.Location = new System.Drawing.Point(517, 352);
            this.TNameComb.Name = "TNameComb";
            this.TNameComb.Size = new System.Drawing.Size(121, 20);
            this.TNameComb.TabIndex = 4;
            // 
            // TNoBtn
            // 
            this.TNoBtn.Location = new System.Drawing.Point(257, 352);
            this.TNoBtn.Name = "TNoBtn";
            this.TNoBtn.Size = new System.Drawing.Size(75, 23);
            this.TNoBtn.TabIndex = 5;
            this.TNoBtn.Text = "查询";
            this.TNoBtn.UseVisualStyleBackColor = true;
            this.TNoBtn.Click += new System.EventHandler(this.TNoBtn_Click);
            // 
            // TNameBtn
            // 
            this.TNameBtn.Location = new System.Drawing.Point(658, 349);
            this.TNameBtn.Name = "TNameBtn";
            this.TNameBtn.Size = new System.Drawing.Size(75, 23);
            this.TNameBtn.TabIndex = 6;
            this.TNameBtn.Text = "查询";
            this.TNameBtn.UseVisualStyleBackColor = true;
            this.TNameBtn.Click += new System.EventHandler(this.TNameBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "年份";
            // 
            // YearComb
            // 
            this.YearComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComb.FormattingEnabled = true;
            this.YearComb.Location = new System.Drawing.Point(308, 353);
            this.YearComb.Name = "YearComb";
            this.YearComb.Size = new System.Drawing.Size(121, 20);
            this.YearComb.TabIndex = 2;
            // 
            // YearSearchBtn
            // 
            this.YearSearchBtn.Location = new System.Drawing.Point(452, 351);
            this.YearSearchBtn.Name = "YearSearchBtn";
            this.YearSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.YearSearchBtn.TabIndex = 3;
            this.YearSearchBtn.Text = "查询";
            this.YearSearchBtn.UseVisualStyleBackColor = true;
            this.YearSearchBtn.Click += new System.EventHandler(this.YearSearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "查询所有教授课程至少两门以上的老师的名字和课程名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华南理工计算机研究生复试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox GenderComb;
        private System.Windows.Forms.Button GenderBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Button TNameBtn;
        private System.Windows.Forms.Button TNoBtn;
        private System.Windows.Forms.ComboBox TNameComb;
        private System.Windows.Forms.ComboBox TNoComb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YearSearchBtn;
        private System.Windows.Forms.ComboBox YearComb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

