namespace SchoolSystem
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
            this.SuspendLayout();
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Location = new System.Drawing.Point(60, 82);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(54, 13);
            this.namnLabel.TabIndex = 0;
            this.namnLabel.Text = "Lab namn";
            // 
            // kurslabel
            // 
            this.kurslabel.AutoSize = true;
            this.kurslabel.Location = new System.Drawing.Point(60, 115);
            this.kurslabel.Name = "kurslabel";
            this.kurslabel.Size = new System.Drawing.Size(31, 13);
            this.kurslabel.TabIndex = 1;
            this.kurslabel.Text = "Kurs ";
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
            this.createLabButton.Text = "Skapa lab";
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
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lab ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Betyg";
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
            this.button1.Text = "Sätt betyg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}