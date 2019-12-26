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
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string name = firstnametBox.Text + " " + lastnameBox.Text;
            Student s = new Student(name, emailBox.Text, persNrBox.Text);
            students.Add(s);
            firstnametBox.Clear();
            lastnameBox.Clear();
            emailBox.Clear();
            persNrBox.Clear();

            listViewStudents.Items.Clear();
            
            foreach (Student item in students)
            {
                var listView = new ListViewItem(item.listaAttPrinta());
                //{
                //    Tag = item
                //};
                listViewStudents.Items.Add(listView);

            }
        }

        private void StudentIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hejhej");
        }
    }
}

