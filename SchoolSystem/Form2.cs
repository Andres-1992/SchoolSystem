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
        List<Student> students = new List<Student>();
        public void SetAllStudents(List<Student> s)
        {
            students = s;
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string name = SfirstnameBox.Text + " " + SlastnameBox.Text;
            Student s = new Student(name, SemailBox.Text, SpersNrBox.Text);
            students.Add(s);
            SfirstnameBox.Clear();
            SlastnameBox.Clear();
            SemailBox.Clear();
            SpersNrBox.Clear();

            listViewStudents.Items.Clear();

            foreach (Student item in students)
            {
                var listView = new ListViewItem(item.ListaAttPrinta());
                listViewStudents.Items.Add(listView);
            }

        }
        private void buttonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {

            Student s = students.Find(x => (x.GetID().Equals(int.Parse(IDbox.Text))));
            students.Remove(s);
            IDbox.Clear();
            listViewStudents.Items.Clear();

            foreach (Student item in students)
            {
                var listView = new ListViewItem(item.ListaAttPrinta());
                listViewStudents.Items.Add(listView);
            }
        }
    }
}

