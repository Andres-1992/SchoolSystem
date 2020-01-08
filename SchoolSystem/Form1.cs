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
        public Form1()
        {
            InitializeComponent();
        }
         List<Student> studenter = new List<Student>();
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
                frm2.SetAllPeople(studenter);
            }
            frm2.Show(this);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form3 frm3;
        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (frm3 == null)
            {
                frm3 = new Form3();
            }
            frm3.Show(this);        
        }
    }
}
