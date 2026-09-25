namespace StudentManagementForm
{
    partial class AdminForm
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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.buttonShowSubjects = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonDeleteSubject = new System.Windows.Forms.Button();
            this.textBoxFeeSubject = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionSubject = new System.Windows.Forms.TextBox();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.tabPageFees = new System.Windows.Forms.TabPage();
            this.buttonAddFee = new System.Windows.Forms.Button();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmountFees = new System.Windows.Forms.TextBox();
            this.comboBoxStudentName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxFees = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.tabPageCourses.SuspendLayout();
            this.tabPageFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(501, 501);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(100, 31);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.UseWaitCursor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(19, 78);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(68, 24);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "lblRole";
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageStudents);
            this.tabControlAdmin.Controls.Add(this.tabPageCourses);
            this.tabControlAdmin.Controls.Add(this.tabPageFees);
            this.tabControlAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdmin.Location = new System.Drawing.Point(17, 114);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(585, 367);
            this.tabControlAdmin.TabIndex = 2;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageStudents.Controls.Add(this.buttonShowStudents);
            this.tabPageStudents.Controls.Add(this.listBoxStudents);
            this.tabPageStudents.Controls.Add(this.comboBoxSubject);
            this.tabPageStudents.Controls.Add(this.dateTimePickerBirthdate);
            this.tabPageStudents.Controls.Add(this.btnAddStudent);
            this.tabPageStudents.Controls.Add(this.btnSearchStudent);
            this.tabPageStudents.Controls.Add(this.textBoxStudentName);
            this.tabPageStudents.Controls.Add(this.label5);
            this.tabPageStudents.Controls.Add(this.btnDeleteStudent);
            this.tabPageStudents.Controls.Add(this.label4);
            this.tabPageStudents.Controls.Add(this.label3);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 29);
            this.tabPageStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageStudents.Size = new System.Drawing.Size(577, 334);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students List";
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudents.Location = new System.Drawing.Point(182, 125);
            this.buttonShowStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(179, 33);
            this.buttonShowStudents.TabIndex = 12;
            this.buttonShowStudents.Text = "Show Students";
            this.buttonShowStudents.UseVisualStyleBackColor = true;
            this.buttonShowStudents.Click += new System.EventHandler(this.ButtonShowStudents_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 20;
            this.listBoxStudents.Location = new System.Drawing.Point(19, 174);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(534, 124);
            this.listBoxStudents.TabIndex = 11;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.ListBoxStudents_SelectedIndexChanged);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(145, 84);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(408, 28);
            this.comboBoxSubject.TabIndex = 5;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(144, 48);
            this.dateTimePickerBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(409, 29);
            this.dateTimePickerBirthdate.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(83, 125);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(93, 33);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(465, 126);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(88, 33);
            this.btnSearchStudent.TabIndex = 10;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.BtnSearchStudent_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(145, 12);
            this.textBoxStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(408, 29);
            this.textBoxStudentName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subject:";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(367, 126);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(92, 33);
            this.btnDeleteStudent.TabIndex = 9;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birthdate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name:";
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Controls.Add(this.buttonShowSubjects);
            this.tabPageCourses.Controls.Add(this.buttonAddSubject);
            this.tabPageCourses.Controls.Add(this.buttonDeleteSubject);
            this.tabPageCourses.Controls.Add(this.textBoxFeeSubject);
            this.tabPageCourses.Controls.Add(this.textBoxDescriptionSubject);
            this.tabPageCourses.Controls.Add(this.textBoxSubjectName);
            this.tabPageCourses.Controls.Add(this.label6);
            this.tabPageCourses.Controls.Add(this.label7);
            this.tabPageCourses.Controls.Add(this.label8);
            this.tabPageCourses.Controls.Add(this.listBoxSubjects);
            this.tabPageCourses.Location = new System.Drawing.Point(4, 29);
            this.tabPageCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCourses.Size = new System.Drawing.Size(577, 334);
            this.tabPageCourses.TabIndex = 1;
            this.tabPageCourses.Text = "Subjects List";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // buttonShowSubjects
            // 
            this.buttonShowSubjects.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSubjects.Location = new System.Drawing.Point(277, 126);
            this.buttonShowSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowSubjects.Name = "buttonShowSubjects";
            this.buttonShowSubjects.Size = new System.Drawing.Size(171, 33);
            this.buttonShowSubjects.TabIndex = 23;
            this.buttonShowSubjects.Text = "Show Subjects";
            this.buttonShowSubjects.UseVisualStyleBackColor = true;
            this.buttonShowSubjects.Click += new System.EventHandler(this.ButtonShowSubjects_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(146, 126);
            this.buttonAddSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(125, 33);
            this.buttonAddSubject.TabIndex = 21;
            this.buttonAddSubject.Text = "Add";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.ButtonAddSubject_Click);
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSubject.Location = new System.Drawing.Point(454, 126);
            this.buttonDeleteSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.Size = new System.Drawing.Size(92, 33);
            this.buttonDeleteSubject.TabIndex = 22;
            this.buttonDeleteSubject.Text = "Delete";
            this.buttonDeleteSubject.UseVisualStyleBackColor = true;
            this.buttonDeleteSubject.Click += new System.EventHandler(this.ButtonDeleteSubject_Click);
            // 
            // textBoxFeeSubject
            // 
            this.textBoxFeeSubject.Location = new System.Drawing.Point(143, 84);
            this.textBoxFeeSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFeeSubject.Name = "textBoxFeeSubject";
            this.textBoxFeeSubject.Size = new System.Drawing.Size(412, 29);
            this.textBoxFeeSubject.TabIndex = 20;
            // 
            // textBoxDescriptionSubject
            // 
            this.textBoxDescriptionSubject.Location = new System.Drawing.Point(143, 49);
            this.textBoxDescriptionSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescriptionSubject.Name = "textBoxDescriptionSubject";
            this.textBoxDescriptionSubject.Size = new System.Drawing.Size(412, 29);
            this.textBoxDescriptionSubject.TabIndex = 19;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(143, 15);
            this.textBoxSubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(412, 29);
            this.textBoxSubjectName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fee:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Subject Name:";
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 20;
            this.listBoxSubjects.Location = new System.Drawing.Point(17, 174);
            this.listBoxSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(538, 124);
            this.listBoxSubjects.TabIndex = 14;
            // 
            // tabPageFees
            // 
            this.tabPageFees.Controls.Add(this.buttonAddFee);
            this.tabPageFees.Controls.Add(this.dateTimePickerPaymentDate);
            this.tabPageFees.Controls.Add(this.textBoxAmountFees);
            this.tabPageFees.Controls.Add(this.comboBoxStudentName);
            this.tabPageFees.Controls.Add(this.label9);
            this.tabPageFees.Controls.Add(this.label10);
            this.tabPageFees.Controls.Add(this.label11);
            this.tabPageFees.Controls.Add(this.listBoxFees);
            this.tabPageFees.Location = new System.Drawing.Point(4, 29);
            this.tabPageFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFees.Name = "tabPageFees";
            this.tabPageFees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFees.Size = new System.Drawing.Size(577, 334);
            this.tabPageFees.TabIndex = 2;
            this.tabPageFees.Text = "Fees List";
            this.tabPageFees.UseVisualStyleBackColor = true;
            // 
            // buttonAddFee
            // 
            this.buttonAddFee.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFee.Location = new System.Drawing.Point(431, 121);
            this.buttonAddFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddFee.Name = "buttonAddFee";
            this.buttonAddFee.Size = new System.Drawing.Size(124, 27);
            this.buttonAddFee.TabIndex = 9;
            this.buttonAddFee.Text = "Add Fee";
            this.buttonAddFee.UseVisualStyleBackColor = true;
            this.buttonAddFee.Click += new System.EventHandler(this.ButtonAddFee_Click);
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(145, 76);
            this.dateTimePickerPaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(410, 29);
            this.dateTimePickerPaymentDate.TabIndex = 8;
            // 
            // textBoxAmountFees
            // 
            this.textBoxAmountFees.Location = new System.Drawing.Point(145, 44);
            this.textBoxAmountFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmountFees.Name = "textBoxAmountFees";
            this.textBoxAmountFees.Size = new System.Drawing.Size(410, 29);
            this.textBoxAmountFees.TabIndex = 7;
            // 
            // comboBoxStudentName
            // 
            this.comboBoxStudentName.FormattingEnabled = true;
            this.comboBoxStudentName.Location = new System.Drawing.Point(145, 10);
            this.comboBoxStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudentName.Name = "comboBoxStudentName";
            this.comboBoxStudentName.Size = new System.Drawing.Size(410, 28);
            this.comboBoxStudentName.TabIndex = 6;
            this.comboBoxStudentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentName_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Payment Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Amount:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Student Name:";
            // 
            // listBoxFees
            // 
            this.listBoxFees.FormattingEnabled = true;
            this.listBoxFees.ItemHeight = 20;
            this.listBoxFees.Location = new System.Drawing.Point(15, 164);
            this.listBoxFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFees.Name = "listBoxFees";
            this.listBoxFees.Size = new System.Drawing.Size(540, 144);
            this.listBoxFees.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Admin Dashboard";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.tabPageCourses.ResumeLayout(false);
            this.tabPageCourses.PerformLayout();
            this.tabPageFees.ResumeLayout(false);
            this.tabPageFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.TabPage tabPageFees;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.ListBox listBoxFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonDeleteSubject;
        private System.Windows.Forms.TextBox textBoxFeeSubject;
        private System.Windows.Forms.TextBox textBoxDescriptionSubject;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxStudentName;
        private System.Windows.Forms.Button buttonAddFee;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.TextBox textBoxAmountFees;
        private System.Windows.Forms.Button buttonShowStudents;
        private System.Windows.Forms.Button buttonShowSubjects;
    }
}