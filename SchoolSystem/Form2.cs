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
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2()
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

            if (frm1 == null)
            {
                frm1 = new Form1();
            }
            frm1.Show(this);           
        }

        private void Form2_Load(object sender, EventArgs e)
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
