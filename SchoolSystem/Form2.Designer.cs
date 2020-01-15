namespace SchoolSystem
{
    partial class Form2
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
            this.addStudentButton = new System.Windows.Forms.Button();
            this.SemailBox = new System.Windows.Forms.TextBox();
            this.SpersNrBox = new System.Windows.Forms.TextBox();
            this.SlastnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPersNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SfirstnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseForm2 = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(330, 177);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 5;
            this.addStudentButton.Text = "Lägg till";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // SemailBox
            // 
            this.SemailBox.Location = new System.Drawing.Point(99, 151);
            this.SemailBox.Name = "SemailBox";
            this.SemailBox.Size = new System.Drawing.Size(306, 20);
            this.SemailBox.TabIndex = 4;
            this.SemailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SpersNrBox
            // 
            this.SpersNrBox.Location = new System.Drawing.Point(99, 125);
            this.SpersNrBox.Name = "SpersNrBox";
            this.SpersNrBox.Size = new System.Drawing.Size(306, 20);
            this.SpersNrBox.TabIndex = 3;
            this.SpersNrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SlastnameBox
            // 
            this.SlastnameBox.Location = new System.Drawing.Point(99, 99);
            this.SlastnameBox.Name = "SlastnameBox";
            this.SlastnameBox.Size = new System.Drawing.Size(306, 20);
            this.SlastnameBox.TabIndex = 2;
            this.SlastnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Personnummer";
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chNamn,
            this.chMail,
            this.chPersNr});
            this.listViewStudents.FullRowSelect = true;
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(19, 206);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(492, 204);
            this.listViewStudents.TabIndex = 10;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 36;
            // 
            // chNamn
            // 
            this.chNamn.Text = "Namn";
            this.chNamn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNamn.Width = 131;
            // 
            // chMail
            // 
            this.chMail.Text = "Email";
            this.chMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMail.Width = 160;
            // 
            // chPersNr
            // 
            this.chPersNr.Text = "Personnummer";
            this.chPersNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPersNr.Width = 160;
            // 
            // SfirstnameBox
            // 
            this.SfirstnameBox.Location = new System.Drawing.Point(99, 73);
            this.SfirstnameBox.Name = "SfirstnameBox";
            this.SfirstnameBox.Size = new System.Drawing.Size(306, 20);
            this.SfirstnameBox.TabIndex = 1;
            this.SfirstnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Efternamn";
            // 
            // buttonCloseForm2
            // 
            this.buttonCloseForm2.Location = new System.Drawing.Point(19, 21);
            this.buttonCloseForm2.Name = "buttonCloseForm2";
            this.buttonCloseForm2.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseForm2.TabIndex = 13;
            this.buttonCloseForm2.Text = "Close";
            this.buttonCloseForm2.UseVisualStyleBackColor = true;
            this.buttonCloseForm2.Click += new System.EventHandler(this.buttonCloseForm2_Click);
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(99, 442);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(119, 20);
            this.IDbox.TabIndex = 15;
            this.IDbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(16, 449);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 13);
            this.ID.TabIndex = 16;
            this.ID.Text = "Student ID";
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(258, 439);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteStudentButton.TabIndex = 17;
            this.deleteStudentButton.Text = "Ta bort student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 601);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.buttonCloseForm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SfirstnameBox);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SlastnameBox);
            this.Controls.Add(this.SpersNrBox);
            this.Controls.Add(this.SemailBox);
            this.Controls.Add(this.addStudentButton);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox SemailBox;
        private System.Windows.Forms.TextBox SpersNrBox;
        private System.Windows.Forms.TextBox SlastnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNamn;
        private System.Windows.Forms.ColumnHeader chMail;
        private System.Windows.Forms.TextBox SfirstnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chPersNr;
        private System.Windows.Forms.Button buttonCloseForm2;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button deleteStudentButton;
    }
}

