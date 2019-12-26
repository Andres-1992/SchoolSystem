namespace SchoolSystem
{
	partial class Form3
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
            this.buttonCloseForm1 = new System.Windows.Forms.Button();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.TfirstnameBox = new System.Windows.Forms.TextBox();
            this.personNrlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.TlastnameBox = new System.Windows.Forms.TextBox();
            this.TpersNrBox = new System.Windows.Forms.TextBox();
            this.TemailBox = new System.Windows.Forms.TextBox();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.salarylabel = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPersNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonCloseForm1
            // 
            this.buttonCloseForm1.Location = new System.Drawing.Point(42, 17);
            this.buttonCloseForm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCloseForm1.Name = "buttonCloseForm1";
            this.buttonCloseForm1.Size = new System.Drawing.Size(112, 35);
            this.buttonCloseForm1.TabIndex = 24;
            this.buttonCloseForm1.Text = "Close";
            this.buttonCloseForm1.UseVisualStyleBackColor = true;
            this.buttonCloseForm1.Click += new System.EventHandler(this.buttonCloseForm1_Click);
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Location = new System.Drawing.Point(38, 143);
            this.lastnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(84, 20);
            this.lastnamelabel.TabIndex = 23;
            this.lastnamelabel.Text = "Efternamn";
            // 
            // TfirstnameBox
            // 
            this.TfirstnameBox.Location = new System.Drawing.Point(162, 97);
            this.TfirstnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TfirstnameBox.Name = "TfirstnameBox";
            this.TfirstnameBox.Size = new System.Drawing.Size(457, 26);
            this.TfirstnameBox.TabIndex = 14;
            this.TfirstnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // personNrlabel
            // 
            this.personNrlabel.AutoSize = true;
            this.personNrlabel.Location = new System.Drawing.Point(40, 183);
            this.personNrlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personNrlabel.Name = "personNrlabel";
            this.personNrlabel.Size = new System.Drawing.Size(117, 20);
            this.personNrlabel.TabIndex = 21;
            this.personNrlabel.Text = "Personnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Location = new System.Drawing.Point(40, 103);
            this.firstNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(51, 20);
            this.firstNamelabel.TabIndex = 19;
            this.firstNamelabel.Text = "Namn";
            // 
            // TlastnameBox
            // 
            this.TlastnameBox.Location = new System.Drawing.Point(162, 137);
            this.TlastnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TlastnameBox.Name = "TlastnameBox";
            this.TlastnameBox.Size = new System.Drawing.Size(457, 26);
            this.TlastnameBox.TabIndex = 15;
            this.TlastnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TpersNrBox
            // 
            this.TpersNrBox.Location = new System.Drawing.Point(162, 177);
            this.TpersNrBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TpersNrBox.Name = "TpersNrBox";
            this.TpersNrBox.Size = new System.Drawing.Size(457, 26);
            this.TpersNrBox.TabIndex = 16;
            this.TpersNrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TemailBox
            // 
            this.TemailBox.Location = new System.Drawing.Point(162, 217);
            this.TemailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TemailBox.Name = "TemailBox";
            this.TemailBox.Size = new System.Drawing.Size(457, 26);
            this.TemailBox.TabIndex = 17;
            this.TemailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(507, 289);
            this.addTeacherButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(112, 35);
            this.addTeacherButton.TabIndex = 19;
            this.addTeacherButton.Text = "Lägg till";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Location = new System.Drawing.Point(40, 259);
            this.salarylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(53, 20);
            this.salarylabel.TabIndex = 26;
            this.salarylabel.Text = "Salary";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(162, 253);
            this.salaryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(457, 26);
            this.salaryBox.TabIndex = 18;
            this.salaryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.chNamn.Width = 160;
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
            // chSalary
            // 
            this.chSalary.Text = "Salary";
            this.chSalary.Width = 160;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chNamn,
            this.chMail,
            this.chPersNr,
            this.chSalary});
            this.listViewTeachers.FullRowSelect = true;
            this.listViewTeachers.GridLines = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(7, 334);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(989, 526);
            this.listViewTeachers.TabIndex = 22;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 874);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.buttonCloseForm1);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.TfirstnameBox);
            this.Controls.Add(this.listViewTeachers);
            this.Controls.Add(this.personNrlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNamelabel);
            this.Controls.Add(this.TlastnameBox);
            this.Controls.Add(this.TpersNrBox);
            this.Controls.Add(this.TemailBox);
            this.Controls.Add(this.addTeacherButton);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCloseForm1;
		private System.Windows.Forms.Label lastnamelabel;
		private System.Windows.Forms.TextBox TfirstnameBox;
		private System.Windows.Forms.Label personNrlabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label firstNamelabel;
		private System.Windows.Forms.TextBox TlastnameBox;
		private System.Windows.Forms.TextBox TpersNrBox;
		private System.Windows.Forms.TextBox TemailBox;
		private System.Windows.Forms.Button addTeacherButton;
		private System.Windows.Forms.Label salarylabel;
		private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNamn;
        private System.Windows.Forms.ColumnHeader chMail;
        private System.Windows.Forms.ColumnHeader chPersNr;
        private System.Windows.Forms.ColumnHeader chSalary;
        private System.Windows.Forms.ListView listViewTeachers;
    }
}