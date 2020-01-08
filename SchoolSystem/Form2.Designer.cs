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
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(495, 272);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(112, 35);
            this.addStudentButton.TabIndex = 5;
            this.addStudentButton.Text = "Lägg till";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // SemailBox
            // 
            this.SemailBox.Location = new System.Drawing.Point(149, 232);
            this.SemailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SemailBox.Name = "SemailBox";
            this.SemailBox.Size = new System.Drawing.Size(457, 26);
            this.SemailBox.TabIndex = 4;
            this.SemailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SpersNrBox
            // 
            this.SpersNrBox.Location = new System.Drawing.Point(149, 192);
            this.SpersNrBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpersNrBox.Name = "SpersNrBox";
            this.SpersNrBox.Size = new System.Drawing.Size(457, 26);
            this.SpersNrBox.TabIndex = 3;
            this.SpersNrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SlastnameBox
            // 
            this.SlastnameBox.Location = new System.Drawing.Point(149, 152);
            this.SlastnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SlastnameBox.Name = "SlastnameBox";
            this.SlastnameBox.Size = new System.Drawing.Size(457, 26);
            this.SlastnameBox.TabIndex = 2;
            this.SlastnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
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
            this.listViewStudents.Location = new System.Drawing.Point(29, 317);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(736, 573);
            this.listViewStudents.TabIndex = 10;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            this.listViewStudents.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
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
            this.SfirstnameBox.Location = new System.Drawing.Point(149, 112);
            this.SfirstnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SfirstnameBox.Name = "SfirstnameBox";
            this.SfirstnameBox.Size = new System.Drawing.Size(457, 26);
            this.SfirstnameBox.TabIndex = 1;
            this.SfirstnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Efternamn";
            // 
            // buttonCloseForm2
            // 
            this.buttonCloseForm2.Location = new System.Drawing.Point(29, 32);
            this.buttonCloseForm2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCloseForm2.Name = "buttonCloseForm2";
            this.buttonCloseForm2.Size = new System.Drawing.Size(112, 35);
            this.buttonCloseForm2.TabIndex = 13;
            this.buttonCloseForm2.Text = "Close";
            this.buttonCloseForm2.UseVisualStyleBackColor = true;
            this.buttonCloseForm2.Click += new System.EventHandler(this.buttonCloseForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 925);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
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
    }
}

