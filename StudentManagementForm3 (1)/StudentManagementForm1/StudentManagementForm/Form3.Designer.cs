namespace StudentManagementForm
{
    partial class UserForm
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
            this.lblRole = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.labelSubjectsStudent = new System.Windows.Forms.Label();
            this.labelAgeStudent = new System.Windows.Forms.Label();
            this.labelNameStudent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageFeesStudent = new System.Windows.Forms.TabPage();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.labelFeesPaid = new System.Windows.Forms.Label();
            this.labelOutstandingBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageSubjectsStudent = new System.Windows.Forms.TabPage();
            this.listBoxSubjectsEnrolled = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlAdmin.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.tabPageFeesStudent.SuspendLayout();
            this.tabPageSubjectsStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(27, 59);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 17);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "lblRole";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.LogoutBtn.Location = new System.Drawing.Point(479, 276);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(100, 41);
            this.LogoutBtn.TabIndex = 8;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.UseWaitCursor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Dashboard";
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPagePersonalInfo);
            this.tabControlAdmin.Controls.Add(this.tabPageFeesStudent);
            this.tabControlAdmin.Controls.Add(this.tabPageSubjectsStudent);
            this.tabControlAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.tabControlAdmin.Location = new System.Drawing.Point(13, 94);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(567, 175);
            this.tabControlAdmin.TabIndex = 13;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.labelSubjectsStudent);
            this.tabPagePersonalInfo.Controls.Add(this.labelAgeStudent);
            this.tabPagePersonalInfo.Controls.Add(this.labelNameStudent);
            this.tabPagePersonalInfo.Controls.Add(this.label5);
            this.tabPagePersonalInfo.Controls.Add(this.label4);
            this.tabPagePersonalInfo.Controls.Add(this.label3);
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPagePersonalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(559, 142);
            this.tabPagePersonalInfo.TabIndex = 0;
            this.tabPagePersonalInfo.Text = "Personal Info";
            this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
            this.tabPagePersonalInfo.Click += new System.EventHandler(this.TabPageStudents_Click);
            // 
            // labelSubjectsStudent
            // 
            this.labelSubjectsStudent.AutoSize = true;
            this.labelSubjectsStudent.Location = new System.Drawing.Point(115, 87);
            this.labelSubjectsStudent.Name = "labelSubjectsStudent";
            this.labelSubjectsStudent.Size = new System.Drawing.Size(73, 20);
            this.labelSubjectsStudent.TabIndex = 14;
            this.labelSubjectsStudent.Text = "Subjects";
            // 
            // labelAgeStudent
            // 
            this.labelAgeStudent.AutoSize = true;
            this.labelAgeStudent.Location = new System.Drawing.Point(115, 52);
            this.labelAgeStudent.Name = "labelAgeStudent";
            this.labelAgeStudent.Size = new System.Drawing.Size(105, 20);
            this.labelAgeStudent.TabIndex = 13;
            this.labelAgeStudent.Text = "Student Age";
            // 
            // labelNameStudent
            // 
            this.labelNameStudent.AutoSize = true;
            this.labelNameStudent.Location = new System.Drawing.Point(115, 18);
            this.labelNameStudent.Name = "labelNameStudent";
            this.labelNameStudent.Size = new System.Drawing.Size(118, 20);
            this.labelNameStudent.TabIndex = 12;
            this.labelNameStudent.Text = "Student Name";
            this.labelNameStudent.Click += new System.EventHandler(this.labelNameStudent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subject/s:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // tabPageFeesStudent
            // 
            this.tabPageFeesStudent.Controls.Add(this.labelTotalFees);
            this.tabPageFeesStudent.Controls.Add(this.labelFeesPaid);
            this.tabPageFeesStudent.Controls.Add(this.labelOutstandingBalance);
            this.tabPageFeesStudent.Controls.Add(this.label6);
            this.tabPageFeesStudent.Controls.Add(this.label7);
            this.tabPageFeesStudent.Controls.Add(this.label8);
            this.tabPageFeesStudent.Location = new System.Drawing.Point(4, 29);
            this.tabPageFeesStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFeesStudent.Name = "tabPageFeesStudent";
            this.tabPageFeesStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFeesStudent.Size = new System.Drawing.Size(559, 142);
            this.tabPageFeesStudent.TabIndex = 1;
            this.tabPageFeesStudent.Text = "Fees";
            this.tabPageFeesStudent.UseVisualStyleBackColor = true;
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.AutoSize = true;
            this.labelTotalFees.Location = new System.Drawing.Point(216, 18);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(88, 20);
            this.labelTotalFees.TabIndex = 20;
            this.labelTotalFees.Text = "Total Fees";
            // 
            // labelFeesPaid
            // 
            this.labelFeesPaid.AutoSize = true;
            this.labelFeesPaid.Location = new System.Drawing.Point(216, 52);
            this.labelFeesPaid.Name = "labelFeesPaid";
            this.labelFeesPaid.Size = new System.Drawing.Size(82, 20);
            this.labelFeesPaid.TabIndex = 19;
            this.labelFeesPaid.Text = "Fees Paid";
            // 
            // labelOutstandingBalance
            // 
            this.labelOutstandingBalance.AutoSize = true;
            this.labelOutstandingBalance.Location = new System.Drawing.Point(216, 87);
            this.labelOutstandingBalance.Name = "labelOutstandingBalance";
            this.labelOutstandingBalance.Size = new System.Drawing.Size(168, 20);
            this.labelOutstandingBalance.TabIndex = 18;
            this.labelOutstandingBalance.Text = "Outstanding Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Outstanding Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fees Paid:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Fees:";
            // 
            // tabPageSubjectsStudent
            // 
            this.tabPageSubjectsStudent.Controls.Add(this.listBoxSubjectsEnrolled);
            this.tabPageSubjectsStudent.Controls.Add(this.label10);
            this.tabPageSubjectsStudent.Location = new System.Drawing.Point(4, 29);
            this.tabPageSubjectsStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSubjectsStudent.Name = "tabPageSubjectsStudent";
            this.tabPageSubjectsStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSubjectsStudent.Size = new System.Drawing.Size(559, 142);
            this.tabPageSubjectsStudent.TabIndex = 2;
            this.tabPageSubjectsStudent.Text = "Subjects List";
            this.tabPageSubjectsStudent.UseVisualStyleBackColor = true;
            // 
            // listBoxSubjectsEnrolled
            // 
            this.listBoxSubjectsEnrolled.FormattingEnabled = true;
            this.listBoxSubjectsEnrolled.ItemHeight = 20;
            this.listBoxSubjectsEnrolled.Location = new System.Drawing.Point(13, 41);
            this.listBoxSubjectsEnrolled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSubjectsEnrolled.Name = "listBoxSubjectsEnrolled";
            this.listBoxSubjectsEnrolled.Size = new System.Drawing.Size(527, 84);
            this.listBoxSubjectsEnrolled.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Subjects Enrolled:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(592, 330);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.LogoutBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.tabPagePersonalInfo.PerformLayout();
            this.tabPageFeesStudent.ResumeLayout(false);
            this.tabPageFeesStudent.PerformLayout();
            this.tabPageSubjectsStudent.ResumeLayout(false);
            this.tabPageSubjectsStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageFeesStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageSubjectsStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSubjectsStudent;
        private System.Windows.Forms.Label labelAgeStudent;
        private System.Windows.Forms.Label labelNameStudent;
        private System.Windows.Forms.Label labelTotalFees;
        private System.Windows.Forms.Label labelFeesPaid;
        private System.Windows.Forms.Label labelOutstandingBalance;
        private System.Windows.Forms.ListBox listBoxSubjectsEnrolled;
    }
}