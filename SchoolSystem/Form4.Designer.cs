﻿namespace SchoolSystem
{
    partial class Form4
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
            this.closeButton = new System.Windows.Forms.Button();
            this.addCoursebutton = new System.Windows.Forms.Button();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.HPbox = new System.Windows.Forms.TextBox();
            this.courseIDbox = new System.Windows.Forms.TextBox();
            this.studentIDbox = new System.Windows.Forms.TextBox();
            this.teacherIDbox = new System.Windows.Forms.TextBox();
            this.addToCoursebutton = new System.Windows.Forms.Button();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.HPlabel = new System.Windows.Forms.Label();
            this.courseID = new System.Windows.Forms.Label();
            this.sIDlabel = new System.Windows.Forms.Label();
            this.tIDlabel = new System.Windows.Forms.Label();
            this.listViewCourses = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteCoursebutton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.deleteTeacherbutton = new System.Windows.Forms.Button();
            this.cIDbox2 = new System.Windows.Forms.TextBox();
            this.deleteStudentbutton = new System.Windows.Forms.Button();
            this.cIDbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tIDbox = new System.Windows.Forms.TextBox();
            this.sIDbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allStudentsinCourse = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cIDbox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cIDbox4 = new System.Windows.Forms.TextBox();
            this.teacherTeaminCourse = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(13, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addCoursebutton
            // 
            this.addCoursebutton.Location = new System.Drawing.Point(289, 227);
            this.addCoursebutton.Name = "addCoursebutton";
            this.addCoursebutton.Size = new System.Drawing.Size(75, 23);
            this.addCoursebutton.TabIndex = 1;
            this.addCoursebutton.Text = "Skapa kurs";
            this.addCoursebutton.UseVisualStyleBackColor = true;
            this.addCoursebutton.Click += new System.EventHandler(this.addCoursebutton_Click);
            // 
            // courseNameBox
            // 
            this.courseNameBox.Location = new System.Drawing.Point(110, 99);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(254, 20);
            this.courseNameBox.TabIndex = 2;
            // 
            // HPbox
            // 
            this.HPbox.Location = new System.Drawing.Point(110, 159);
            this.HPbox.Name = "HPbox";
            this.HPbox.Size = new System.Drawing.Size(100, 20);
            this.HPbox.TabIndex = 3;
            // 
            // courseIDbox
            // 
            this.courseIDbox.Location = new System.Drawing.Point(492, 106);
            this.courseIDbox.Name = "courseIDbox";
            this.courseIDbox.Size = new System.Drawing.Size(100, 20);
            this.courseIDbox.TabIndex = 4;
            // 
            // studentIDbox
            // 
            this.studentIDbox.Location = new System.Drawing.Point(492, 143);
            this.studentIDbox.Name = "studentIDbox";
            this.studentIDbox.Size = new System.Drawing.Size(100, 20);
            this.studentIDbox.TabIndex = 5;
            // 
            // teacherIDbox
            // 
            this.teacherIDbox.Location = new System.Drawing.Point(492, 173);
            this.teacherIDbox.Name = "teacherIDbox";
            this.teacherIDbox.Size = new System.Drawing.Size(100, 20);
            this.teacherIDbox.TabIndex = 6;
            // 
            // addToCoursebutton
            // 
            this.addToCoursebutton.Location = new System.Drawing.Point(492, 230);
            this.addToCoursebutton.Name = "addToCoursebutton";
            this.addToCoursebutton.Size = new System.Drawing.Size(100, 23);
            this.addToCoursebutton.TabIndex = 7;
            this.addToCoursebutton.Text = "Lägg till i kurs";
            this.addToCoursebutton.UseVisualStyleBackColor = true;
            this.addToCoursebutton.Click += new System.EventHandler(this.addToCoursebutton_Click);
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(31, 106);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(57, 13);
            this.courseNameLabel.TabIndex = 8;
            this.courseNameLabel.Text = "Kurs namn";
            // 
            // HPlabel
            // 
            this.HPlabel.AutoSize = true;
            this.HPlabel.Location = new System.Drawing.Point(31, 166);
            this.HPlabel.Name = "HPlabel";
            this.HPlabel.Size = new System.Drawing.Size(22, 13);
            this.HPlabel.TabIndex = 9;
            this.HPlabel.Text = "HP";
            // 
            // courseID
            // 
            this.courseID.AutoSize = true;
            this.courseID.Location = new System.Drawing.Point(429, 109);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(42, 13);
            this.courseID.TabIndex = 10;
            this.courseID.Text = "Kurs ID";
            // 
            // sIDlabel
            // 
            this.sIDlabel.AutoSize = true;
            this.sIDlabel.Location = new System.Drawing.Point(429, 146);
            this.sIDlabel.Name = "sIDlabel";
            this.sIDlabel.Size = new System.Drawing.Size(58, 13);
            this.sIDlabel.TabIndex = 11;
            this.sIDlabel.Text = "Student ID";
            // 
            // tIDlabel
            // 
            this.tIDlabel.AutoSize = true;
            this.tIDlabel.Location = new System.Drawing.Point(429, 176);
            this.tIDlabel.Name = "tIDlabel";
            this.tIDlabel.Size = new System.Drawing.Size(61, 13);
            this.tIDlabel.TabIndex = 12;
            this.tIDlabel.Text = "Teacher ID";
            // 
            // listViewCourses
            // 
            this.listViewCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chHP,
            this.chNamn});
            this.listViewCourses.FullRowSelect = true;
            this.listViewCourses.GridLines = true;
            this.listViewCourses.HideSelection = false;
            this.listViewCourses.Location = new System.Drawing.Point(34, 278);
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.Size = new System.Drawing.Size(338, 204);
            this.listViewCourses.TabIndex = 13;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            this.listViewCourses.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 36;
            // 
            // chHP
            // 
            this.chHP.Text = "HP";
            this.chHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHP.Width = 131;
            // 
            // chNamn
            // 
            this.chNamn.Text = "Namn";
            this.chNamn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNamn.Width = 160;
            // 
            // deleteCoursebutton
            // 
            this.deleteCoursebutton.Location = new System.Drawing.Point(286, 523);
            this.deleteCoursebutton.Name = "deleteCoursebutton";
            this.deleteCoursebutton.Size = new System.Drawing.Size(75, 23);
            this.deleteCoursebutton.TabIndex = 20;
            this.deleteCoursebutton.Text = "Ta bort student";
            this.deleteCoursebutton.UseVisualStyleBackColor = true;
            this.deleteCoursebutton.Click += new System.EventHandler(this.deleteCoursebutton_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(31, 533);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(42, 13);
            this.ID.TabIndex = 19;
            this.ID.Text = "Kurs ID";
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(123, 526);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(119, 20);
            this.IDbox.TabIndex = 18;
            this.IDbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteTeacherbutton
            // 
            this.deleteTeacherbutton.Location = new System.Drawing.Point(1004, 758);
            this.deleteTeacherbutton.Name = "deleteTeacherbutton";
            this.deleteTeacherbutton.Size = new System.Drawing.Size(75, 23);
            this.deleteTeacherbutton.TabIndex = 23;
            this.deleteTeacherbutton.Text = "Ta bort student";
            this.deleteTeacherbutton.UseVisualStyleBackColor = true;
            this.deleteTeacherbutton.Click += new System.EventHandler(this.deleteTeacherbutton_Click);
            // 
            // cIDbox2
            // 
            this.cIDbox2.Location = new System.Drawing.Point(667, 754);
            this.cIDbox2.Name = "cIDbox2";
            this.cIDbox2.Size = new System.Drawing.Size(119, 20);
            this.cIDbox2.TabIndex = 21;
            this.cIDbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteStudentbutton
            // 
            this.deleteStudentbutton.Location = new System.Drawing.Point(1004, 380);
            this.deleteStudentbutton.Name = "deleteStudentbutton";
            this.deleteStudentbutton.Size = new System.Drawing.Size(75, 23);
            this.deleteStudentbutton.TabIndex = 26;
            this.deleteStudentbutton.Text = "Ta bort student";
            this.deleteStudentbutton.UseVisualStyleBackColor = true;
            this.deleteStudentbutton.Click += new System.EventHandler(this.deleteStudentbutton_Click);
            // 
            // cIDbox1
            // 
            this.cIDbox1.Location = new System.Drawing.Point(667, 378);
            this.cIDbox1.Name = "cIDbox1";
            this.cIDbox1.Size = new System.Drawing.Size(119, 20);
            this.cIDbox1.TabIndex = 24;
            this.cIDbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Teacher ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kurs ID";
            // 
            // tIDbox
            // 
            this.tIDbox.Location = new System.Drawing.Point(880, 758);
            this.tIDbox.Name = "tIDbox";
            this.tIDbox.Size = new System.Drawing.Size(100, 20);
            this.tIDbox.TabIndex = 29;
            // 
            // sIDbox
            // 
            this.sIDbox.Location = new System.Drawing.Point(880, 380);
            this.sIDbox.Name = "sIDbox";
            this.sIDbox.Size = new System.Drawing.Size(100, 20);
            this.sIDbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 754);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kurs ID";
            // 
            // allStudentsinCourse
            // 
            this.allStudentsinCourse.FormattingEnabled = true;
            this.allStudentsinCourse.Location = new System.Drawing.Point(708, 173);
            this.allStudentsinCourse.Name = "allStudentsinCourse";
            this.allStudentsinCourse.Size = new System.Drawing.Size(268, 199);
            this.allStudentsinCourse.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Kurs ID";
            // 
            // cIDbox3
            // 
            this.cIDbox3.Location = new System.Drawing.Point(801, 109);
            this.cIDbox3.Name = "cIDbox3";
            this.cIDbox3.Size = new System.Drawing.Size(119, 20);
            this.cIDbox3.TabIndex = 35;
            this.cIDbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Visa ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(822, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Visa ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kurs ID";
            // 
            // cIDbox4
            // 
            this.cIDbox4.Location = new System.Drawing.Point(803, 485);
            this.cIDbox4.Name = "cIDbox4";
            this.cIDbox4.Size = new System.Drawing.Size(119, 20);
            this.cIDbox4.TabIndex = 39;
            this.cIDbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // teacherTeaminCourse
            // 
            this.teacherTeaminCourse.FormattingEnabled = true;
            this.teacherTeaminCourse.Location = new System.Drawing.Point(710, 549);
            this.teacherTeaminCourse.Name = "teacherTeaminCourse";
            this.teacherTeaminCourse.Size = new System.Drawing.Size(268, 199);
            this.teacherTeaminCourse.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(798, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Studenter";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(800, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 38);
            this.label8.TabIndex = 43;
            this.label8.Text = "Lärare";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 836);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cIDbox4);
            this.Controls.Add(this.teacherTeaminCourse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cIDbox3);
            this.Controls.Add(this.allStudentsinCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tIDbox);
            this.Controls.Add(this.sIDbox);
            this.Controls.Add(this.deleteStudentbutton);
            this.Controls.Add(this.cIDbox1);
            this.Controls.Add(this.deleteTeacherbutton);
            this.Controls.Add(this.cIDbox2);
            this.Controls.Add(this.deleteCoursebutton);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.listViewCourses);
            this.Controls.Add(this.tIDlabel);
            this.Controls.Add(this.sIDlabel);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.HPlabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.addToCoursebutton);
            this.Controls.Add(this.teacherIDbox);
            this.Controls.Add(this.studentIDbox);
            this.Controls.Add(this.courseIDbox);
            this.Controls.Add(this.HPbox);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.addCoursebutton);
            this.Controls.Add(this.closeButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addCoursebutton;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.TextBox HPbox;
        private System.Windows.Forms.TextBox courseIDbox;
        private System.Windows.Forms.TextBox studentIDbox;
        private System.Windows.Forms.TextBox teacherIDbox;
        private System.Windows.Forms.Button addToCoursebutton;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label HPlabel;
        private System.Windows.Forms.Label courseID;
        private System.Windows.Forms.Label sIDlabel;
        private System.Windows.Forms.Label tIDlabel;
        private System.Windows.Forms.ListView listViewCourses;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chHP;
        private System.Windows.Forms.ColumnHeader chNamn;
        private System.Windows.Forms.Button deleteCoursebutton;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Button deleteTeacherbutton;
        private System.Windows.Forms.TextBox cIDbox2;
        private System.Windows.Forms.Button deleteStudentbutton;
        private System.Windows.Forms.TextBox cIDbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tIDbox;
        private System.Windows.Forms.TextBox sIDbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox allStudentsinCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cIDbox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cIDbox4;
        private System.Windows.Forms.ListBox teacherTeaminCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}