﻿namespace SchoolSystem
{
    partial class Form5
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
            this.namnLabel = new System.Windows.Forms.Label();
            this.kurslabel = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.createLabButton = new System.Windows.Forms.Button();
            this.lIDtextBox = new System.Windows.Forms.TextBox();
            this.sIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.betygtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewLab = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Location = new System.Drawing.Point(60, 82);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(51, 13);
            this.namnLabel.TabIndex = 0;
            this.namnLabel.Text = "Labname";
            // 
            // kurslabel
            // 
            this.kurslabel.AutoSize = true;
            this.kurslabel.Location = new System.Drawing.Point(60, 115);
            this.kurslabel.Name = "kurslabel";
            this.kurslabel.Size = new System.Drawing.Size(51, 13);
            this.kurslabel.TabIndex = 1;
            this.kurslabel.Text = "CourseID";
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(16, 12);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 2;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // createLabButton
            // 
            this.createLabButton.Location = new System.Drawing.Point(170, 152);
            this.createLabButton.Name = "createLabButton";
            this.createLabButton.Size = new System.Drawing.Size(75, 23);
            this.createLabButton.TabIndex = 5;
            this.createLabButton.Text = "Add lab";
            this.createLabButton.UseVisualStyleBackColor = true;
            this.createLabButton.Click += new System.EventHandler(this.createLabButton_Click);
            // 
            // lIDtextBox
            // 
            this.lIDtextBox.Location = new System.Drawing.Point(607, 48);
            this.lIDtextBox.Name = "lIDtextBox";
            this.lIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.lIDtextBox.TabIndex = 6;
            // 
            // sIDtextBox
            // 
            this.sIDtextBox.Location = new System.Drawing.Point(607, 81);
            this.sIDtextBox.Name = "sIDtextBox";
            this.sIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.sIDtextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "LabID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "StudentID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade";
            // 
            // betygtextBox
            // 
            this.betygtextBox.Location = new System.Drawing.Point(607, 116);
            this.betygtextBox.Name = "betygtextBox";
            this.betygtextBox.Size = new System.Drawing.Size(100, 20);
            this.betygtextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Grade student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewLab
            // 
            this.listViewLab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chCourse});
            this.listViewLab.FullRowSelect = true;
            this.listViewLab.GridLines = true;
            this.listViewLab.HideSelection = false;
            this.listViewLab.Location = new System.Drawing.Point(49, 208);
            this.listViewLab.Name = "listViewLab";
            this.listViewLab.Size = new System.Drawing.Size(283, 204);
            this.listViewLab.TabIndex = 14;
            this.listViewLab.UseCompatibleStateImageBehavior = false;
            this.listViewLab.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 36;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 105;
            // 
            // chCourse
            // 
            this.chCourse.Text = "Course";
            this.chCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCourse.Width = 133;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(383, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(391, 173);
            this.listBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Show student grades";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Student ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(513, 407);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 20);
            this.textBox3.TabIndex = 17;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listViewLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.betygtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sIDtextBox);
            this.Controls.Add(this.lIDtextBox);
            this.Controls.Add(this.createLabButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.kurslabel);
            this.Controls.Add(this.namnLabel);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namnLabel;
        private System.Windows.Forms.Label kurslabel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createLabButton;
        private System.Windows.Forms.TextBox lIDtextBox;
        private System.Windows.Forms.TextBox sIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox betygtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewLab;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCourse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}