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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonStudents = new System.Windows.Forms.Button();
			this.buttonTeacher = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(864, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menyToolStripMenuItem
			// 
			this.menyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
			this.menyToolStripMenuItem.Name = "menyToolStripMenuItem";
			this.menyToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
			this.menyToolStripMenuItem.Text = "Menu";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
			this.closeToolStripMenuItem.Text = "close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// buttonStudents
			// 
			this.buttonStudents.Location = new System.Drawing.Point(136, 179);
			this.buttonStudents.Name = "buttonStudents";
			this.buttonStudents.Size = new System.Drawing.Size(150, 76);
			this.buttonStudents.TabIndex = 1;
			this.buttonStudents.Text = "Students";
			this.buttonStudents.UseVisualStyleBackColor = true;
			this.buttonStudents.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonTeacher
			// 
			this.buttonTeacher.Location = new System.Drawing.Point(547, 179);
			this.buttonTeacher.Name = "buttonTeacher";
			this.buttonTeacher.Size = new System.Drawing.Size(150, 76);
			this.buttonTeacher.TabIndex = 2;
			this.buttonTeacher.Text = "Teachers";
			this.buttonTeacher.UseVisualStyleBackColor = true;
			this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 532);
			this.Controls.Add(this.buttonTeacher);
			this.Controls.Add(this.buttonStudents);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonTeacher;
    }
}