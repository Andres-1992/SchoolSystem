namespace SchoolSystem
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
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(37, 34);
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
            this.courseIDbox.Location = new System.Drawing.Point(763, 103);
            this.courseIDbox.Name = "courseIDbox";
            this.courseIDbox.Size = new System.Drawing.Size(100, 20);
            this.courseIDbox.TabIndex = 4;
            // 
            // studentIDbox
            // 
            this.studentIDbox.Location = new System.Drawing.Point(763, 140);
            this.studentIDbox.Name = "studentIDbox";
            this.studentIDbox.Size = new System.Drawing.Size(100, 20);
            this.studentIDbox.TabIndex = 5;
            // 
            // teacherIDbox
            // 
            this.teacherIDbox.Location = new System.Drawing.Point(763, 170);
            this.teacherIDbox.Name = "teacherIDbox";
            this.teacherIDbox.Size = new System.Drawing.Size(100, 20);
            this.teacherIDbox.TabIndex = 6;
            // 
            // addToCoursebutton
            // 
            this.addToCoursebutton.Location = new System.Drawing.Point(763, 227);
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
            this.courseID.Location = new System.Drawing.Point(700, 106);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(42, 13);
            this.courseID.TabIndex = 10;
            this.courseID.Text = "Kurs ID";
            // 
            // sIDlabel
            // 
            this.sIDlabel.AutoSize = true;
            this.sIDlabel.Location = new System.Drawing.Point(700, 143);
            this.sIDlabel.Name = "sIDlabel";
            this.sIDlabel.Size = new System.Drawing.Size(58, 13);
            this.sIDlabel.TabIndex = 11;
            this.sIDlabel.Text = "Student ID";
            // 
            // tIDlabel
            // 
            this.tIDlabel.AutoSize = true;
            this.tIDlabel.Location = new System.Drawing.Point(700, 173);
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
            this.listViewCourses.Size = new System.Drawing.Size(330, 204);
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
            this.deleteCoursebutton.Location = new System.Drawing.Point(286, 594);
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
            this.ID.Location = new System.Drawing.Point(31, 604);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(42, 13);
            this.ID.TabIndex = 19;
            this.ID.Text = "Kurs ID";
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(123, 597);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(119, 20);
            this.IDbox.TabIndex = 18;
            this.IDbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteTeacherbutton
            // 
            this.deleteTeacherbutton.Location = new System.Drawing.Point(857, 595);
            this.deleteTeacherbutton.Name = "deleteTeacherbutton";
            this.deleteTeacherbutton.Size = new System.Drawing.Size(75, 23);
            this.deleteTeacherbutton.TabIndex = 23;
            this.deleteTeacherbutton.Text = "Ta bort student";
            this.deleteTeacherbutton.UseVisualStyleBackColor = true;
            this.deleteTeacherbutton.Click += new System.EventHandler(this.deleteTeacherbutton_Click);
            // 
            // cIDbox2
            // 
            this.cIDbox2.Location = new System.Drawing.Point(520, 591);
            this.cIDbox2.Name = "cIDbox2";
            this.cIDbox2.Size = new System.Drawing.Size(119, 20);
            this.cIDbox2.TabIndex = 21;
            this.cIDbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteStudentbutton
            // 
            this.deleteStudentbutton.Location = new System.Drawing.Point(857, 565);
            this.deleteStudentbutton.Name = "deleteStudentbutton";
            this.deleteStudentbutton.Size = new System.Drawing.Size(75, 23);
            this.deleteStudentbutton.TabIndex = 26;
            this.deleteStudentbutton.Text = "Ta bort student";
            this.deleteStudentbutton.UseVisualStyleBackColor = true;
            this.deleteStudentbutton.Click += new System.EventHandler(this.deleteStudentbutton_Click);
            // 
            // cIDbox1
            // 
            this.cIDbox1.Location = new System.Drawing.Point(520, 563);
            this.cIDbox1.Name = "cIDbox1";
            this.cIDbox1.Size = new System.Drawing.Size(119, 20);
            this.cIDbox1.TabIndex = 24;
            this.cIDbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Teacher ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kurs ID";
            // 
            // tIDbox
            // 
            this.tIDbox.Location = new System.Drawing.Point(733, 595);
            this.tIDbox.Name = "tIDbox";
            this.tIDbox.Size = new System.Drawing.Size(100, 20);
            this.tIDbox.TabIndex = 29;
            // 
            // sIDbox
            // 
            this.sIDbox.Location = new System.Drawing.Point(733, 565);
            this.sIDbox.Name = "sIDbox";
            this.sIDbox.Size = new System.Drawing.Size(100, 20);
            this.sIDbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kurs ID";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 700);
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
    }
}