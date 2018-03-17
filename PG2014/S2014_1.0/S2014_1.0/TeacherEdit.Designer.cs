namespace S2014_1._0
{
    partial class TeacherEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TNoTextbox = new System.Windows.Forms.TextBox();
            this.TNameBox = new System.Windows.Forms.TextBox();
            this.DeptNameComb = new System.Windows.Forms.ComboBox();
            this.RNoComb = new System.Windows.Forms.ComboBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "所在系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "职称号";
            // 
            // TNoTextbox
            // 
            this.TNoTextbox.Location = new System.Drawing.Point(196, 56);
            this.TNoTextbox.MaxLength = 10;
            this.TNoTextbox.Name = "TNoTextbox";
            this.TNoTextbox.Size = new System.Drawing.Size(203, 21);
            this.TNoTextbox.TabIndex = 4;
            // 
            // TNameBox
            // 
            this.TNameBox.Location = new System.Drawing.Point(196, 122);
            this.TNameBox.MaxLength = 10;
            this.TNameBox.Name = "TNameBox";
            this.TNameBox.Size = new System.Drawing.Size(203, 21);
            this.TNameBox.TabIndex = 5;
            // 
            // DeptNameComb
            // 
            this.DeptNameComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptNameComb.FormattingEnabled = true;
            this.DeptNameComb.Items.AddRange(new object[] {
            "计算机",
            "数学",
            "物理"});
            this.DeptNameComb.Location = new System.Drawing.Point(196, 176);
            this.DeptNameComb.Name = "DeptNameComb";
            this.DeptNameComb.Size = new System.Drawing.Size(203, 20);
            this.DeptNameComb.TabIndex = 6;
            // 
            // RNoComb
            // 
            this.RNoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RNoComb.FormattingEnabled = true;
            this.RNoComb.Location = new System.Drawing.Point(196, 243);
            this.RNoComb.Name = "RNoComb";
            this.RNoComb.Size = new System.Drawing.Size(203, 20);
            this.RNoComb.TabIndex = 7;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(128, 317);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 8;
            this.ConfirmBtn.Text = "确定";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(270, 317);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TeacherEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 400);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.RNoComb);
            this.Controls.Add(this.DeptNameComb);
            this.Controls.Add(this.TNameBox);
            this.Controls.Add(this.TNoTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherEdit";
            this.Load += new System.EventHandler(this.TeacherEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TNoTextbox;
        private System.Windows.Forms.TextBox TNameBox;
        private System.Windows.Forms.ComboBox DeptNameComb;
        private System.Windows.Forms.ComboBox RNoComb;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}