namespace WindowsFormsApp1
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
            this.tabCRUD = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tab31 = new System.Windows.Forms.TabPage();
            this.empnameSearchBtn = new System.Windows.Forms.Button();
            this.empnoSearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tab32 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tab33 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabCRUD.SuspendLayout();
            this.tab31.SuspendLayout();
            this.tab32.SuspendLayout();
            this.tab33.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCRUD);
            this.tabControl1.Controls.Add(this.tab31);
            this.tabControl1.Controls.Add(this.tab32);
            this.tabControl1.Controls.Add(this.tab33);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.deleteBtn);
            this.tabCRUD.Controls.Add(this.changeBtn);
            this.tabCRUD.Controls.Add(this.addBtn);
            this.tabCRUD.Controls.Add(this.listView1);
            this.tabCRUD.Location = new System.Drawing.Point(4, 22);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.Padding = new System.Windows.Forms.Padding(3);
            this.tabCRUD.Size = new System.Drawing.Size(445, 328);
            this.tabCRUD.TabIndex = 0;
            this.tabCRUD.Text = "员工增删查改";
            this.tabCRUD.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(355, 287);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(187, 287);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "修改";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(23, 287);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 274);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tab31
            // 
            this.tab31.Controls.Add(this.empnameSearchBtn);
            this.tab31.Controls.Add(this.empnoSearchBtn);
            this.tab31.Controls.Add(this.label3);
            this.tab31.Controls.Add(this.comboBox2);
            this.tab31.Controls.Add(this.comboBox1);
            this.tab31.Controls.Add(this.label2);
            this.tab31.Controls.Add(this.label1);
            this.tab31.Controls.Add(this.listView2);
            this.tab31.Location = new System.Drawing.Point(4, 22);
            this.tab31.Name = "tab31";
            this.tab31.Padding = new System.Windows.Forms.Padding(3);
            this.tab31.Size = new System.Drawing.Size(445, 328);
            this.tab31.TabIndex = 1;
            this.tab31.Text = "查询3-1";
            this.tab31.UseVisualStyleBackColor = true;
            // 
            // empnameSearchBtn
            // 
            this.empnameSearchBtn.Location = new System.Drawing.Point(358, 285);
            this.empnameSearchBtn.Name = "empnameSearchBtn";
            this.empnameSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.empnameSearchBtn.TabIndex = 7;
            this.empnameSearchBtn.Text = "查找";
            this.empnameSearchBtn.UseVisualStyleBackColor = true;
            this.empnameSearchBtn.Click += new System.EventHandler(this.empnameSearchBtn_Click);
            // 
            // empnoSearchBtn
            // 
            this.empnoSearchBtn.Location = new System.Drawing.Point(133, 282);
            this.empnoSearchBtn.Name = "empnoSearchBtn";
            this.empnoSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.empnoSearchBtn.TabIndex = 6;
            this.empnoSearchBtn.Text = "查找";
            this.empnoSearchBtn.UseVisualStyleBackColor = true;
            this.empnoSearchBtn.Click += new System.EventHandler(this.empnoSearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "根据员工号或员工名查找员工所在的公司名和工资";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(289, 287);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工号";
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(7, 46);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(432, 215);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // tab32
            // 
            this.tab32.Controls.Add(this.label4);
            this.tab32.Controls.Add(this.listView3);
            this.tab32.Location = new System.Drawing.Point(4, 22);
            this.tab32.Name = "tab32";
            this.tab32.Size = new System.Drawing.Size(445, 328);
            this.tab32.TabIndex = 2;
            this.tab32.Text = "查询3-2";
            this.tab32.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "统计年龄至少为40岁员工的总工资，工资从大到小";
            // 
            // listView3
            // 
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(3, 52);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(439, 257);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // tab33
            // 
            this.tab33.Controls.Add(this.label5);
            this.tab33.Controls.Add(this.listView4);
            this.tab33.Location = new System.Drawing.Point(4, 22);
            this.tab33.Name = "tab33";
            this.tab33.Size = new System.Drawing.Size(445, 328);
            this.tab33.TabIndex = 3;
            this.tab33.Text = "查询3-3";
            this.tab33.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "查询至少具有两份工作的员工其姓名和公司名";
            // 
            // listView4
            // 
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(3, 47);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(439, 254);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 378);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华南理工计算机复试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCRUD.ResumeLayout(false);
            this.tab31.ResumeLayout(false);
            this.tab31.PerformLayout();
            this.tab32.ResumeLayout(false);
            this.tab32.PerformLayout();
            this.tab33.ResumeLayout(false);
            this.tab33.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCRUD;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tab31;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tab32;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TabPage tab33;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empnameSearchBtn;
        private System.Windows.Forms.Button empnoSearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

