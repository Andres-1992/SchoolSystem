namespace SchoolSystem
{
    partial class Form1
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.persNrBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPersNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstnametBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(332, 165);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 5;
            this.addStudentButton.Text = "Lägg till";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(101, 139);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(306, 20);
            this.emailBox.TabIndex = 4;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // persNrBox
            // 
            this.persNrBox.Location = new System.Drawing.Point(101, 113);
            this.persNrBox.Name = "persNrBox";
            this.persNrBox.Size = new System.Drawing.Size(306, 20);
            this.persNrBox.TabIndex = 3;
            this.persNrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(101, 87);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(306, 20);
            this.lastnameBox.TabIndex = 2;
            this.lastnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
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
            this.listViewStudents.Location = new System.Drawing.Point(21, 208);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(492, 374);
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
            // firstnametBox
            // 
            this.firstnametBox.Location = new System.Drawing.Point(101, 61);
            this.firstnametBox.Name = "firstnametBox";
            this.firstnametBox.Size = new System.Drawing.Size(306, 20);
            this.firstnametBox.TabIndex = 1;
            this.firstnametBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Efternamn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstnametBox);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.persNrBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.addStudentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox persNrBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNamn;
        private System.Windows.Forms.ColumnHeader chMail;
        private System.Windows.Forms.TextBox firstnametBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chPersNr;
    }
}

