using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;
        Form5 frm5;
        List<Student> studenter = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Course> courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            if (frm2 == null)
            {             
                frm2= new Form2();
                frm2.SetAllStudents(studenter);
            }
            frm2.Show(this);           
        }       
        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (frm3 == null)
            {
                frm3 = new Form3();
                frm3.SetAllTeachers(teachers);
            }
            frm3.Show(this);        
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (frm4== null)
            {
                frm4 = new Form4();
                frm4.SetAll(studenter,teachers,courses);
                

            }
            frm4.Show(this);
        }

        private void labButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            if (frm5 == null)
            {
                frm5 = new Form5();
                frm5.SetAll(studenter, teachers,courses);


            }
            frm5.Show(this);
        }
    }
}
